using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLHOLIDAYPARTY.Models
{
    public class Party
    {
        public bool attendence { get; set; }
        public bool date1 { get; set; }
        public bool date2 { get; set; }
        public string firstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }
        public string plusOne { get; set; }
    }
}