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
    public partial class frmMaintenance : Form
    {
        public frmMaintenance()
        {
            InitializeComponent();
        }

        private void btnAPSave_Click(object sender, EventArgs e)
        {
            isValidData();
        }

        private bool isValidData()
        {
            StringBuilder errorMessage = new StringBuilder();
            if (cboAPProductCategory.SelectedIndex == -1)
            {
                errorMessage.AppendLine("Please select a Product Category.");
            }
            if (cboAPProductModel.SelectedIndex == -1)
            {
                errorMessage.AppendLine("Please select a Product Model.");
            }
            if (cboAPColor.SelectedIndex == -1)
            {
                errorMessage.AppendLine("Please select a Color.");
            }
            if (txtAPStandardCost.Text == "" || Double.TryParse(txtAPStandardCost.Text, out double result))
            {
                errorMessage.AppendLine("Please enter a valid standard cost.");
            }
            if (txtAPListPrice).Text == "" || Double.TryParse(txtAPListPrice.Text, out double result))
            {
                errorMessage.AppendLine("Please enter a valid list price.");
            }
            if (txtAPSize.Text == "" || Double.TryParse(txtAPSize.Text, out double result))
            {
                errorMessage.AppendLine("Please enter a valid size.");
            }
            if (txtAPWeight.Text == "" || Double.TryParse(txtAPWeight.Text, out double result))
            {
                errorMessage.AppendLine("Please enter a valid weight.");
            }
        }
    }
}
