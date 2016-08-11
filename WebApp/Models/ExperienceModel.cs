using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Experience
    {
        private readonly Consultant owner;

        public Experience(Consultant owner)
        {
            this.owner = owner;
        }

        public Consultant Owner { get { return this.owner; } }
        public String Company { set; get; }
        public String Title { set; get; }

        [DataType(DataType.Date)]
        public DateTime Start { set; get; }

        [DataType(DataType.Date)]
        public DateTime End { set; get; }

        public String Description { set; get; }
    }
}