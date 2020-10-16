﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class ViewAllQuotes : Form
    {
        private ListViewColumnSorter lvwColumnSorter;
        public ViewAllQuotes()
        {
            InitializeComponent();
            // Create an instance of a ListView column sorter and assign it
            // to the ListView control.
            lvwColumnSorter = new ListViewColumnSorter();
            this.lvQuotes.ListViewItemSorter = lvwColumnSorter;
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            lvQuotes.View = View.Details;
            // Used for creating column headers.
            ColumnHeader columnheader;

            // Read content of file storage
            string[] lines = File.ReadAllLines(@"qoutes.txt");
            foreach (string line in lines)
            {
                //string[] quote = line.Split(new string[] { "," }, StringSplitOptions.None);
                string[] quote = line.Split(',');
                lvQuotes.Items.Add(new ListViewItem(quote));
            }

            // Loop through and size each column header to fit the column header text.
            foreach (ColumnHeader ch in this.lvQuotes.Columns)
            {
                ch.Width = -2;
            }

            // Read data from json file.
            string jsonPath = @"quotes.json";

            if (!File.Exists(jsonPath))
            {
                MessageBox.Show("Information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                // Read data from json.
                var jsonData = File.ReadAllText(jsonPath);
                // Deserialize json and then save it to a list
                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonData, new JsonSerializerSettings
                {
                    DateFormatString = "MM/dd/YYYY HH:mm:ss"
                });

                //dgvQuotes.Columns[0].Name = "Name";
                //dgvQuotes.Columns[1].Name = "Shipping Date";

                // Populate datagrid
                foreach(DeskQuote dq in deskQuotes)
                {
                    string dateCreated = dq.ShippingDate.ToString();
                    string customerName = dq.CustomerName;

                    string totalSize = $"{Math.Round(dq.computeSurfaceArea(dq.Desk.Width, dq.Desk.Depth), 2)}";
                    string sizeCost = Math.Round(dq.computeDeskSizeCost(), 2).ToString("F");
                    string drawerCost = Math.Round(dq.computeDrawerCost(), 2).ToString("F");
                    string material = dq.Desk.SurfaceMaterial;
                    string materialCost = Math.Round(dq.computeSurfaceMaterialCost(), 2).ToString("F");
                    //string shippingMethod = _shippingMethod;
                    int shippingDays = dq.Desk.RushOrderDay;
                    string shippingMethod = "";
                    string shippingCost = Math.Round(dq.computeShippingCost(), 2).ToString("F");
                    string totalCost = Math.Round(dq.computeDeskPrice(), 2).ToString("F");
                    
                    if (shippingDays != 14)
                    {
                        shippingMethod = $"Rush - {shippingDays} days.";
                    } else
                    {
                        shippingMethod = $"Normal - {shippingDays} days.";
                    }

                    string[] row = { customerName, dateCreated, shippingMethod, totalSize, sizeCost, 
                                     drawerCost, material, materialCost, shippingCost, totalCost };
                    dgvQuotes.Rows.Add(row);
                }
            }


        }

        private void lvQuotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvQuotes.SelectedItems.Count > 0)
            {
                ListViewItem lv = lvQuotes.SelectedItems[0];
                lblCustomerName.Text = lv.SubItems[0].Text;
                // Date

                // Desk details
                lblBasePrice.Text = "200.00";
                lblBaseSizeIncluded.Text = "1000.00";
                lblCostPerIn.Text = "1.00";

                // Surface area
                lblTotalSizeIn.Text = lv.SubItems[2].Text;
                lblSizeCost.Text = lv.SubItems[3].Text;

                // Drawer
                lblPricePerDrawer.Text = "50.00";
                lblDrawerCost.Text = lv.SubItems[4].Text;

                // Material
                lblMaterial.Text = lv.SubItems[5].Text;
                lblMaterialCost.Text = lv.SubItems[6].Text;

                // Shipping
                lblShippingMethod.Text = lv.SubItems[7].Text;
                lblShippingCost.Text = lv.SubItems[8].Text;

                // Total cost
                lblTotalCost.Text = lv.SubItems[9].Text;
                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvQuotes_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.lvQuotes.Sort();
        }

        private void dgvQuotes_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvQuotes.SelectedRows)
            {
                lblCustomerName.Text = row.Cells[0].Value.ToString();
                // Date

                // Desk details
                lblBasePrice.Text = "200.00";
                lblBaseSizeIncluded.Text = "1000.00";
                lblCostPerIn.Text = "1.00";

                // Surface area
                lblTotalSizeIn.Text = row.Cells[3].Value.ToString();
                lblSizeCost.Text = row.Cells[4].Value.ToString();

                // Drawer
                lblPricePerDrawer.Text = "50.00";
                lblDrawerCost.Text = row.Cells[5].Value.ToString();

                // Material
                lblMaterial.Text = row.Cells[6].Value.ToString();
                lblMaterialCost.Text = row.Cells[7].Value.ToString();

                // Shipping
                lblShippingMethod.Text = row.Cells[2].Value.ToString();
                lblShippingCost.Text = row.Cells[8].Value.ToString();

                // Total cost
                lblTotalCost.Text = row.Cells[9].Value.ToString();
            }
        }
    }
}
