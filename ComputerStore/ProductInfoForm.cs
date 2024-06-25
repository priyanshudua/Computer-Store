using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ComputerStore
{
    public partial class ProductInfoForm : Form
    {
        private int selectedProductID;
        private string connectionString;
        private OleDbConnection connection;
        private DataTable dataTable;

        public ProductInfoForm(int productID)
        {
            InitializeComponent();
            this.Load += ProductInfoForm_Load;

            selectedProductID = productID;

            string appFolderPath = Path.GetDirectoryName(Application.ExecutablePath);
            string databaseFilePath = Path.Combine(appFolderPath, "ComputerStore.accdb");
            connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databaseFilePath};";

            connection = new OleDbConnection(connectionString);
            dataTable = new DataTable();

            this.Load += ProductInfoForm_Load;
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            LoadProductInfo();
        }

        private void LoadProductInfo()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM Products WHERE ComputerID = " + selectedProductID;
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ComputerType.Text = reader["ComputerType"].ToString();
                    Model.Text = reader["Model"].ToString();
                    QuantityOnStock.Text = reader["QuantityOnStock"].ToString();
                    Price.Text = reader["Price"].ToString();
                    QuantitySold.Text = reader["QuantitySold"].ToString();
                    CPUSpeed.Text = reader["CPUSpeed"].ToString();
                    RAMCapacity.Text = reader["RAMCapacity"].ToString();
                    HDCapacity.Text = reader["HDCapacity"].ToString();

                    // Load the picture if available
                    /* if (!(reader["Image"] is DBNull))
                    {
                        byte[] imageData = (byte[])reader["Image"];
                        MemoryStream ms = new MemoryStream(imageData);
                        pictureBoxProduct.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        pictureBoxProduct.Image = null;
                    } */
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product info: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            CustomerInfoForm customerInfoForm = new CustomerInfoForm(selectedProductID);
            customerInfoForm.ShowDialog();
        }
    }
}
