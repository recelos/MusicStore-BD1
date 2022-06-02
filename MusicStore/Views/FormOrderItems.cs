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

namespace MusicStore.Views
{
    public partial class FormOrderItems : Form
    {
        private readonly OrderItemsController _controller = new OrderItemsController();
        public FormOrderItems(int orderId)
        {
            InitializeComponent();
            itemsDataGridView.DataSource = _controller.GetOrderItems(orderId);

        }

    }
}
