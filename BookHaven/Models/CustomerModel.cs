using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Models
{
    public class CustomerModel
    {
        public int id;
        public int StoreID;
        public string name = "";
        public string nic = "";
        public string address = "";
        public string mobile = "";
        public string email = "";
        public Boolean isActive;

    }
}
