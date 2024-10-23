using Microsoft.Data.SqlClient;
using System.Data;

namespace TestDb
{
    public partial class Form1 : Form
    {
        SqlDataAdapter sqlDataAdapter;
        DataSet usersSet;
        public Form1()
        {
            InitializeComponent();

            string connectionString = @"Data Source=pcsqlstud01;Initial Catalog=10220452;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                connectionStatusLabel.Text = "Connected";
                string selectQuery = "SELECT * FROM Products;";
                sqlDataAdapter = new SqlDataAdapter(selectQuery, connection);
                usersSet = new DataSet();
                sqlDataAdapter.Fill(usersSet);
                usersGrid.DataSource = usersSet.Tables[0];
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int productType = listBox1.SelectedIndex + 1;
            string productName = nameBox.Text;
            int productNumber = int.Parse(numberBox.Text);
            int minPrice = int.Parse(minPriceBox.Text);
            DataRow dataRow = usersSet.Tables[0].NewRow();
            dataRow["productType"] = productType;
            dataRow["productName"] = productName;
            dataRow["number"] = productNumber;
            dataRow["minPrice"] = minPrice;
            usersSet.Tables[0].Rows.Add(dataRow);
            SaveData();
            UpdateGridView();
        }
        private void SaveData()
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            sqlDataAdapter.Update(usersSet);
        }
        private void UpdateGridView()
        {
            string connectionString = @"Data Source=pcsqlstud01;Initial Catalog=10220452;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string selectQuery = "SELECT * FROM Products;";
            sqlDataAdapter = new SqlDataAdapter(selectQuery, connection);
            usersSet = new DataSet();
            sqlDataAdapter.Fill(usersSet);
            usersGrid.DataSource = usersSet.Tables[0];
        }
    }
}
