using System;
using System.Windows.Forms;
using MusicStore.Controllers;
using MusicStore.Models;

namespace MusicStore.Views
{
    public partial class FormEmployee : Form
    {
        private readonly UserModel _user;

        private readonly EmployeeController _controller;

        public FormEmployee(UserModel user)
        {
            InitializeComponent();
            _controller = new EmployeeController();

            _user = user;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var formProd = new FormProduct();
            formProd.ShowDialog(this);


            _controller.AddProduct(formProd.Instrument);


        }
    }
}
