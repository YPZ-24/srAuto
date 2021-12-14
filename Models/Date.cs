using System;
using System.Collections.Generic;

namespace SrAuto.Models
{

    public class Date
    {
        public int DateID  { get; set; }
        public int CarID  { get; set; }
        public int DateReasonID { get; set; }
        public string name { get; set; }
        public DateTime datet { get; set; }
        public string description { get; set; }
        public int status { get; set; }

        public virtual Car Car { get; set; }
        public string carTag { get; set; }
        public virtual List<DateFix> DateFixes { get; set; }

    }

}