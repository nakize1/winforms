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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        MainForm main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

        private void back10sua_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form1());
            else { var f1 = new Form1(); f1.Show(); this.Hide(); }
        }

        private void info10sua_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form7());
        }

        private void skills10sua_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form8());
        }

        private void educ10sua_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form9());
        }

        private void hobbies10sua_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form10());
        }

        private void msg10sua_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form11());
        }
    }
}
