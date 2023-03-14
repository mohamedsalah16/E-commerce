using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Bl.Models
{
    public class DepartmentVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name Required")]
        [StringLength(50,ErrorMessage ="Max length")]
        [MinLength(3,ErrorMessage ="Min Length")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Code Required")]
        public string Code { get; set; }
    }
}

