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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        MainForm main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

        private void button1_Click(object sender, EventArgs e)
        {
            // info5bon mapped to this handler in designer
            if (main != null)
            {
                main.SwitchToForm(new Form2());
            }
        }

        private void back5bon_Click(object sender, EventArgs e)
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

        private void skills5bon_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.SwitchToForm(new Form4());
            }
        }

        private void educ5bon_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.SwitchToForm(new Form5());
            }
        }

        private void hobbies5bon_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.SwitchToForm(new Form3());
            }
        }

        private void msg5bon_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.SwitchToForm(new Form6());
            }
        }
    }
}
