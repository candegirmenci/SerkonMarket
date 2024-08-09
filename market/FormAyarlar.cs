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
    public partial class FormAyarlar : Form
    {

        Sql sql = new Sql();

        public FormAyarlar()
        {
            InitializeComponent();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategory.Text;

            if (!string.IsNullOrEmpty(categoryName))
            {
                sql.AddCategory(categoryName);
                LoadCategories();
            }
            else
            {
                MessageBox.Show("Kategori adı boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAyarlar_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            DataTable categoriesTable = sql.GetCategories();

            if (categoriesTable != null)
            {
                dataGridCategories.DataSource = categoriesTable;
                dataGridCategories.Columns["ID"].Visible = true;
                dataGridCategories.Columns["Category Name"].HeaderText = "Kategori Adı";
            }
            else
            {
                MessageBox.Show("Kategoriler yüklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dataGridCategories.SelectedRows.Count > 0)
            {
                int categoryId = (int)dataGridCategories.SelectedRows[0].Cells["ID"].Value;
                string categoryName = dataGridCategories.SelectedRows[0].Cells["Category Name"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"'{categoryName}' kategorisini silmek istediğinizden emin misiniz?",
                    "Kategoriyi Sil",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    sql.DeleteCategory(categoryId);
                    LoadCategories();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir kategoriyi seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
