using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class TestDataInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var roles = new List<Role>{
                new Role{Name="Quản trị viên"},
                new Role{Name="Quản lí"},
                new Role{Name="Khách hàng"}
            };
            roles.ForEach(r => context.Roles.Add((r)));
            context.SaveChanges();
        }
    }
}