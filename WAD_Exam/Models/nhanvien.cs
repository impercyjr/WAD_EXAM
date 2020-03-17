using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace WAD_Exam.Models
{
    public class nhanvien
    {
        
        public String EmployeeID{ get; set; }
        [Key]
        public String Name { get; set; }
        [DisplayName("Full name")]
        [Required(ErrorMessage = "Vui long nhap full name.")]
        public String Department { get; set; }
        public double Salary { get; set; }
        [ForeignKey("Category")]
        public string CateroryID { get; set; }
        public virtual Category Category { get; set; }
    }
}