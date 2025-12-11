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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string CurrentUser { get; set; }

        public void Logout()
        {
            CurrentUser = null;
            SwitchToForm(new loginForm());
        }
        public void SwitchToForm(Form newForm, bool preserveNativeSize = false)
        {
            contentPanel.Controls.Clear();

            // Configure the Form to behave like a control
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None; // Remove title bar

            if (!preserveNativeSize)
            {
                // Default behavior: fill the panel
                newForm.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(newForm);
                newForm.Show();
                return;
            }

            // Preserve native image size: prefer BackgroundImage, otherwise first PictureBox image
            Image img = newForm.BackgroundImage;
            if (img == null)
            {
                var pb = newForm.Controls.OfType<PictureBox>().FirstOrDefault(p => p.Image != null);
                if (pb != null) img = pb.Image;
            }

            // Determine target size (DPI-aware)
            Size target;
            if (img != null)
            {
                float scale = newForm.DeviceDpi / 96f;
                target = new Size((int)(img.Width * scale), (int)(img.Height * scale));
            }
            else
            {
                // fallback to preferred size
                target = newForm.PreferredSize;
                if (target.Width <= 0) target.Width = 800;
                if (target.Height <= 0) target.Height = 600;
            }

            newForm.Dock = DockStyle.None;
            newForm.Size = target;
            newForm.Location = new Point(0, 0);

            // Resize contentPanel to fit the new form
            contentPanel.AutoScroll = false;
            contentPanel.ClientSize = target;

            // Add and show
            contentPanel.Controls.Add(newForm);
            newForm.Show();

            // Resize the MainForm client area to accommodate contentPanel plus padding
            const int paddingRight = 20;
            const int paddingBottom = 40;

            int desiredWidth = contentPanel.Left + contentPanel.ClientSize.Width + paddingRight;
            int desiredHeight = contentPanel.Top + contentPanel.ClientSize.Height + paddingBottom;

            this.ClientSize = new Size(Math.Max(this.ClientSize.Width, desiredWidth), Math.Max(this.ClientSize.Height, desiredHeight));
        }

        public void SwitchToFormNumber(int formNumber, bool preserveNativeSize = false)
        {
            if (formNumber <= 0) return;
            var typeName = $"portfolio.Form{formNumber}";
            var asm = typeof(Form1).Assembly;
            var t = asm.GetType(typeName);
            if (t == null)
            {
                // fallback: if type not found, do nothing
                return;
            }
            try
            {
                var inst = Activator.CreateInstance(t) as Form;
                if (inst != null) SwitchToForm(inst, preserveNativeSize);
            }
            catch
            {
                // ignore failures
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SwitchToForm(new loginForm());
        }
    }
}
