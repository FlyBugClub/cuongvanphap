using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace VanPhap.Models
{
    internal class Account
    {
        public Account()
        {

        }

        public String Acc { get; set; }
        public String Pass { get; set; }
        public String PasswordChar { get; set; }
    }
}
