using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public enum SurfaceMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine,
    }
    class Desk
    {
        private decimal _width;
        private decimal _depth;
        private int _numberOfDrawer;
        private string _surfaceMaterial;
        private int _rushOrderDay;
        public const decimal MIN_DESK_WIDTH = 24;
        public const decimal MAX_DESK_WIDTH = 96;
        public const decimal MIN_DESK_DEPTH = 12;
        public const decimal MAX_DESK_DEPTH = 48;

        public Desk() { }
        public Desk(decimal width, decimal depth, int numberOfDrawer, string surfaceMaterial, int rushOrderDay)
        {
            _width = width;
            _depth = depth;
            _numberOfDrawer = numberOfDrawer;
            _surfaceMaterial = surfaceMaterial;
            _rushOrderDay = rushOrderDay;
        }

        public decimal Width { get { return this._width; } set { this._width = value; } }
        public decimal Depth { get { return this._depth; } set { this._depth = value; } }
        public int NumberOfDrawer { get { return this._numberOfDrawer; } set { this._numberOfDrawer = value; } }
        public string SurfaceMaterial { get { return this._surfaceMaterial; } set { this._surfaceMaterial = value; } }
        public int RushOrderDay { get { return this._rushOrderDay; } set { this._rushOrderDay = value; } }

    }
}
