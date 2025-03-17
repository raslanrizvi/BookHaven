using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Models
{
    public class OrderItemsModel
    {
        public int id;
        public int ordItmId;
        public int ordId;
        public int bookId;
        public int qty;
        public decimal price;
        public decimal tot;
        public string title;
    }
}
