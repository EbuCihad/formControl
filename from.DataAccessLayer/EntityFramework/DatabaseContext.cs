using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using form.Entities;


namespace form.DataAccessLayer.EntityFramework
{
    public class DatabaseContext:DbContext
    {
        public DbSet<formUser> formUsers { get; set; }
        public DbSet<myform> forms { get; set; }

        public DatabaseContext()
        {
            Database.SetInitializer(new Initializer());
        }

    }
}
