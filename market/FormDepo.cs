using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    public partial class FormDepo : Form
    {
        private Sql sql = new Sql();
        public FormDepo()
        {
            InitializeComponent();
        }

        public void LoadProductsToDataGridView()
        {
            DataTable productsTable = sql.GetProducts();
            if (productsTable != null)
            {
                dataGridView1.DataSource = productsTable;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
                    row.Tag = productId;
                }
                dataGridView1.Columns["ProductID"].Visible = false;
            }
            else
            {
                MessageBox.Show("Ürünler yüklenirken bir sorun oluştu.");
            }
        }

        private void LoadCategoriesIntoComboBox()
        {
            DataTable categoriesTable = sql.GetCategories();
            if (categoriesTable != null)
            {
                cmbCategoryName.Items.Clear();

                foreach (DataRow row in categoriesTable.Rows)
                {
                    cmbCategoryName.Items.Add(row["Category Name"].ToString());
                }
            }
        }

        private void FormDepo_Load(object sender, EventArgs e)
        {
            LoadProductsToDataGridView();
            LoadCategoriesIntoComboBox();
            this.Load += new System.EventHandler(this.FormDepo_Load);

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string categoryName = cmbCategoryName.SelectedItem.ToString();
            string productName = txtProductName.Text;
            int quantity = int.Parse(txtAdet.Text);
            decimal unitPrice = decimal.Parse(txtPrice.Text);

            sql.InsertProductByCategoryName(categoryName, productName, quantity, unitPrice);
            txtProductName.Clear();
            txtAdet.Clear();
            txtPrice.Clear();
            LoadProductsToDataGridView();
        }

        private void btnSeciliUrunSil_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int productId = (int)row.Tag;
                    sql.DeleteProductByID(productId);
                    LoadProductsToDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Silinecek ürün seçilmedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
