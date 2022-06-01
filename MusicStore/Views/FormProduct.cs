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
    public partial class FormProduct : Form
    {
        private readonly ProductController _controller = new ();
        public InstrumentModel Instrument { get; set; }
        public FormProduct()
        {
            InitializeComponent();
            Instrument = null;
            brandComboBox.DataSource = _controller.GetAllValuesFromTable("Brands");
            typeComboBox.DataSource = _controller.GetAllValuesFromTable("Types");
            conditionComboBox.DataSource = _controller.GetAllValuesFromTable("Conditions");
            countryComboBox.DataSource = _controller.GetAllValuesFromTable("Countries");

        }

        public FormProduct(InstrumentModel instrModel)
        {
            InitializeComponent();
            Instrument = instrModel;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            var brandId = _controller.GetValueId(brandComboBox.Text, "Brands");
            var typeId = _controller.GetValueId(typeComboBox.Text, "Types");
            var conditionId = _controller.GetValueId(conditionComboBox.Text, "Conditions");
            var countryId = _controller.GetValueId(countryComboBox.Text, "Countries");

            if (nameTextBox.Text == "" || !int.TryParse(priceTextBox.Text, out int price))
            {
                MessageBox.Show("Wrong values!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            Instrument = new InstrumentModel(0, nameTextBox.Text, typeId, brandId, price, false,
                null, countryId, conditionId, DateTime.Now);

            if (_controller.AddProduct(Instrument))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Wrong values!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) => Close();
        
    }
}
