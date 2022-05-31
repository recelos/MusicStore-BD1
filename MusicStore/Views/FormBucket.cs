using MusicStore.Controllers;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicStore.Views
{
    public partial class FormBucket : Form
    {
        private readonly BucketController _controller = new();
        private readonly UserModel _loggedInUser;
        public FormBucket(UserModel loggedInUser)
        {
            InitializeComponent();
            _loggedInUser = loggedInUser;
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            var dataTable = _controller.GetAllBucketItems(_loggedInUser.Id);
            bucketDataGridView.DataSource = dataTable;
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            var addressForm = new AddressForm();
            var result = addressForm.ShowDialog(this);
            if(result == DialogResult.OK)
            {
                Int32 countryId = Int32.Parse(_controller.GetCountryId(addressForm.country));
                _controller.CreateAddress(countryId, addressForm.city, addressForm.street, addressForm.postalCode, addressForm.voivodeship);
                Int32 addressId = Int32.Parse(_controller.GetAdressId(countryId, addressForm.city, addressForm.street, addressForm.postalCode, addressForm.voivodeship));
                _controller.CreateOrder(_loggedInUser.Id, addressId);
                for(int i = 0; i < 2; i++)
                _controller.AddProductsFromBucketToOrder(_loggedInUser.Id);
                this.Close();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Int32 bucketId = Int32.Parse(_controller.GetBucketId(_loggedInUser.Id));
            String name = (string)bucketDataGridView.CurrentRow.Cells[0].Value;
            String brand = (string)bucketDataGridView.CurrentRow.Cells[1].Value;
            String type = (string)bucketDataGridView.CurrentRow.Cells[2].Value;
            String condition = (string)bucketDataGridView.CurrentRow.Cells[5].Value;
            Int32 instrumentId = Int32.Parse(_controller.GetInstrumentId(name, brand, type, condition));
            _controller.RemoveSelectedInstrumentFromBucket(bucketId, instrumentId);
            RefreshDataGrid();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
