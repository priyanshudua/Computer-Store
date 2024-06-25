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
    public partial class CustomerInfoForm : Form
    {
        private int selectedProductID;
        private string connectionString;
        private OleDbConnection connection;

        public CustomerInfoForm(int productID)
        {
            InitializeComponent();
            selectedProductID = productID;

            string appFolderPath = Path.GetDirectoryName(Application.ExecutablePath);
            string databaseFilePath = Path.Combine(appFolderPath, "ComputerStore.accdb");
            connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databaseFilePath};";

            connection = new OleDbConnection(connectionString);
        }

        private void btnProcessOrder_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Get price and quantity sold from Products table
                string query = "SELECT Price, QuantitySold FROM Products WHERE ComputerID = " + selectedProductID;
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();
                decimal price = Convert.ToDecimal(reader["Price"]);
                int quantitySold = Convert.ToInt32(reader["QuantitySold"]);
                reader.Close();

                string firstName = FirstName.Text;
                string lastName = LastName.Text;
                string telephoneNumber = TelephoneNumber.Text;
                string address = Address.Text;
                string creditCardData = CreditCardData.Text;

                // Insert customer information into Customers table
                string insertCustomerQuery = $"INSERT INTO Customers (FirstName, LastName, TelephoneNumber, Address, CreditCardData) " +
                    $"VALUES ('{firstName}', '{lastName}', '{telephoneNumber}', '{address}', '{creditCardData}')";
                OleDbCommand insertCustomerCommand = new OleDbCommand(insertCustomerQuery, connection);
                insertCustomerCommand.ExecuteNonQuery();

                // Update Products table with quantity sold and quantity on stock
                string updateProductsQuery = $"UPDATE Products SET QuantitySold = QuantitySold + {quantitySold}, QuantityOnStock = QuantityOnStock - {quantitySold} " +
                    $"WHERE ComputerID = {selectedProductID}";
                OleDbCommand updateProductsCommand = new OleDbCommand(updateProductsQuery, connection);
                updateProductsCommand.ExecuteNonQuery();

                // Insert order information into Orders table
                decimal totalCost = quantitySold * price;
                string currentTime = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss");
                OleDbCommand getMaxCustomerIdCommand = new OleDbCommand("SELECT MAX(CustomerID) FROM Customers", connection);
                int customerId = (int)getMaxCustomerIdCommand.ExecuteScalar();

                string insertOrderQuery = $"INSERT INTO Orders (CustomerID, ComputerID, OrderDate, TotalCost) " +
                    $"VALUES ({customerId}, {selectedProductID}, #{currentTime}#, {totalCost})";
                OleDbCommand insertOrderCommand = new OleDbCommand(insertOrderQuery, connection);
                insertOrderCommand.ExecuteNonQuery();

                MessageBox.Show("Order processed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
