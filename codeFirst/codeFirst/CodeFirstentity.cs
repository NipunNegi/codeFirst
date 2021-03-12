using codeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace codeFirst
{
    public class CodeFirstentity:DbContext
    {
        public DbSet<student> student { get; set; }
    }
}