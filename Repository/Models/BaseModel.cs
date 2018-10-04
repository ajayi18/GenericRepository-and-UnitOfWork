using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class BaseModel
    {
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
