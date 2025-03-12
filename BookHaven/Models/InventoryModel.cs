using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Models
{
    public class InventoryModel
    {
        public int id;
        public int supId;
        public int genreId;
        public string title = "";
        public string isbn = "";
        public string author = "";
        public int qty;
        public decimal costPrice;
        public decimal sellPrice;
        public string supName = "";
        public string genre = "";
    }
}
