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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        MainForm main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

        private void back17cj_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form1());
            else { var f1 = new Form1(); f1.Show(); this.Hide(); }
        }

        private void info17cj_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form17());
        }

        private void skills17cj_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form18());
        }

        private void educ17cj_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form19());
        }

        private void hobbies17cj_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form20());
        }

        private void msg17cj_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form21());
        }
    }
}
