using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Справочник_ВУЗов.Controll;


namespace Справочник_ВУЗов
{
    public partial class Города : Form
    {
        public static string sqlConnection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=B:\Project c#\Справочник ВУЗов\Справочник ВУЗов\bin\Debug\Database2.accdb";
        private OleDbConnection Connection = new OleDbConnection(sqlConnection);
        Query controller;

        public Города()
        {
            InitializeComponent();
         controller = new Query(ConnectionString.ConnStr);

        }

        private void Города_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2DataSet.Города". При необходимости она может быть перемещена или удалена.
            this.городаTableAdapter.Fill(this.database2DataSet.Города);

            // dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
           

        }       

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
           /* string del = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string cmdSTR = "DELETE FROM Города WHERE 'ID_города'= '" + del + "';";
            OleDbCommand command = new OleDbCommand(cmdSTR, Connection);
            command.ExecuteNonQuery();
            Connection.Close();*/
          controller.Delete(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID_города"].Value.ToString()));


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
