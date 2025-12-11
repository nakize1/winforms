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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        MainForm main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

        private void back9sua_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form1());
            else { var f1 = new Form1(); f1.Show(); this.Hide(); }
        }

        private void info9sua_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form7());
        }

        private void skills9sua_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form8());
        }

        private void educ9sua_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form9());
        }

        private void hobbies9sua_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form10());
        }

        private void msg9sua_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form11());
        }
    }
}
