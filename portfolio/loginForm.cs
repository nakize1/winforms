using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq;

namespace portfolio
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            PlaceholderHelper.SetPlaceholder(usernameTb, "Username");
            PlaceholderHelper.SetPlaceholder(passwordTb, "Password");
            PlaceholderHelper.SetPlaceholder(confirmTb, "Confirm Password");
        }
        MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
        bool signup = false;
        private bool loggedIn = false;
        public bool isLoggedIn
        {
            get { return loggedIn; }
            private set { loggedIn = value; }
        }

        public void Logout()
        {
            // Reset login state and UI
            loggedIn = false;
            signup = false;
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate { ResetLoginUi(); });
            }
            else
            {
                ResetLoginUi();
            }
        }

        private void ResetLoginUi()
        {
            confirmTb.Visible = false;
            confirmTb.Enabled = false;
            confirmBtn.Text = "Log In";
            registerBtn.Text = "Sign Up";
            forgotLabel.Visible = true;

            usernameTb.Text = string.Empty;
            passwordTb.Text = string.Empty;
            confirmTb.Text = string.Empty;

            this.Show();
            this.BringToFront();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            string connString = "server=LAPTOP-6SFH7LN0;database=imlogin;trusted_connection=true;TrustServerCertificate=True";
            using (SqlConnection con = new SqlConnection(connString)) 
            {
                try
                {
                    con.Open();
                    //create table if it doesn't exist
                    string createTableQuery = "IF OBJECT_ID(N'users', N'U') IS NULL BEGIN CREATE TABLE users (id INT IDENTITY(1,1) PRIMARY KEY, username VARCHAR(50), password VARCHAR(100)) END;";
                    using (SqlCommand cmd = new SqlCommand(createTableQuery, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    if (signup)
                    {
                        if (usernameTb.Text == "" || passwordTb.Text == "" || confirmTb.Text == "")
                        {
                            MessageBox.Show("All fields are required");
                            return;
                        }
                        if (passwordTb.Text != confirmTb.Text)
                        {
                            MessageBox.Show("Passwords do not match");
                            return;
                        }
                        string checkUserQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
                        using (SqlCommand cmd = new SqlCommand(checkUserQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@username", usernameTb.Text);
                            int userCount = (int)cmd.ExecuteScalar();
                            if (userCount > 0)
                            {
                                MessageBox.Show("Account with username already exists");
                                return;
                            }
                        }
                        string query = "INSERT INTO users (username, password) VALUES (@username, @password)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@username", usernameTb.Text);
                            string hashed = BCrypt.Net.BCrypt.HashPassword(passwordTb.Text);
                            cmd.Parameters.AddWithValue("@password", hashed);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Account created successfully. Please log in again.");
                            usernameTb.Text = "";
                            passwordTb.Text = "";
                            confirmTb.Text = "";
                            signup = false;
                            confirmTb.Visible = false;
                            confirmTb.Enabled = false;
                            confirmBtn.Text = "Log In";
                            registerBtn.Text = "Sign Up";
                            forgotLabel.Visible = true;
                        }
                    }
                    else
                    {
                        if (usernameTb.Text == "" || passwordTb.Text == "")
                        {
                            MessageBox.Show("All fields are required");
                            return;
                        }

                        // Retrieve the stored hashed password for the given username
                        string query = "SELECT password FROM users WHERE username = @username";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@username", usernameTb.Text);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string storedHash = reader.GetString(0);
                                    if (BCrypt.Net.BCrypt.Verify(passwordTb.Text, storedHash))
                                    {
                                        MessageBox.Show("Login successful");
                                        // Mark as logged in
                                        loggedIn = true;
                                        if (mainForm != null) mainForm.CurrentUser = usernameTb.Text;
                                        mainForm?.SwitchToFormNumber(1);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid username or password");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid username or password or account does not exist");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "An error occurred");
                    MessageBox.Show(ex.StackTrace, "An error occurred");

                }
            }
        }
        private void signupBtn_Click(object sender, EventArgs e)
        {
            if (signup)
            {
                signup = false;
                confirmTb.Visible = false;
                confirmTb.Enabled = false;
                confirmBtn.Text = "Log In";
                registerBtn.Text = "Sign Up";
                forgotLabel.Visible = true;
            }
            else
            {
                signup = true;
                confirmTb.Visible = true;
                confirmTb.Enabled = true;
                confirmBtn.Text = "Sign Up";
                registerBtn.Text = "Return to Login";
                forgotLabel.Visible = false;
            }
        }

    }
}
