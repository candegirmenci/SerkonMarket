using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace market
{
    public class Sql
    {
        private readonly string connectionString = "Data Source=FLAWI;Initial Catalog=SERKONMARKET;Integrated Security=True;Trust Server Certificate=True";

        public DataTable GetProductsByCategory(int categoryId)
        {
            string query = "SELECT t2.ID AS ProductID, t2.[Product Name], t2.Quantity, t1.[Category Name] " +
                           "FROM Category t1 " +
                           "INNER JOIN Products t2 ON t2.CategoryID = t1.ID " +
                           "WHERE t2.CategoryID = @CategoryID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CategoryID", categoryId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    conn.Open();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Kategoriye ait ürün bulunamadı.");
                    }

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürünler alınırken bir hata oluştu: " + ex.ToString());
                return null;
            }
        }



        public double GetProductPrice(string productName)
        {
            double price = 0.0;
            string query = "SELECT [Unit Price] FROM Products WHERE [Product Name] = @ProductName";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        price = Convert.ToDouble(result);
                    }
                    else
                    {
                        MessageBox.Show($"Ürün fiyatı bulunamadı: {productName}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün fiyatı alınırken bir hata oluştu: " + ex.Message);
            }

            return price;
        }

        public DataTable GetCategories()
        {
            string query = "SELECT ID, [Category Name] FROM Category";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable categoriesTable = new DataTable();
                    adapter.Fill(categoriesTable);
                    return categoriesTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategoriler alınırken bir hata oluştu: " + ex.Message);
                return null;
            }
        }

        public DataTable GetProducts()
        {
            string query = "SELECT ID AS ProductID, [Product Name], Quantity, [Unit Price] FROM Products";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürünler alınırken bir hata oluştu: " + ex.Message);
                return null;
            }
        }
        public void AddCategory(string categoryName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("AddCategory", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CategoryName", categoryName);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Kategori başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        public void InsertProductByCategoryName(string categoryName, string productName, int quantity, decimal unitPrice)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("InsertProductByCategoryName", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Ürün başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        public void DeleteProductByID(int productID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("DeleteProductByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ProductID", productID);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Ürün başarıyla silindi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        public void DeleteCategory(int categoryId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("DeleteCategory", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CategoryID", categoryId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Kategori başarıyla silindi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        public void IncreaseProductQuantity(int productID, int additionalQuantity)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("IncreaseProductQuantity", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@productID", productID);
                        cmd.Parameters.AddWithValue("@additionalQuantity", additionalQuantity);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Ürün miktarı başarıyla artırıldı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        public void UpdateProductQuantity(int productID, int soldQuantity)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateProductQuantity", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@productID", productID);
                        cmd.Parameters.AddWithValue("@soldQuantity", soldQuantity);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Ürün miktarı başarıyla güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
    }
}
