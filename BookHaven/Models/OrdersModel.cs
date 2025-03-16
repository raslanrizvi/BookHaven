using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Models
{
    public class OrdersModel
    {
        public int ordId;
        public int empId;
        public int custId;
        public string ordType;
        public string pytMethod;
        public decimal tot;
        public decimal payAmt;
        public string status;
        public DateTime cretedAt;

    }
}
