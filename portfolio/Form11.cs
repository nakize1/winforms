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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        MainForm main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

        private void back11sua_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form1());
            else { var f1 = new Form1(); f1.Show(); this.Hide(); }
        }

        private void info11sua_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form7());
        }

        private void skills11sua_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form8());
        }

        private void educ11sua_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form9());
        }

        private void hobbies11sua_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form10());
        }

        private void msg11sua_Click(object sender, EventArgs e)
        {
            if (main != null) main.SwitchToForm(new Form11());
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
