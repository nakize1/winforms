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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (main != null && !string.IsNullOrEmpty(main.CurrentUser))
            {
                label2.Text = $"Welcome, {main.CurrentUser}!";
            }
        }

        // Helper to open a form using MainForm.SwitchToForm when possible
        private void OpenFormInMain(Form frm)
        {
            var main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (main != null)
            {
                main.SwitchToForm(frm);
            }
            else
            {
                frm.Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFormInMain(new Form2());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(sender, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFormInMain(new Form7());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2_Click(sender, e);
        }
        private void mhika1fighter_Click(object sender, EventArgs e)
        {
            OpenFormInMain(new Form12());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            mhika1fighter_Click(sender, e);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenFormInMain(new Form17());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFormInMain(new Form17());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenFormInMain(new Form22());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFormInMain(new Form22());
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            var main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            main?.Logout();
        }

    }
}
