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
            
            Int32 id = (Int32)ordersDataGridView.CurrentRow.Cells[0].Value;   
            _controller.toggleIsCompleted(id);
            RefreshDataGrid();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
