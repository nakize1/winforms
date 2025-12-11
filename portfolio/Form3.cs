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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        MainForm main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void back3bon_Click(object sender, EventArgs e)
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

        private void info3bon_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.SwitchToForm(new Form2());
            }
        }

        private void skills3bon_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.SwitchToForm(new Form3());
            }
        }

        private void educ3bon_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.SwitchToForm(new Form4());
            }
        }

        private void hobbies3bon_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.SwitchToForm(new Form5());
            }
        }

        private void msg3bon_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.SwitchToForm(new Form6());
            }
        }
    }
}
