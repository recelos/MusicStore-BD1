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

        private InstrumentModel _selectedInstrument;

        public FormEmployee(UserModel user)
        {
            InitializeComponent();
            _controller = new EmployeeController();
            _selectedInstrument = null;
            _user = user;
            RefreshDataGrid();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var formProd = new FormProduct();
            formProd.ShowDialog(this);
            RefreshDataGrid();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (instrumentsDataGridView.CurrentRow == null || instrumentsDataGridView.CurrentRow.Index >= instrumentsDataGridView.Rows.Count) return;
            
            var correct = int.TryParse(instrumentsDataGridView.SelectedRows[0].Cells[0].Value.ToString(), out var id);
            if (correct)
            {
                _controller.DeleteProduct(id);
            }
            RefreshDataGrid();
        }
        private void RefreshDataGrid()
        {
            var dataTable = _controller.GetInstruments();
            instrumentsDataGridView.DataSource = dataTable;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //var selected = instrumentsDataGridView.SelectedRows[0];
            //var formUpdateProd = new FormUpdateProd(int.Parse(selected.Cells[0].ToString()),selected.Cells[1].ToString(), selected.Cells[2].ToString(), selected.Cells[3].ToString(), selected.Cells[4].ToString(), selected.Cells[5].ToString(), selected.Cells[6].ToString());
            //formUpdateProd.ShowDialog(this);
            //RefreshDataGrid();
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            var formOrder = new FormOrders();
            formOrder.ShowDialog(this);
        }
    }
}
