using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form.Entities
{
    [Table("myforms")]
    public class myform
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

         
        public string description { get; set; }

        [Required]
        public DateTime createdAt { get; set; }

        [Required]
        public int createdBy { get; set; }

        public List<field> fields { get; set; }

    }
}
