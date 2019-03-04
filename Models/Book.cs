using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetanitASP_NET_MVC5.Models
{
    public class Book
    {
        private int stock;

        

        //Book ID
        public int Id { get; set; }
        //Book Name
        public string Name { get; set; }
        //Book author
        public string Author { get; set;}
        //price
        public int Price { get; set; }
        public int InStock { get; set; } // number of books which left in stock


    }
}