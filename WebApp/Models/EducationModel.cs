using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Education
    {
        public String Institute { set; get; }
        public String Degree { set; get; }

        [DataType(DataType.Date)]
        public DateTime Year { set; get; }        
    }
}