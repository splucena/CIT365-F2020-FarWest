using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class PublicDesk
    {
        public string _pCustomerName { get; set; }
        public DateTime _pDateCreated { get; set; }
        public decimal _pWidth { get; set; }
        public decimal _pDepth { get; set; }
        //string totalSurfaceArea = $"{Math.Round(dq._desk.computeSurfaceArea(width, depth), 2)}";
        public string _pTotalSurfaceArea { get; set; }

        //string sizeCost = Math.Round(dq._desk.computeDeskSizeCost(), 2).ToString("F");
        public string _pSizeCost { get; set; }

        // Drawer
        //string drawerCost = Math.Round(dq._desk.computeDrawerCost(), 2).ToString("F");
        public string _pDrawerCost { get; set; }

        // Surface material
        public string _pMaterial { get; set; }
        //string materialCost = Math.Round(dq._desk.computeSurfaceMaterialCost(), 2).ToString("F");
        public string _pMaterialCost { get; set; }

        // Shipping details
        public int _pRushOptionDays { get; set; }

//string shippingCost = Math.Round(dq._desk.computeShippingCost(), 2).ToString("F");
        public string _pShippingCost { get; set; }

        // Total cost
        //string totalCost = Math.Round(dq._desk.computeDeskPrice(), 2).ToString("F");
        public string _pTotalCost { get; set; }
    }
}
