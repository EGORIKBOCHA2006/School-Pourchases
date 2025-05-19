using Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Pourchases.Models
{
    public class User
    {
        public string SchoolName { get; set; }
        public int UserId { get; set; }
        public string TypeUser { get; set; }
        public string UserName { get; set; }
        public int TypeSchool { get; set; }
        
        public Dictionary<Product, int> Cart = new Dictionary<Product, int>();
        public Dictionary<Product, int> RequiredCart = new Dictionary<Product, int>();

        public User(int userId, string userName, string schoolName, int typeSchool, string typeUser )
        {
            UserId = userId;
            UserName = userName;
            SchoolName = schoolName;
            TypeSchool = typeSchool;
            TypeUser = typeUser;
        }
    }
}
