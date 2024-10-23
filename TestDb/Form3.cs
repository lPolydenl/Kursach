using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDb
{
    public partial class Form3 : Form
    {
        SqlDataAdapter sqlDataAdapter;
        DataSet usersSet;
        public Form3()
        {
            InitializeComponent();

            string connectionString = @"Data Source=pcsqlstud01;Initial Catalog=10220452;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                string selectQuery = "SELECT * FROM TestTable;";
                sqlDataAdapter = new SqlDataAdapter(selectQuery, connection);
                usersSet = new DataSet();
                sqlDataAdapter.Fill(usersSet);
            }
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (loginBox.Text.Length > 0
                && passwordBox.Text.Length > 0
                && secondNameBox.Text.Length > 0
                && nameBox.Text.Length > 0
                && mailBox.Text.Length > 0)
            {
                foreach (DataRow row in usersSet.Tables[0].Rows)
                {
                    if(loginBox.Text == row["login"].ToString())
                    {
                        MessageBox.Show("Пользак с таким именем уже существует!");
                        return;
                    }
                }
                    DataRow dataRow = usersSet.Tables[0].NewRow();
                dataRow["login"] = loginBox.Text;
                dataRow["password"] = passwordBox.Text;
                dataRow["secondName"] = secondNameBox.Text;
                dataRow["name"] = nameBox.Text;
                dataRow["fatherName"] = fatherNameBox.Text;
                dataRow["phoneNumber"] = phoneNumberBox.Text;
                dataRow["mail"] = mailBox.Text;
                dataRow["idRole"] = 3;
                usersSet.Tables[0].Rows.Add(dataRow);
                SaveData();
                MessageBox.Show("Вы успешно зарегистрированы!");
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Заполните обязательные поля!");
            }
        }

        private void SaveData()
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            sqlDataAdapter.Update(usersSet);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private bool PasswordCheck(string password)
        {
            if(password.Length <= 8)
            {
                return false;
            }
            bool hasNumber;
            bool hasCapital;
            bool hasSmall;
            foreach (char symbol in password)
            {
                
            }
            return false;
        }
    }
}
