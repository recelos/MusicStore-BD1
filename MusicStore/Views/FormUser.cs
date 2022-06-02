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
            _controller.CreateBucketForUser(_loggedInUser.Id);
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
            brandsComboBox.DataSource = _controller.GetAllValuesFromTable("Brands");
            conditionsComboBox.DataSource = _controller.GetAllValuesFromTable("Conditions");
            typesComboBox.DataSource = _controller.GetAllValuesFromTable("Types");
        }

        private void RefreshDataGrid() => instrumentsDataGridView.DataSource = _controller.GetInstruments(searchTextBox.Text, brandsComboBox.Text,
                typesComboBox.Text, conditionsComboBox.Text);

        private void addToBucketButton_Click(object sender, EventArgs e)
        {

            if (instrumentsDataGridView.CurrentRow == null || instrumentsDataGridView.CurrentRow.Index > instrumentsDataGridView.RowCount)
                return;
            

            var userId = _loggedInUser.Id;
            var name = instrumentsDataGridView.CurrentRow.Cells[0].Value.ToString();
            var brand = instrumentsDataGridView.CurrentRow.Cells[1].Value.ToString();
            var type = instrumentsDataGridView.CurrentRow.Cells[2].Value.ToString();
            var condition = instrumentsDataGridView.CurrentRow.Cells[5].Value.ToString();
            var instrumentId = int.Parse(_controller.GetInstrumentId(name, brand, type, condition));
            _controller.AddSelectedInstrumentToBucket(userId, instrumentId);
            RefreshDataGrid();
        }

        private void showBucketButton_Click(object sender, EventArgs e)
        {
            var formBucket = new FormBucket(_loggedInUser);
            RefreshDataGrid();
            formBucket.ShowDialog(this);
            RefreshDataGrid();
        }

    }
}
