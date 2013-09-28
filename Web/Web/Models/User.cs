using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web.Models
{
    [Table("tblUsers")]
    public class User
    {
        [Key]
        public int Userid { get; set; }

        [StringLength(20)]
        public string Username { get; set; }

        [StringLength(32)]
        public string Password { get; set; }

        [StringLength(30)]
        public string Realname { get; set; }

        [StringLength(20)]
        public string Tel { get; set; }

        [StringLength(70)]
        public string Email { get; set; }
    }
}