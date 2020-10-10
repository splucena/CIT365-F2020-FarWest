using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote() 
        {
            InitializeComponent();
        }

        public DisplayQuote(List<String> quote)
        {
            InitializeComponent();

            this.Text = $"{quote[0]} - {quote[1]}";
            lblDate.Text = quote[1];
            lblCustomerName.Text = quote[0];
            lblTotalSizeIn.Text = quote[2];
            lblSizeCost.Text = quote[3];
            lblDrawerCost.Text = quote[4];
            lblMaterial.Text = quote[5];
            lblMaterialCost.Text = quote[6];
            lblShippingMethod.Text = quote[7];
            lblShippingCost.Text = quote[8];
            lblTotalCost.Text = quote[9];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
