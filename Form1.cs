using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace resaurant_management_windows
{
    public partial class MainForm : Form
    {
        private string token;
        private const string HOST = //"http://localhost:3000";
            "https://rst-mgt-service.onrender.com";
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
                        MessageBox.Show("API call failed. Status code: " + response.StatusCode);
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
                PriceTxtBox.Text = product.price.ToString() + "$";
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
                                BookingProduct.Visible = true;
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
    }
}
