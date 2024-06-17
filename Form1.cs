using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.Json;


using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace resaurant_management_windows
{
    public partial class MainForm : Form
    {
        private string token;
        private const string HOST = "http://localhost:8000";
            //"https://rst-mgt-service.onrender.com";
        private float TotalPrice = 0.0f;
        private List<OrderedItem> OrderedItems = new List<OrderedItem>(); 
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowLoginPanel(object sender, EventArgs e)
        {
            loginPanel.Visible = true;
            signupPanel.Visible = false;
        }
        private void ShowSignupPanel(object sender, EventArgs e)
        {
            loginPanel.Visible = false;
            signupPanel.Visible = true;
        }
        private async void BtnAPICall_Click(object sender, EventArgs e)
        {
            try
            {
                string updateData = @"{
                                    ""name"": ""Saigon perfect bread"",
                                    ""price"": 2.5,
                                    ""description"": ""Vietnam perfect bread"",
                                    ""category"": ""Bread""
                    }";
                // Thay thế URL bằng địa chỉ API thực tế bạn muốn gọi
                string apiUrl = "http://localhost:3000/admin/addProduct";
                string postData =
                "{\"name\": \"Bún chả Hà Nội\", \"price\": 1.5, \"description\": \"Hue delicious bun bo\", \"category\": \"Noodles\"}";
                StringContent content = new StringContent(postData, Encoding.UTF8, "application/json");
                // Khởi tạo đối tượng HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thực hiện cuộc gọi API và đợi phản hồi
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    // Kiểm tra xem cuộc gọi API có thành công hay không (200 OK)
                    if (response.IsSuccessStatusCode)
                    {
                        // Đọc nội dung phản hồi
                        string responseData = await response.Content.ReadAsStringAsync();

                        // Xử lý dữ liệu từ API ở đây
                        MessageBox.Show("API Response: " + responseData);
                    }
                    else
                    {
                        MessageBox.Show("API call failed. Status code: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        // sign up
        private async void SignupBtn_Click(object sender, EventArgs e)
        {
            if (SignupPassword.Text == SignupPasswordConfirm.Text)
            {
                SignupBtn.Enabled = false;
                try
                {
                    string username = SignupUsername.Text;
                    string password = SignupPassword.Text;
                    string postData =
                    $"{{\"username\": \"{username}\", \"password\": \"{password}\"}}";
                    StringContent content = new StringContent(postData, Encoding.UTF8, "application/json");
                    string apiUrl = HOST + "/auth/register";
                    using (HttpClient client = new HttpClient())
                    {
                        HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                        if (response.IsSuccessStatusCode)
                        {
                           
                            string responseData = await response.Content.ReadAsStringAsync();

                            MessageBox.Show("API Response: " + responseData);
                            ShowLoginPanel(this.ShowLoginBtn, e);
                        }
                        else
                        {
                            MessageBox.Show("API call failed. Status code: " + response.StatusCode);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                SignupBtn.Enabled = true;
            }
            else
            {
                MessageBox.Show("password and password confirm do not match");
            }
        }

        private void SignupPasswordConfirm_TextChanged(object sender, EventArgs e)
        {
            if (SignupPassword.Text != SignupPasswordConfirm.Text)
            {
                matchLabel.Text = "password and password confirm do not match";
            }
            else
            {
                matchLabel.Text = "";
            }
        }

        //login
       
        private async void HandleLogin(object sender, EventArgs e)
        {
            LoginBtn.Enabled = false;
            try
            {
                string username = LoginUsername.Text;
                string password = LoginPassword.Text;
                string postData =
                $"{{\"username\": \"{username}\", \"password\": \"{password}\"}}";
                StringContent content = new StringContent(postData, Encoding.UTF8, "application/json");
                string apiUrl = HOST + "/auth/login";
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                    if (response.IsSuccessStatusCode)
                    {

                        string responseData = await response.Content.ReadAsStringAsync();

                        token = responseData;

                        loginPanel.Visible = false;
                        HandleShowTables();
                    }
                    else
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("API call failed. Status code: " + response.StatusCode
                        + " - Message: " + responseData
                                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LoginBtn.Enabled = true;
        }
        private async void HandleShowTables()
        {
            try
            {
                string apiUrl = HOST + "/table/get";
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                        List<Table> tables = JsonConvert.DeserializeObject<List<Table>>(responseData);
                        foreach(var table in tables)
                        {
                            Button button = new Button
                            {
                                Text = "Bàn " + table.tableName,
                                Enabled = !table.isBooked,
                                AutoSize = true,
                                Font = new Font("Times New Roman",
                                19.8F, FontStyle.Regular,
                                GraphicsUnit.Point, ((byte)(0))),
                                Tag = table
                        };
                            button.Click += HandleBookingTable;
                            fLPTable.Controls.Add(button);
                        }
                       
                        fLPTable.Visible = true;

                    }
                    else
                    {
                        MessageBox.Show("API call failed. Status code: " + response.StatusCode);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message );
            }
            
        }
        private void ProductCBSelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                Product product = cb.SelectedValue as Product;
                PriceLabel.Text = product.price.ToString() + "$";
                this.DescriptionLabel.Text = product.description;
                LoadImage(product.imageUrl);
            }
        }

        private async void HandleBookingTable(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                clickedButton.Enabled = false;
                if (clickedButton.Tag is Table table)
                {
                    try
                    {
                        string apiUrl = HOST + "/product/get";
                        using (HttpClient client = new HttpClient())
                        {
                            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                            HttpResponseMessage response = await client.GetAsync(apiUrl);
                            if (response.IsSuccessStatusCode)
                            {
                                string responseData = await response.Content.ReadAsStringAsync();
                                List<Product> products = JsonConvert.DeserializeObject<List<Product>>(responseData);
                                
                                ProductsCb.DataSource = products;
                                ProductsCb.DisplayMember = "name";
                                fLPTable.Visible = false;
                                BookingPanel.Visible = true;
                            }
                            BookingPanel.Tag = table;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                }
            }
        }

        private void AddQuantityPlaceHolder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(QuantityTxtBox.Text))
                QuantityTxtBox.Text = "Enter quantity...";
        }
        private void RemoveQuantityPlaceHolder(object sender, EventArgs e)
        {
            if (QuantityTxtBox.Text == "Enter quantity...")
                QuantityTxtBox.Text = "";
        }

       private void LoadImage(string url)
       {
            url = "https://picsum.photos/200/300";
            using (WebClient webClient = new WebClient())
            {
                byte[] imageData = webClient.DownloadData(url);
                using (var stream = new System.IO.MemoryStream(imageData))
                {
                    this.DescriptionImg.Image = Image.FromStream(stream);
                }
            }
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            Product product = ProductsCb.SelectedValue as Product;
            int quantity;
            if (int.TryParse(QuantityTxtBox.Text, out quantity) && quantity > 0)
            {
                Panel Item = new Panel
                {
                    Size = new Size(10, 10)
                };

                Label orderItem = new Label
                {
                    Text = product.name + " - Số Lượng: " + quantity.ToString()
                                        + " => " + (product.price * quantity).ToString() + "$",
                    AutoSize = false,  // Set AutoSize to false to control the size explicitly
                    MaximumSize = new Size(this.PenddingOrderList.ClientSize.Width - this.PenddingOrderList.Padding.Horizontal, 0),
                    Font = new Font("Times New Roman", 15, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                    Margin = new Padding(5, 10, 0, 0),
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(5)
                };

                // Adjust the width to fit the FlowLayoutPanel and height to fit the content
                orderItem.Size = new Size(orderItem.MaximumSize.Width, orderItem.PreferredHeight);
                orderItem.AutoSize = true;  // Enable AutoSize to adjust the height to fit the content

                PenddingOrderList.Controls.Add(orderItem);


                TotalPrice += quantity * product.price;

                OrderedItem Order = new OrderedItem(product._id, quantity);
                OrderedItems.Add(Order);
                TotalPriceLabel.Text = "Tổng hóa đơn: " + TotalPrice.ToString() + "$";
            }
            if (OrderedItems.Count != 0)
                OrderBtn.Enabled = true;
        }
       
        private async void OrderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Table table = BookingPanel.Tag as Table;
                string APIUrl = HOST + "/user/booking";
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    string json = System.Text.Json.JsonSerializer.Serialize<List<OrderedItem>>(OrderedItems);
                    string postData =
                $"{{\"tableId\": \"{table._id}\", \"orderItems\":{json}}}";
                    StringContent content = new StringContent(postData, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(APIUrl, content);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                       
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
