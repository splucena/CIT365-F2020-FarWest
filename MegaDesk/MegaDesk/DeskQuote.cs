using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MegaDesk
{
    class DeskQuote
    {
        private Desk _desk;
        private DateTime _shippingDate;
        private String _customerName;

        private List<DeskQuote> _dq;

        public DeskQuote(Desk desk, DateTime shippingDate, String customerName)
        {
            _desk = desk;
            _shippingDate = shippingDate;
            _customerName = customerName;
        }

        public decimal computeSurfaceArea(decimal width, decimal height)
        {
            return width * height;
        }

        public decimal computeShippingCost()
        {
            
            decimal totalSurfaceArea = computeSurfaceArea(_desk.Width, _desk.Depth);
            decimal rushOrderCost;
            if (_desk.RushOrderDay == 3)
            {
                if (totalSurfaceArea < 1000)
                {
                    rushOrderCost = 60;
                }
                else if (totalSurfaceArea >= 100 && totalSurfaceArea <= 2000)
                {
                    rushOrderCost = 70;
                }
                else
                {
                    rushOrderCost = 80;
                }
            }
            else if (_desk.RushOrderDay == 5)
            {
                if (totalSurfaceArea < 1000)
                {
                    rushOrderCost = 40;
                }
                else if (totalSurfaceArea >= 100 && totalSurfaceArea <= 2000)
                {
                    rushOrderCost = 50;
                }
                else
                {
                    rushOrderCost = 60;
                }
            }
            else if (_desk.RushOrderDay == 7)
            {
                if (totalSurfaceArea < 1000)
                {
                    rushOrderCost = 30;
                }
                else if (totalSurfaceArea >= 100 && totalSurfaceArea <= 2000)
                {
                    rushOrderCost = 35;
                }
                else
                {
                    rushOrderCost = 40;
                }
            }
            else
            {
                rushOrderCost = 0;
            }

            return rushOrderCost;
        }

        public decimal computeDeskSizeCost()
        {
            decimal totalSurfaceArea = computeSurfaceArea(_desk.Width, _desk.Depth);
            decimal totalDeskSizeCost;
            const decimal BASE_DESK_PRICE = 200;

            if (totalSurfaceArea > 1000)
            {
                totalDeskSizeCost = BASE_DESK_PRICE + (totalSurfaceArea - 1000);
            }
            else
            {
                totalDeskSizeCost = BASE_DESK_PRICE;
            }

            return totalDeskSizeCost;
        }

        public decimal computeDrawerCost()
        {
            return _desk.NumberOfDrawer * 50;
        }

        public decimal computeSurfaceMaterialCost()
        {
            decimal surfaceMaterialCost;
            switch (_desk.SurfaceMaterial)
            {
                case "Oak":
                    surfaceMaterialCost = 200;
                    break;
                case "Laminate":
                    surfaceMaterialCost = 100;
                    break;
                case "Pine":
                    surfaceMaterialCost = 50;
                    break;
                case "Rosewood":
                    surfaceMaterialCost = 300;
                    break;
                case "Veneer":
                    surfaceMaterialCost = 125;
                    break;
                default:
                    surfaceMaterialCost = 0;
                    break;
            }

            return surfaceMaterialCost;
        }

        public decimal computeDeskPrice()
        {
            decimal totalDeskSizeCost = computeDeskSizeCost();
            decimal totalDrawerAmount = computeDrawerCost();
            decimal surfaceMaterialCost = computeSurfaceMaterialCost();
            decimal shippingCost = computeShippingCost();

            return totalDeskSizeCost + totalDrawerAmount + surfaceMaterialCost + shippingCost;

        }
        //The following function creates the .json file in the /bin folder
        public void saveDeskQuoteJS (DeskQuote dq)
        {
            //Create the new object that uses public variables in order to access information to create the json file.
            PublicDesk deskJs = new PublicDesk();

            //populating all the public class variables
            deskJs._pCustomerName = dq._customerName;
            deskJs._pDateCreated = dq._shippingDate;
            deskJs._pWidth = dq._desk.Width;
            deskJs._pDepth = dq._desk.Depth;
            deskJs._pTotalSurfaceArea = $"{Math.Round(computeSurfaceArea(deskJs._pWidth, deskJs._pDepth), 2)}";
            deskJs._pSizeCost = Math.Round(computeDeskSizeCost(), 2).ToString("F");
            deskJs._pDrawerCost = Math.Round(computeDrawerCost(), 2).ToString("F");
            deskJs._pMaterial = dq._desk.SurfaceMaterial; ;
            deskJs._pMaterialCost = Math.Round(computeSurfaceMaterialCost(), 2).ToString("F");
            string shippingMethod = null;
            deskJs._pRushOptionDays = dq._desk.RushOrderDay;
            if (deskJs._pRushOptionDays != 14)
            {
                shippingMethod = $"Rush - {deskJs._pRushOptionDays} Days";
            }
            else
            {
                shippingMethod = $"Normal - {deskJs._pRushOptionDays} Days";
            }
            deskJs._pShippingCost = Math.Round(computeShippingCost(), 2).ToString("F");
            deskJs._pTotalCost = Math.Round(computeDeskPrice(), 2).ToString("F");

            //This variable is actually the string written in a json format
            string json = JsonConvert.SerializeObject(deskJs);

            //the following creates the json file. 
            string path = @"qoutesJs.json";
            // This text is added only once to the file
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {

                    sw.WriteLine(json);
                }
            }
            else 
            // This text is always added, making file longer over time
            // if not deleted
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(json);
            }
        }

        public void saveDeskQuote(DeskQuote dq)
        {
            _dq = new List<DeskQuote>();
            _dq.Add(dq);

            // DeskQoute
            string customerName = dq._customerName;
            DateTime dateCreated = dq._shippingDate;

            decimal width = dq._desk.Width;
            decimal depth = dq._desk.Depth;
            //string totalSurfaceArea = $"{Math.Round(dq._desk.computeSurfaceArea(width, depth), 2)}";
            string totalSurfaceArea = $"{Math.Round(computeSurfaceArea(width, depth), 2)}";

            //string sizeCost = Math.Round(dq._desk.computeDeskSizeCost(), 2).ToString("F");
            string sizeCost = Math.Round(computeDeskSizeCost(), 2).ToString("F");

            // Drawer
            //string drawerCost = Math.Round(dq._desk.computeDrawerCost(), 2).ToString("F");
            string drawerCost = Math.Round(computeDrawerCost(), 2).ToString("F");

            // Surface material
            string material = dq._desk.SurfaceMaterial;
            //string materialCost = Math.Round(dq._desk.computeSurfaceMaterialCost(), 2).ToString("F");
            string materialCost = Math.Round(computeSurfaceMaterialCost(), 2).ToString("F");

            // Shipping details
            string shippingMethod = null;
            int rushOptionDays = dq._desk.RushOrderDay;
            if (rushOptionDays != 14)
            {
                shippingMethod = $"Rush - {rushOptionDays} Days";
            }
            else
            {
                shippingMethod = $"Normal - {rushOptionDays} Days";
            }

            //string shippingCost = Math.Round(dq._desk.computeShippingCost(), 2).ToString("F");
            string shippingCost = Math.Round(computeShippingCost(), 2).ToString("F");

            // Total cost
            //string totalCost = Math.Round(dq._desk.computeDeskPrice(), 2).ToString("F");
            string totalCost = Math.Round(computeDeskPrice(), 2).ToString("F");

            string deskQuote = $"{customerName}, {dateCreated}, {totalSurfaceArea}, " +
                        $"{sizeCost}, {drawerCost}, {material}, {materialCost}, {shippingMethod}, " +
                        $"{shippingCost}, {totalCost}";

            string path = @"qoutes.txt";
            // This text is added only once to the file
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    
                    sw.WriteLine(deskQuote);
                }
            }

            // This text is always added, making file longer over time
            // if not deleted
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(deskQuote);
            } 
        } 

        public void displayDeskQuotes()
        {
            foreach(var dq in _dq)
            {
                Console.WriteLine($"Customer Name: {dq._customerName}, Shipping Date: {dq._shippingDate}, Total Desk Price: {computeDeskPrice()}");
            }
        }
    }
}
