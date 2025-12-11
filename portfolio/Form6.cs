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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        MainForm main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

        private void back6bon_Click(object sender, EventArgs e)
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

        private void info6bon_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.SwitchToForm(new Form2());
            }
        }

        private void skills6bon_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.SwitchToForm(new Form4());
            }
        }

        private void educ6bon_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.SwitchToForm(new Form5());
            }
        }

        private void hobbies6bon_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.SwitchToForm(new Form3());
            }
        }

        private void msg6bon_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.SwitchToForm(new Form6());
            }
        }
    }
}
