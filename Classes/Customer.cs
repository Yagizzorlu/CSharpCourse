using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }   //İsmin başına bir şey eklemek istersek getter setter içine süslü parantez açıp tanımlayabiliriz.
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
