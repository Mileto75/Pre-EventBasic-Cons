using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.eventBasic.Core
{
    public class StockEventArgs : EventArgs
    {
        public int ItemCount { get; set; }
        public string Product { get; set; }
    }
}
