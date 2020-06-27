using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Справочник_ВУЗов.Properties;

namespace Справочник_ВУЗов
{
    public partial class Справочники : Form
    {
        private bool tim;
        public Справочники()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tim)
            {
                SPRAV.Image = Resources.Collapse_Arrow_20px;
                panel1.Height += 10;
                if (panel1.Size == panel1.MaximumSize)
                {
                    timer1.Stop();
                    tim = false;
                }
            }
            else
            {
                SPRAV.Image = Resources.Expand_Arrow_20px;

                panel1.Height -= 10;
                if (panel1.Size == panel1.MinimumSize)
                {
                    timer1.Stop();
                    tim = true;
                }
            }
        }

        private void SPRAV_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
