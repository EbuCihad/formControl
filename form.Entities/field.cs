using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form.Entities
{
    [Table("field")]
    public class field
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public bool required { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string dataType { get; set; }
    }
}
