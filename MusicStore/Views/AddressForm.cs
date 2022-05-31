using MusicStore.Controllers;
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
    public partial class AddressForm : Form
    {
        private readonly AddressController _controller = new();

        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string postalCode { get; set; }
        public string voivodeship { get; set; }
        public AddressForm()
        {
            InitializeComponent();
            SetupComboBox();
        }

        private void SetupComboBox()
        {
            comboBoxCountry.DataSource = _controller.GetAllValuesFromTable("Countries");
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            this.country = comboBoxCountry.Text;
            this.city = textBoxCity.Text;
            this.street = textBoxStreet.Text;
            this.postalCode = textBoxPostal.Text;
            this.voivodeship = textBoxVoivodeship.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
