using System;
using System.Linq;
using System.Windows.Forms;

namespace portfolio
{
    internal static class NavigationHelper
    {
        public static void AttachStandardNav(Form form)
        {
            if (form == null) return;

            // parse form number from type name e.g., "Form8"
            var typeName = form.GetType().Name;
            int number = 0;
            if (typeName.StartsWith("Form") && int.TryParse(typeName.Substring(4), out var n)) number = n;

            // helper to get MainForm
            Func<MainForm> getMain = () => Application.OpenForms.OfType<MainForm>().FirstOrDefault();

            // attach handlers based on button name
            foreach (var btn in form.Controls.OfType<Button>())
            {
                var name = (btn.Name ?? string.Empty).ToLowerInvariant();
                if (name.Contains("back"))
                {
                    btn.Click += (s, e) =>
                    {
                        var main = getMain();
                        if (main != null) main.SwitchToForm(new Form1());
                        else { var f1 = new Form1(); f1.Show(); form.Hide(); }
                    };
                }
                else if (name.Contains("info"))
                {
                    btn.Click += (s, e) =>
                    {
                        var main = getMain();
                        if (main != null)
                        {
                            var target = CreateFormByNumber(number);
                            if (target != null) main.SwitchToForm(target);
                        }
                    };
                }
                else if (name.Contains("skills"))
                {
                    btn.Click += (s, e) =>
                    {
                        var main = getMain();
                        if (main != null)
                        {
                            var target = CreateFormByNumber(number + 1);
                            if (target != null) main.SwitchToForm(target);
                        }
                    };
                }
                else if (name.Contains("educ"))
                {
                    btn.Click += (s, e) =>
                    {
                        var main = getMain();
                        if (main != null)
                        {
                            var target = CreateFormByNumber(number + 2);
                            if (target != null) main.SwitchToForm(target);
                        }
                    };
                }
                else if (name.Contains("hobbies"))
                {
                    btn.Click += (s, e) =>
                    {
                        var main = getMain();
                        if (main != null)
                        {
                            var target = CreateFormByNumber(number + 3);
                            if (target != null) main.SwitchToForm(target);
                        }
                    };
                }
                else if (name.Contains("msg") || name.Contains("message"))
                {
                    btn.Click += (s, e) =>
                    {
                        var main = getMain();
                        if (main != null)
                        {
                            var target = CreateFormByNumber(number + 4);
                            if (target != null) main.SwitchToForm(target);
                        }
                    };
                }
            }
        }

        private static Form CreateFormByNumber(int number)
        {
            if (number <= 0) return null;
            var typeName = $"portfolio.Form{number}";
            var asm = typeof(Form1).Assembly;
            var t = asm.GetType(typeName);
            if (t == null) return null;
            try
            {
                var inst = Activator.CreateInstance(t) as Form;
                return inst;
            }
            catch
            {
                return null;
            }
        }
    }
}
