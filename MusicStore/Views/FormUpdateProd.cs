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
    public partial class FormUpdateProd : Form
    {
        private readonly UpdateProdController _controller;

        private readonly InstrumentModel _instrument;

        private readonly int prodId;

        public FormUpdateProd(int id, string name, string brand, string type, string price,string country, string condition)
        {
            InitializeComponent();
            _controller = new UpdateProdController();
            brandComboBox.DataSource = _controller.GetAllValuesFromTable("Brands");
            typeComboBox.DataSource = _controller.GetAllValuesFromTable("Types");
            conditionComboBox.DataSource = _controller.GetAllValuesFromTable("Conditions");
            countryComboBox.DataSource = _controller.GetAllValuesFromTable("Countries");

            prodId = id;
            nameTextBox.Text = name;
            priceTextBox.Text = price;
            brandComboBox.SelectedItem = brand;
            typeComboBox.SelectedItem = type;
            conditionComboBox.SelectedItem = condition;
            countryComboBox.SelectedItem = country;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(priceTextBox.Text, out int price) || nameTextBox.Text == "")
            {
                MessageBox.Show("Wrong values!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _instrument.Id = prodId;
            _instrument.Name = nameTextBox.Text;
            _instrument.Price = price;
            _instrument.BrandId = _controller.GetValueId(brandComboBox.Text, "Brands");
            _instrument.TypeId = _controller.GetValueId(typeComboBox.Text, "Types");
            _instrument.ConditionId = _controller.GetValueId(conditionComboBox.Text, "Conditions");
            _instrument.CountryId = _controller.GetValueId(countryComboBox.Text, "Countries");

            if (_controller.UpdateProduct(_instrument))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Wrong values!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
