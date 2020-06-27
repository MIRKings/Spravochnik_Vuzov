using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Odbc;

namespace Справочник_ВУЗов
{
    public partial class авторизация : Form
    {
        public static string con = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gusei\Documents\Database2.accdb";
        private OleDbConnection connection = new OleDbConnection(con);
        public авторизация()
        {
            InitializeComponent();
            connection.Open();
        }

        private void авторизация_Load(object sender, EventArgs e)
        {

        }

        private void SINGIN_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                string sdastr = "SELECT Логин, Пароль FROM Пользователи WHERE (Логин = '" + textBox1.Text + "') AND (Пароль = '" + textBox2.Text + "');";

                OleDbCommand cmd = new OleDbCommand(sdastr, connection);
                cmd.ExecuteNonQuery();

                if (cmd.ExecuteScalar() != null)
                {
                    OleDbDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    this.Hide();
                    АДМИН admin = new АДМИН();
                    admin.Show();


                }
                else
                {

                    MessageBox.Show("Все данные должны быть заполнены!", "Ошибка заполнения", MessageBoxButtons.OK);
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
        }
        


        private void BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Главная main = new Главная();
            main.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Если не стоит галочка то включаем защиту пароля
            if (checkBox1.Checked == false)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            // Если стоит галочка , выключаем защиту пароля 
            else 
                textBox2.UseSystemPasswordChar = false;

        }
    }
}
