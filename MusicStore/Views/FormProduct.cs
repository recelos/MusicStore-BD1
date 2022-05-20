using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicStore.Models;

namespace MusicStore.Views
{
    public partial class FormProduct : Form
    {
        public InstrumentModel Instrument { get; set; }
        public FormProduct()
        {
            InitializeComponent();
            Instrument = null;
        }

        public FormProduct(InstrumentModel instrModel)
        {
            InitializeComponent();
            Instrument = instrModel;
        }
    }
}
