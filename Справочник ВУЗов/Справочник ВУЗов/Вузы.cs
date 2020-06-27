using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Odbc.OdbcException;

namespace Справочник_ВУЗов
{
    public partial class Вузы : Form
    {
        //строка подключения к БД
        public static string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=B:\Project c#\Справочник ВУЗов\Справочник ВУЗов\Database2.accdb";
        private OleDbConnection Con = new OleDbConnection(connection);

        public Вузы()
        {
            InitializeComponent();    
        }

        private void Вузы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2DataSet.ВУЗы". При необходимости она может быть перемещена или удалена.
            this.вУЗыTableAdapter.Fill(this.database2DataSet.ВУЗы);
            //автоподгон ширины столбцов
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;           
         
        }

        //Возврат на главную форму без свертывания текущей формы
        private void наГлавнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Главная main = new Главная();
            main.Show();
        }

        //Кнопка выхода
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        //кнопка добавления
        private void SAVEBUT_Click(object sender, EventArgs e)
        {
            
        }

        //Кнопка обновления
        private void UPBUT_Click(object sender, EventArgs e)
        {
            this.вУЗыTableAdapter.Fill(this.database2DataSet.ВУЗы);
        }

        //кнопка удаления
        private void DELBUT_Click(object sender, EventArgs e)
        {
            Con.Open();
            string del = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string cmdSTR = "DELETE FROM Города WHERE ID_города = '" + del + "';";
            OleDbCommand command = new OleDbCommand(cmdSTR, Con);
            command.ExecuteNonQuery();
            Con.Close();  
            this.вУЗыTableAdapter.Fill(this.database2DataSet.ВУЗы);
        }
        //Кнопка справочников

        private void SPRBUT_Click(object sender, EventArgs e)
        {
            Справочники spr = new Справочники();
            spr.Show();
        }
    }
}
