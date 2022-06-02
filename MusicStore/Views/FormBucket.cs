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
            if (bucketDataGridView.RowCount == 0)
                return;

            var addressForm = new AddressForm();
            var result = addressForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var countryId = int.Parse(_controller.GetCountryId(addressForm.country));
                _controller.CreateAddress(countryId, addressForm.city, addressForm.street, addressForm.postalCode, addressForm.voivodeship);
                var addressId = int.Parse(_controller.GetAdressId(countryId, addressForm.city, addressForm.street, addressForm.postalCode, addressForm.voivodeship));
                var orderId = _controller.CreateOrder(_loggedInUser.Id, addressId);
                _controller.AddProductsFromBucketToOrder(_loggedInUser.Id, orderId);
                Close();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (bucketDataGridView.CurrentRow == null || bucketDataGridView.CurrentRow.Index > bucketDataGridView.RowCount)
            {
                return;
            }

            var bucketId = int.Parse(_controller.GetBucketId(_loggedInUser.Id));
            var name = bucketDataGridView.CurrentRow.Cells[0].Value.ToString();
            var brand = bucketDataGridView.CurrentRow.Cells[1].Value.ToString();
            var type = bucketDataGridView.CurrentRow.Cells[2].Value.ToString();
            var condition = bucketDataGridView.CurrentRow.Cells[5].Value.ToString();
            var instrumentId = int.Parse(_controller.GetInstrumentId(name, brand, type, condition));
            _controller.RemoveSelectedInstrumentFromBucket(bucketId, instrumentId);
            RefreshDataGrid();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
