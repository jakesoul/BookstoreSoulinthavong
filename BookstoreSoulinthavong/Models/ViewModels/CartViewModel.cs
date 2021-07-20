using BookstoreSoulinthavong.Models.ExtensionMethods;
using BookstoreSoulinthavong.Models.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreSoulinthavong.Models.ViewModels
{
    public class CartViewModel
    {
        public IEnumerable<CartItem> List { get; set; }
        public double Subtotal { get; set; }
        public RouteDictionary BookGridRoute { get; set; }
    }
}
