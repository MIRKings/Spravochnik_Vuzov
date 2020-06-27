using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Справочник_ВУЗов
{
    public partial class Главная : Form
    {
        public Главная()
        {
            InitializeComponent();
        }

        private void VUZ_Click(object sender, EventArgs e)
        {
            this.Hide();
            Вузы vuz = new Вузы();
            vuz.Show();
        }

        private void CITY_Click(object sender, EventArgs e)
        {
            this.Hide();
            Города city = new Города();
            city.Show();
        }

        private void Filials_Click(object sender, EventArgs e)
        {

        }

        private void ADMIN_Click(object sender, EventArgs e)
        {
            this.Hide();
            авторизация auth = new авторизация();
            auth.Show();
        }

        private void EXITLABLE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Главная_Load(object sender, EventArgs e)
        {

        }
    }
}
