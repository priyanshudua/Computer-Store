using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerStore
{
    public partial class MainForm : Form
    {
        private string databaseFileName = "ComputerStore.accdb";
        private string connectionString;

        private OleDbConnection connection;
        private OleDbDataAdapter dataAdapter;
        private DataTable dataTable;

        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;

            string appFolderPath = Path.GetDirectoryName(Application.ExecutablePath);
            string databaseFilePath = Path.Combine(appFolderPath, databaseFileName);

            connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databaseFilePath};";

            connection = new OleDbConnection(connectionString);
            dataTable = new DataTable();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                connection.Open();
                string query = "SELECT ComputerID, ComputerType, Model, QuantityOnStock, Price FROM Products";
                dataAdapter = new OleDbDataAdapter(query, connection);
                dataTable.Clear();
                dataAdapter.Fill(dataTable);
                dataGridViewProducts.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                int selectedProductID = Convert.ToInt32(dataGridViewProducts.SelectedRows[0].Cells["ComputerID"].Value);
                ProductInfoForm productInfoForm = new ProductInfoForm(selectedProductID);
                productInfoForm.ShowDialog();
            }
        }
    }
}
