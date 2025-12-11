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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        MainForm main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

        private void back22ban_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Returning to Main Menu");
            if (main != null) main.SwitchToForm(new Form1());
            else { var f1 = new Form1(); f1.Show(); this.Hide(); }
        }

        private void info22ban_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form22());
        }

        private void skills22ban_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form23());
        }

        private void educ22ban_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form24());
        }

        private void hobbies22ban_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form25());
        }

        private void msg22ban_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form26());
        }
    }
}
