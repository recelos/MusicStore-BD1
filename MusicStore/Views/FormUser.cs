using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicStore.Controllers;
using MusicStore.Models;

namespace MusicStore.Views
{
    public partial class FormUser : Form
    {
        private readonly UserModel _loggedInUser;
        private readonly UserController _controller = new();
        public FormUser(UserModel loggedInUser)
        {
            InitializeComponent();
            _loggedInUser = loggedInUser;
            userCredentialsLabel.Text = $"Logged in as {_loggedInUser.FullName}";
            SetupComboBoxes();
            RefreshDataGrid();
        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }
        private void brandsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }
        private void typesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void conditionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }
        private void SetupComboBoxes()
        {
            brandsComboBox.DataSource = _controller.GetAllValuesFromColumn("Brands");
            conditionsComboBox.DataSource = _controller.GetAllValuesFromColumn("Conditions");
            typesComboBox.DataSource = _controller.GetAllValuesFromColumn("Types");
        }

        private void RefreshDataGrid()
        {
            var dataTable = _controller.GetInstruments(searchTextBox.Text, brandsComboBox.Text,
                typesComboBox.Text, conditionsComboBox.Text);
            instrumentsDataGridView.DataSource = dataTable;
        }
    }
}
