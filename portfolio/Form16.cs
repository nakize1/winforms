using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace portfolio
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        MainForm main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

        private void back16mh_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form1());
            else { var f1 = new Form1(); f1.Show(); this.Hide(); }
        }

        private void info16mh_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form12());
        }

        private void skills16mh_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form13());
        }

        private void educ16mh_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form14());
        }

        private void hobbies16mh_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form15());
        }

        private void msg16mh_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form16());
        }
    }
}
