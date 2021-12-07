using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace amarin.Models
{
    public class Class
    {
        [Key]
        public string ClassName { get; set; }
        public List<Student> students { get; set; }
    }
}