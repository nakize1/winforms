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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        MainForm main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

        private void back4bon_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.SwitchToForm(new Form1());
            }
            else
            {
                var f1 = new Form1();
                f1.Show();
                this.Hide();
            }
        }

        private void info4bon_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.SwitchToForm(new Form2());
            }
        }

        private void skills4bon_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.SwitchToForm(new Form4());
            }
        }

        private void educ4bon_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.SwitchToForm(new Form5());
            }
        }

        private void hobbies4bon_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.SwitchToForm(new Form3());
            }
        }

        private void msg4bon_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.SwitchToForm(new Form6());
            }
        }
    }
}
