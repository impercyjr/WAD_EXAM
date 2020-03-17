using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WAD_Exam.Models
{
    public class MyDbContext :DbContext
    {
        public MyDbContext()

            : base("MyConncectionString")
        {
        }

        public System.Data.Entity.DbSet<nhanvien> Nhanviens { get; set; }

        public System.Data.Entity.DbSet<WAD_Exam.Models.Category> Categories { get; set; }
    }
}