using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PrototipoUnip.Models
{
    public class contexto: DbContext
    { 
        public DbSet<pessoa> Pessoas { get; set; }
    }
}