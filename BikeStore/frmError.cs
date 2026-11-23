using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeStore
{
    public partial class frmError : Form
    {
        public frmError()
        {
            InitializeComponent();
        }

        private void frmError_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bikeStoreDataSet.ErrorLog' table. You can move, or remove it, as needed.
            this.errorLogTableAdapter.Fill(this.bikeStoreDataSet.ErrorLog);

        }
    }
}
