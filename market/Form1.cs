using System;
using System.Data;
using System.Drawing;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
namespace market
{
    public partial class Form1 : Form
    {
        private readonly Sql sql = new Sql();
        private Dictionary<string, int> productQuantities = new Dictionary<string, int>();
        private Dictionary<string, double> productPrices = new Dictionary<string, double>();
        private int otherProductCounter = 1;
        private int selectedQuantity = 1;

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void VeriYukle(int categoryId)
        {
            try
            {
                DataTable productsTable = sql.GetProductsByCategory(categoryId);
                tableLayoutPanel1.Controls.Clear();

                Font boldFont = new Font("Segoe UI", 10, FontStyle.Bold);

                foreach (DataRow row in productsTable.Rows)
                {
                    string productName = row["Product Name"].ToString();
                    double unitPrice = sql.GetProductPrice(productName);

                    Button button = new Button
                    {
                        Text = $"{productName}\nFiyat: {unitPrice:C2}",
                        Tag = row["ProductID"],
                        Width = 306,
                        Height = 186,
                        Font = boldFont,
                        BackColor = Color.White,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    button.Click += ProductButton_Click;
                    tableLayoutPanel1.Controls.Add(button);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluþtu: " + ex.Message);
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            flowLayoutCarpan.Visible = false;
            tableLayoutPanel1.Visible = false;
            flowLayoutCategories.Visible = true;
            string colorCode = "#D0F0C0";
            this.BackColor = ColorTranslator.FromHtml(colorCode);

            LoadCategories();
        }

        private void LoadCategories()
        {
            try
            {
                DataTable categoriesTable = sql.GetCategories();
                flowLayoutCategories.Controls.Clear();

                foreach (DataRow row in categoriesTable.Rows)
                {
                    Button categoryButton = new Button
                    {
                        Text = row["Category Name"].ToString(),
                        Tag = row["ID"],
                        Width = 105,
                        Height = 105,
                        BackColor = Color.LightBlue
                    };
                    categoryButton.Click += CategoryButton_Click;
                    flowLayoutCategories.Controls.Add(categoryButton);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluþtu: " + ex.Message);
            }
        }

        private void ResetQuantity()
        {
            selectedQuantity = 1;
        }

        private void UpdateTotalPrice()
        {
            double totalPrice = 0.0;

            foreach (var product in productQuantities)
            {
                string productName = product.Key;
                int quantity = product.Value;
                double unitPrice = productPrices[productName];

                totalPrice += unitPrice * quantity;
            }

            lblToplamFiyat.Text = $"Toplam Fiyat: {totalPrice:C2}";
        }

        private void UpdateProductList(string productName, double unitPrice)
        {
            if (productQuantities.ContainsKey(productName))
            {
                productQuantities[productName] += selectedQuantity;
            }
            else
            {
                productQuantities[productName] = selectedQuantity;
            }
            RefreshListBox();
            UpdateTotalPrice();
        }

        private void RefreshListBox()
        {
            listBox1.Items.Clear();
            foreach (var product in productQuantities)
            {
                string productName = product.Key;
                int quantity = product.Value;
                double unitPrice = productPrices[productName];

                string itemText;
                if (quantity == 1)
                {
                    itemText = $"{productName} - {unitPrice * quantity:C2}";
                }
                else
                {
                    itemText = $"{productName} x{quantity} - {unitPrice * quantity:C2}";
                }
                listBox1.Items.Add(itemText);
            }
        }
        private void RemoveProduct(string productName)
        {
            string productNameToRemove = productName.Trim();
            if (productQuantities.ContainsKey(productNameToRemove))
            {
                productQuantities.Remove(productNameToRemove);
                productPrices.Remove(productNameToRemove);
                RefreshListBox();
                UpdateTotalPrice();
            }
            else
            {
                MessageBox.Show("Ürün bulunamadý.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = false;
            flowLayoutCarpan.Visible = false;
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                string productName;

                if (selectedItem.Contains(" x"))
                {
                    productName = selectedItem.Split(new[] { " x" }, StringSplitOptions.None)[0].Trim();
                }
                else if (selectedItem.Contains(" -"))
                {
                    productName = selectedItem.Split(new[] { " -" }, StringSplitOptions.None)[0].Trim();
                }
                else
                {
                    productName = selectedItem.Trim();
                }

                RemoveProduct(productName);
            }
            else
            {
                MessageBox.Show("Lütfen kaldýrmak için bir öðe seçin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string productName = clickedButton.Text.Split('\n')[0].Trim();
                try
                {
                    double unitPrice = sql.GetProductPrice(productName);
                    if (unitPrice > 0)
                    {
                        if (!productPrices.ContainsKey(productName))
                        {
                            productPrices.Add(productName, unitPrice);
                        }
                        UpdateProductList(productName, unitPrice);
                        ResetQuantity();

                        var existingItemIndex = listBox1.Items.Cast<string>().ToList().FindIndex(item => item.StartsWith(productName));

                        if (existingItemIndex >= 0)
                        {
                            listBox1.Items[existingItemIndex] = $"{productName} x{productQuantities[productName]} - {unitPrice * productQuantities[productName]:C2}";
                        }
                        else
                        {
                            string itemText = $"{productName} x{productQuantities[productName]} - {unitPrice * productQuantities[productName]:C2}";
                            listBox1.Items.Add(itemText);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Geçersiz ürün fiyatý alýndý: {productName}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluþtu: " + ex.Message);
                }
            }
        }

        private void btntoplam_Click(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            MessageBox.Show($"Sipariþiniz Tamamlanmýþtýr. {lblToplamFiyat.Text}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listBox1.Items.Clear();
            productQuantities.Clear();
            UpdateTotalPrice();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            productQuantities.Clear();
            UpdateTotalPrice();

        }

        private void btnAltaAl_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn2Carp_Click(object sender, EventArgs e)
        {
            if (selectedQuantity == 1)
            {
                selectedQuantity = 0;
                selectedQuantity += 2;
            }

            else
            {
                selectedQuantity += 2;
            }
        }

        private void btn3Carp_Click(object sender, EventArgs e)
        {
            if (selectedQuantity == 1)
            {
                selectedQuantity = 0;
                selectedQuantity += 3;
            }

            else
            {
                selectedQuantity += 3;
            }
        }

        private void btn5Carp_Click(object sender, EventArgs e)
        {
            if (selectedQuantity == 1)
            {
                selectedQuantity = 0;
                selectedQuantity += 5;
            }

            else
            {
                selectedQuantity += 5;
            }
        }

        private void btn8Carp_Click(object sender, EventArgs e)
        {
            if (selectedQuantity == 1)
            {
                selectedQuantity = 0;
                selectedQuantity += 8;
            }

            else
            {
                selectedQuantity += 8;
            }
        }

        private void btn10Carp_Click(object sender, EventArgs e)
        {
            if (selectedQuantity == 1)
            {
                selectedQuantity = 0;
                selectedQuantity += 10;
            }

            else
            {
                selectedQuantity += 10;
            }
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                int categoryId = (int)clickedButton.Tag;
                VeriYukle(categoryId);
                flowLayoutCategories.Visible = true;
                tableLayoutPanel1.Visible = true;
                flowLayoutCarpan.Visible = true;
            }
            else
            {
                MessageBox.Show("Kategori butonu geçersiz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            string fiyatMetni = txtFiyat.Text;
            double fiyat;
            bool geçerliFiyat = double.TryParse(fiyatMetni, out fiyat);

            if (geçerliFiyat && fiyat > 0)
            {
                string ürünAdý = "Diðer Ürün " + otherProductCounter;
                otherProductCounter++;

                productQuantities.Add(ürünAdý, selectedQuantity);

                productPrices[ürünAdý] = fiyat;
                RefreshListBox();
                UpdateTotalPrice();
                txtFiyat.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Geçersiz bir deðer girdiniz. Lütfen pozitif bir fiyat girin.");
            }
        }
    }
}