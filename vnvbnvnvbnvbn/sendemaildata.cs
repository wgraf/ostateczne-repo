using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace vnvbnvnvbnvbn
{

    //enable migration
    //add migration
    //update database

    public class sendemaildata
    {
       // private object parser;

        [Key]
        public long id { get; set; }
        public String url { get; set; }
        public String address { get; set; }
        public String text { get; set; }
        public String name { get; set; }

        public override string ToString()
        {
            string aa = "Wykonaj: " + name + " ze strony " + url + " i wyslij na " + address; 
            return aa;
        }
    }


}
