using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.DTO
{
    public class TaikhoanDTO
    {
        public string Hovaten { get; set; }
        public string Username { get; set; }
        public string HashedPassword { get; set; }
	    public bool Admin { get; set;}
    }
}
