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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        MainForm main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

        private void back23_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form1());
            else { var f1 = new Form1(); f1.Show(); this.Hide(); }
        }

        private void info23_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form22());
        }

        private void skills23_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form23());
        }

        private void educ23_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form24());
        }

        private void hobbies23_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form25());
        }

        private void msg23_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form26());
        }
    }
}
