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



namespace resaurant_management_windows
{
    public partial class MainForm : Form
    {
        private string token;
        private const string HOST = //"http://localhost:8000";
            "https://rst-mgt-service.onrender.com";
        
        private List<OrderedItem> PenddingOrderedItems = new List<OrderedItem>();
        private List<OrderedItem> OrderedItems = new List<OrderedItem>();
        private bool isFormClosingHandled = false;
        public MainForm()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(HandleClosingForm);
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
                        fLPTable.Controls.Clear();
                        foreach(var table in tables)
                        {
                            Button button = new Button
                            {
                                Text = "Bàn " + table.tableName + " - "
                                + table.numberOfSeats.ToString() + " Ghế",
                                Enabled = !table.isBooked,
                                AutoSize = true,
                                Font = new Font("Times New Roman",
                                19.8F, FontStyle.Regular,
                                GraphicsUnit.Point, ((byte)(0))),
                                Margin = new Padding(5),
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
                DescriptionLabel.Text = product.description;
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
                        using (HttpClient client = new HttpClient())
                        {
                            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                            client.DefaultRequestHeaders.Add("id", table._id);
                            HttpResponseMessage response =
                                await client.GetAsync(HOST + "/table/choose-table");
                            if (response.IsSuccessStatusCode)
                            {
                    // do nothing here it only to verify that the table is exactly avalible
                            }
                            else
                            {
                                string ResponseMessage = await response.Content.ReadAsStringAsync();
                                MessageBox.Show(response.StatusCode.ToString() + " - " + ResponseMessage);
                                HandleShowTables();
                                return;
                            }
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        HandleShowTables();
                        return;
                    }
            // after verify that the table is avalible. get product from server and render
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
            using (WebClient webClient = new WebClient())
            {
                byte[] imageData = webClient.DownloadData(url);
                using (var stream = new System.IO.MemoryStream(imageData))
                {
                    Image image = Image.FromStream(stream);

                    // Set the PictureBox's SizeMode to Zoom to ensure the image scales to fit
                    this.DescriptionImg.SizeMode = PictureBoxSizeMode.Zoom;
                    this.DescriptionImg.Image = image;
                }
            }
       }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            Product product = ProductsCb.SelectedValue as Product;
            int quantity;
            if (int.TryParse(QuantityTxtBox.Text, out quantity) && quantity > 0)
            {
                QuantityTxtBox.Text = "Enter quantity...";
                Label orderItem = new Label
                {
                    Text = product.name + " - Số Lượng: " + quantity.ToString()
                                        + " => " + (product.price * quantity).ToString() + "$",
                    AutoSize = false,  // Set AutoSize to false to control the size explicitly
                    MaximumSize = 
                    new Size(PenddingOrderList.ClientSize.Width - PenddingOrderList.Padding.Horizontal, 0),
                    Font = new Font("Times New Roman", 15, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                    Margin = new Padding(7),
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(5),
                };


                FlowLayoutPanel ItemWapper = new FlowLayoutPanel
                {
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    FlowDirection = FlowDirection.LeftToRight,
                    Width = PenddingOrderList.Width,
                    BorderStyle = BorderStyle.FixedSingle,
                };


                Button RemoveItemBtn = new Button
                {
                    Text = "Xóa",
                    BackColor = Color.Red,
                    Font = new Font("Times New Roman", 15, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                    Margin = new Padding(3),
                    AutoSize = true,
                    Tag = ItemWapper
                };
                RemoveItemBtn.Click += RemoveItemBtn_Click;
                // Adjust the width to fit the FlowLayoutPanel and height to fit the content
                orderItem.Size = new Size(orderItem.MaximumSize.Width, orderItem.PreferredHeight);
                orderItem.AutoSize = true;  // Enable AutoSize to adjust the height to fit the content

                ItemWapper.Controls.Add(orderItem);
                ItemWapper.Controls.Add(RemoveItemBtn);
                PenddingOrderList.Controls.Add(ItemWapper);


                float TotalPrice = 0.0f;
                
                OrderedItem Order =
                    new OrderedItem(product._id, product.name, quantity, product.price);

                ItemWapper.Tag = Order;

                PenddingOrderedItems.Add(Order);
                
                foreach (OrderedItem item in PenddingOrderedItems)
                {
                    TotalPrice += item.price * item.quantity;
                }
                
                TotalPriceLabel.Text = "Tổng hóa đơn dự kiến: " + TotalPrice.ToString() + "$";
            }
            if (PenddingOrderedItems.Count != 0)
                OrderBtn.Enabled = true;
        }

        private void RemoveItemBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Control itemWapper = button.Tag as Control;
            OrderedItem Order = itemWapper.Tag as OrderedItem;
            PenddingOrderedItems.Remove(Order);
            PenddingOrderList.Controls.Remove(itemWapper);

            float TotalPrice = 0.0f;
            foreach (OrderedItem item in PenddingOrderedItems)
            {
                TotalPrice += item.price * item.quantity;
            }
            TotalPriceLabel.Text = "Tổng hóa đơn dự kiến: " + TotalPrice.ToString() + "$";
            if (PenddingOrderedItems.Count == 0)
                OrderBtn.Enabled = false;
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
                    string json = System.Text.Json.JsonSerializer.Serialize<List<OrderedItem>>(PenddingOrderedItems);
                    string postData =
                $"{{\"tableId\": \"{table._id}\", \"orderItems\":{json}}}";
                    StringContent content = new StringContent(postData, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(APIUrl, content);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Hệ thống đã ghi nhận đơn đặt hàng của bạn.");
                        PenddingOrderedItems.Clear();
                        PenddingOrderList.Controls.Clear();
                        TotalPriceLabel.Text = "Tổng hóa đơn dự kiến: 0$";
                        OnlBillPanel.Visible = true;
                        BookingPanel.Visible = false;
                        HandleOnlBill();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private async void HandleOnlBill()
        {
            try
            {
                Table table = BookingPanel.Tag as Table;
                string APIUrl = HOST + "/user/view-ordered-items";
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    client.DefaultRequestHeaders.Add("id", table._id);
                    
                    HttpResponseMessage response = await client.GetAsync(APIUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                        OrderedItems = JsonConvert.DeserializeObject<List<OrderedItem>>(responseData);
                        if (OrderedItems.Count() > 0) 
                            ToOnlBillPanelBtn.Enabled = true;
                        float TotalPrice = 0.0f;
                        OrderedItemFLP.Controls.Clear();
                        foreach (OrderedItem item in OrderedItems) 
                        {
                            Label orderItem = new Label
                            {
                                Text = item.productName + " - Số Lượng: " + item.quantity.ToString()
                                        + " => " + (item.price * item.quantity).ToString() + "$",
                                AutoSize = false,  // Set AutoSize to false to control the size explicitly
                                MaximumSize = new Size(OrderedItemFLP.ClientSize.Width - OrderedItemFLP.Padding.Horizontal, 0),
                                Font = new Font("Times New Roman", 15, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                                Margin = new Padding(7),
                                BorderStyle = BorderStyle.FixedSingle,
                                Padding = new Padding(5),
                            };
                            orderItem.Size = new Size(orderItem.MaximumSize.Width, orderItem.PreferredHeight);
                            orderItem.AutoSize = true;  // Enable AutoSize to adjust the height to fit the content
                            
                            OrderedItemFLP.Controls.Add(orderItem);
                            TotalPrice += item.price * item.quantity;
                        }
                        TotalPriceOrderedLabel.Text = "Tổng hóa đơn: " + TotalPrice.ToString() + "$";
                    }
                    else
                    {
                        MessageBox.Show(response.StatusCode.ToString());
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BackToBookingBtn_Click(object sender, EventArgs e)
        {
            OnlBillPanel.Visible = false;
            BookingPanel.Visible = true;
        }

        private void ToOnlBillPanelBtn_Click(object sender, EventArgs e)
        {
            OnlBillPanel.Visible = true;
            BookingPanel.Visible = false;
        }

        private async void PayBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Xác nhận thanh toán",
                "Thanh toán",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                Table table = BookingPanel.Tag as Table;
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    client.DefaultRequestHeaders.Add("id", table._id);
                    HttpResponseMessage response =
                        await client.GetAsync(HOST + "/user/payment");
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox
        .Show("Thanh toán thành công. Cảm ơn quý khách đã sử dụng dịch vụ! Hẹn gặp lại quý khách lần sau",
                        "ALL WITH LOVE");
                        OnlBillPanel.Visible = false;
                        ToOnlBillPanelBtn.Enabled = false;
                        PenddingOrderedItems.Clear();
                        OrderedItems.Clear();
                        BookingPanel.Tag = null;
                        HandleShowTables();
                    }
                    else
                    {
                        string ResponseMessage = await response.Content.ReadAsStringAsync();
                        MessageBox.Show(response.StatusCode.ToString() + " - " + ResponseMessage);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private async void HandleClosingForm(object sender, FormClosingEventArgs e)
        {
            if (isFormClosingHandled)
            {
                // Prevent re-entry if the form is already closing
                return;
            }

            if (BookingPanel.Tag != null)
            {
                Table table = BookingPanel.Tag as Table;

                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                        client.DefaultRequestHeaders.Add("id", table._id);

                        // Prevent form from closing immediately
                        e.Cancel = true;

                        HttpResponseMessage response = await client.GetAsync(HOST + "/user/reset-table");
                        response.EnsureSuccessStatusCode();

                        // Set the flag to indicate the request completed successfully
                        isFormClosingHandled = true;

                        // Allow form to close after request completes
                        e.Cancel = false;
                        this.Close(); // This should not re-trigger the FormClosing event due to the flag
                    }
                }
                catch (HttpRequestException)
                {
                    isFormClosingHandled = true;
                    e.Cancel = false; // Allow form to close even if there is an error
                    this.Close();
                }
                catch (Exception)
                {
                    isFormClosingHandled = true;
                    e.Cancel = false; // Allow form to close even if there is an error
                }
            }
        }

    }
}
