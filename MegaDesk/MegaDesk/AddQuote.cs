using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MegaDesk

{
    //public enum SurfaceMaterial
    //{
    //    Laminate,
    //    Oak,
    //    Rosewood,
    //    Veneer,
    //    Pine,
    //};
    public partial class AddQuote : Form
    {
        private string dateCreated;
        private string customerName;
        private string totalSize;
        private string sizeCost;
        private string drawerCost;
        private string material;
        private string materialCost;
        private string shippingMethod;
        private string shippingCost;
        private string totalCost;
        public AddQuote()
        {
            InitializeComponent();             
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            cbSurfaceMaterial.DataSource = Enum.GetValues(typeof(SurfaceMaterial));
            cbSurfaceMaterial.SelectedItem = SurfaceMaterial.Laminate;

            cbOrderOptions.SelectedIndex = 0;
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddQuote_Click(object sender, EventArgs e)
        {

            bool allValid = true;
            string[] controls = { txtName.Text, txtWidth.Text, txtDepth.Text, 
                cbNoOfDrawers.Value.ToString(), cbOrderOptions.Text, cbSurfaceMaterial.Text, dtDateCreated.Text };

            foreach(string c in controls)
            {
                if (string.IsNullOrEmpty(c))
                {
                    allValid = false;
                }
            }

            Console.WriteLine(allValid);

            if (!allValid)
            {
                MessageBox.Show("Please fill-in all required values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                epInvalid.SetError(txtName, "Required!");
                epInvalid.SetError(txtWidth, "Required!");
                epInvalid.SetError(txtDepth, "Required!");
            }
            else
            {
                // Get values for desk class
                decimal width; 
                bool widthIsDecimal =  decimal.TryParse(txtWidth.Text, out width);

                decimal depth;
                bool depthIsDecimal = decimal.TryParse(txtDepth.Text, out depth);

                int numberOfDrawer; 
                bool noOfDrawerIsInt = int.TryParse(cbNoOfDrawers.Text, out numberOfDrawer);

                int rushOptionDays;
                bool rushOptionsDaysIsInt = int.TryParse(cbOrderOptions.Text, out rushOptionDays);
                string surfaceMaterial = cbSurfaceMaterial.Text;

                // Crete desk
                Desk d = new Desk(width, depth, numberOfDrawer, surfaceMaterial, rushOptionDays);

                // Shipping details
                string _shippingMethod = null;
                if (rushOptionDays != 14)
                {
                    _shippingMethod = $"Rush - {rushOptionDays} Days";
                }
                else
                {
                    _shippingMethod = $"Normal - {rushOptionDays} Days";
                }
                // Create DeskQuote
                DeskQuote dq = new DeskQuote(d, Convert.ToDateTime(dtDateCreated.Value), txtName.Text);                
                dq.saveDeskQuote(dq);

                // Create and pass data to DisplayQuote form
                
                dateCreated = dtDateCreated.Text;
                customerName = txtName.Text;
                totalSize = $"{Math.Round(dq.computeSurfaceArea(width, depth), 2)}";
                sizeCost = Math.Round(dq.computeDeskSizeCost(), 2).ToString("F");
                drawerCost = Math.Round(dq.computeDrawerCost(), 2).ToString("F");
                material = surfaceMaterial;
                materialCost = Math.Round(dq.computeSurfaceMaterialCost(), 2).ToString("F");
                shippingMethod = _shippingMethod;
                shippingCost = Math.Round(dq.computeShippingCost(), 2).ToString("F");
                totalCost = Math.Round(dq.computeDeskPrice(), 2).ToString("F");

                List<string> quote = new List<string>();
                quote.Add(customerName);
                quote.Add(dateCreated);
                quote.Add(totalSize);
                quote.Add(sizeCost);
                quote.Add(drawerCost);
                quote.Add(material);
                quote.Add(materialCost);
                quote.Add(shippingMethod);
                quote.Add(shippingCost);
                quote.Add(totalCost);

                DisplayQuote displayQuote = new DisplayQuote(quote);

                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    displayQuote.ShowDialog();
                }
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                epInvalid.SetError(txtName, "Please provide customer name.");
                epCorrect.SetError(txtName, null);
            } else
            {
                //e.Cancel = true;
                epInvalid.SetError(txtName, null);
                epCorrect.SetError(txtName, "Corret");
            }
        }

        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex numberchk = new Regex(@"^([0-9]*|\d*)$");
            if (numberchk.IsMatch(txtWidth.Text) && (!string.IsNullOrEmpty(txtWidth.Text)))
            {
                epInvalid.SetError(txtWidth, null);
                epCorrect.SetError(txtWidth, "Correct");
            } else
            {
                epInvalid.SetError(txtWidth, "Accepts numeric values only");
                epCorrect.SetError(txtWidth, null);
            }

        }

        private void txtWidth_Validating(object sender, CancelEventArgs e)
        {
            Regex numberchk = new Regex(@"^([0-9]*|\d*)$");

            decimal minDeskWidth = Desk.MIN_DESK_WIDTH;
            decimal maxDeskWidth = Desk.MAX_DESK_WIDTH;
            decimal width;            
            bool success = decimal.TryParse(txtWidth.Text, out width);
            if (numberchk.IsMatch(txtWidth.Text) && (!string.IsNullOrEmpty(txtWidth.Text)) 
                &&  (width >= minDeskWidth) && (width <= maxDeskWidth) && success)
            {
                epInvalid.SetError(txtWidth, null);
                epCorrect.SetError(txtWidth, "Correct");
            }
            else
            {
                e.Cancel = true;
                txtWidth.Focus();
                epInvalid.SetError(txtWidth, "Accepts numeric values only and values from 24 to 96 only.");
                epCorrect.SetError(txtWidth, null);
            }
        }

        private void txtDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                epInvalid.SetError(txtDepth, null);
                epCorrect.SetError(txtDepth, "Corret");
            } else
            {
                epInvalid.SetError(txtDepth, "Accepts numeric values only");
                epCorrect.SetError(txtDepth, null);
            }
        }

        private void txtDepth_Validating(object sender, CancelEventArgs e)
        {
            Regex numberchk = new Regex(@"^([0-9]*|\d*)$");
            decimal minDeskDepth = Desk.MIN_DESK_DEPTH;
            decimal maxDeskDepth = Desk.MAX_DESK_DEPTH;
            decimal depth;
            bool success = decimal.TryParse(txtDepth.Text, out depth);
            if (numberchk.IsMatch(txtDepth.Text) && (!string.IsNullOrEmpty(txtDepth.Text))
                && (depth >= minDeskDepth) && (depth <= maxDeskDepth) && success)
            {
                epInvalid.SetError(txtDepth, null);
                epCorrect.SetError(txtDepth, "Correct");
            }
            else
            {
                e.Cancel = true;
                txtDepth.Focus();
                epInvalid.SetError(txtDepth, "Accepts numeric values only and values from 24 to 48.");
                epCorrect.SetError(txtDepth, null);
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex valid = new Regex(@"^[A-Za-z ]+$");
            if (valid.IsMatch(txtName.Text))
            {
                epInvalid.SetError(txtName, null);
                epCorrect.SetError(txtName, "Correct");                
            } else
            {
                epInvalid.SetError(txtName, "Alphabet and spaces only.");
                epCorrect.SetError(txtName, null);
            }
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
