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
    public partial class FormOrders : Form
    {
        private readonly OrderModel _model;
        private readonly OrdersController _controller = new();
        public FormOrders(OrderModel model)
        {
            InitializeComponent();
            _model = model;
            RefreshDataGrid();
        }

        public FormOrders()
        {
            InitializeComponent();
            _model = null;
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            var dataTable = _controller.GetAllOrders();
            ordersDataGridView.DataSource = dataTable;
        }

        private void finalizeButton_Click(object sender, EventArgs e)
        {
            if(ordersDataGridView.CurrentRow == null) return;

            int id = (int)ordersDataGridView.CurrentRow.Cells[0].Value;   
            _controller.toggleIsCompleted(id);
            RefreshDataGrid();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ordersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var order = (int)ordersDataGridView.Rows[e.RowIndex].Cells[0].Value;

            new FormOrderItems(order).Show();
        }
    }
}
