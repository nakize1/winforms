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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        MainForm main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

        private void back21_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form1());
            else { var f1 = new Form1(); f1.Show(); this.Hide(); }
        }

        private void info21_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form17());
        }

        private void skills21_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form18());
        }

        private void educ21_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form19());
        }

        private void hobbies21_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form20());
        }

        private void msg21_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form21());
        }
    }
}
