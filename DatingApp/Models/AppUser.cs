using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Models
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        public string UserName { get; set; }
    }
}
