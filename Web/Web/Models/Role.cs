using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web.Models
{
    [Table("Roles")]
    public class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}