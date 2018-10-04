using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class User : BaseModel
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(100)]
        [Required]
        public string LastName { get; set; }
        [StringLength(100)]
        [Required]
        public string Email { get; set; }
        [StringLength(100)]
        [Required]
        public string Password { get; set; }
    }
}
