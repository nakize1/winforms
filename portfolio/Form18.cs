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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        MainForm main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

        private void back18cj_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form1());
            else { var f1 = new Form1(); f1.Show(); this.Hide(); }
        }

        private void info18cj_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form17());
        }

        private void skills18cj_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form18());
        }

        private void educ18cj_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form19());
        }

        private void hobbies18cj_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form20());
        }

        private void msg18cj_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form21());
        }
    }
}
