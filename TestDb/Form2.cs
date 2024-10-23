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
    public partial class Form2 : Form
    {
        SqlDataAdapter sqlDataAdapter;
        DataSet usersSet;
        public Form2()
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

        private void enterButton_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in usersSet.Tables[0].Rows)
            {
                if (loginBox.Text == row["login"].ToString())
                {
                    if (passwordBox.Text == row["password"].ToString())
                    {
                        string role = "";
                        switch (row["idRole"])
                        {
                            case 1:
                                {
                                    role = "Админ";
                                    break;
                                }
                            case 2:
                                {
                                    role = "Менеджер";
                                    break;
                                }
                            case 3:
                                {
                                    role = "Пользак";
                                    break;
                                }
                        }
                        MessageBox.Show($"Добро пожаловать, {role} {row["name"]}!");
                        Form1 form1 = new Form1();
                        form1.Show();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль");
                        return;
                    }
                }
            }
            MessageBox.Show("Нет пользака с таким именем");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }


}
