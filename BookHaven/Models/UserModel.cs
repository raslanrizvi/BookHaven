using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Models
{
    public class UserModel
    {
        public int id;
        public int storeId;
        public int roleId;
        public string userName;
        public string firstName;
        public string lastName;
        public DateTime dob;
        public int age;
        public string mobile;
        public string email;
        public string password;
        public Boolean isActive;
        public String branch;
        public string role;
    }
}
