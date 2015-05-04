using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectZip.Models
{
    public class CollegeContext: DbContext
    {
        public DbSet<College> College { get; set; }

    }
}
