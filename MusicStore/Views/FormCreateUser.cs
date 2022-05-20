using System;
using System.Windows.Forms;
using MusicStore.Controllers;

namespace MusicStore.Views
{
    public partial class FormCreateUser : Form
    {
        private readonly CreateUserController _controller;
        public FormCreateUser()
        {
            InitializeComponent();
            _controller = ControllerFactory.CreateCreateUserController();
        }
        /// <summary>
        /// It will try to create a new user and insert them into the database. <br/>
        /// If everything goes alright, the window will close. Otherwise, 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createButton_Click(object sender, EventArgs e)
        {
            var success = _controller.CreateUser(usernameTextBox.Text, passwordTextBox.Text, 
                firstNameTextBox.Text, lastNameTextBox.Text);

            if (success)
                Close();
            else
                MessageBox.Show("Wrong data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cancelButton_Click(object sender, EventArgs e) => Close();

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
                passwordTextBox.PasswordChar = (char) 0;
            else
                passwordTextBox.PasswordChar = '*';
        }
    }
}
