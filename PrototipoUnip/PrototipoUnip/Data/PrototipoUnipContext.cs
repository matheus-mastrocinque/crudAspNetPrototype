using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PrototipoUnip.Data
{
    public class PrototipoUnipContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PrototipoUnipContext() : base("name=PrototipoUnipContext")
        {
        }

        public System.Data.Entity.DbSet<PrototipoUnip.Models.pessoa> pessoas { get; set; }
    }
}
