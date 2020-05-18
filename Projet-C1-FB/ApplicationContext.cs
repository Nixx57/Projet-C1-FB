using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_C1_FB
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Espece> ListEspeces { get; set; }
        public DbSet<Animal> ListAnimaux { get; set; }
    }
}
