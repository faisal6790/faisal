using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _150_Faisal_DBForm.Models
{
    public class Contact
    {
        public int Id { get; set; }
     
        public string firstname { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
       
        public string description { get; set; }
    
       

    }
}
