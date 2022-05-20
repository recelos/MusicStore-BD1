using System;
using System.Windows.Forms;
using MusicStore.Controllers;
using MusicStore.Models;
using MusicStore.Views;

namespace MusicStore
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Controller that handles connection with database.
        /// </summary>
        private readonly LoginController _controller = new();
        /// <summary>
        /// Tries to log in user to his account. <br/>
        /// If given username exists in the database, controller will check if correct password was given. <br/>
        /// If everything matches, controller will check whether the logging-in user is an employee or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            var userId = _controller.GetUserId(usernameTextBox.Text);
            if (userId == null)
            {
                MessageBox.Show("Wrong username or password","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var correctPassword = _controller.VerifyPassword((int)userId, passwordTextBox.Text);

            if (correctPassword)
            {
                var user = _controller.GetUser((int) userId);

                if (!user.IsEmployee)
                {
                    this.Hide();
                    var userForm = new FormUser(user);
                    userForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Hide();
                    var userForm = new FormEmployee(user);
                    userForm.ShowDialog();
                    this.Close();

                }
                Close();
            }
            else
            {
                MessageBox.Show("Wrong username or password","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Opens form, in which user may open a new account.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createAccButton_Click(object sender, EventArgs e)
        {
            Form createUser = new FormCreateUser();
            createUser.Show();
        }
    }
}
