using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using THAITHIHOANGTHO_2080601444.Models;

namespace THAITHIHOANGTHO_2080601444.ViewModels
{
    public class CourseViewModel
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime() { 
            return DateTime.Parse(string.Format("{0} {1}",Date,Time));
        }
    }
}