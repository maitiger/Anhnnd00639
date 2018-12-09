using Recources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bai2.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        [Required ]
        [StringLength(50,MinimumLength =1)]
        [Display(Name ="FirtName",ResourceType = typeof(Resources))]
        public string FirtName { get; set; }
        [Required]
        [Display(Name ="LastName", ResourceType = typeof(Resources))]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email", ResourceType = typeof(Resources))]

        public string Email { get; set; }
        [Required]
        [Display(Name = "Age", ResourceType = typeof(Resources))]

        public int Age { get; set; }
    }
}
