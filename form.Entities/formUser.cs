using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form.Entities
{
    [Table("formUsers")]
    public class formUser
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public string ad { get; set; }

        [Required]
        public string soyad { get; set; }

        public int yas { get; set; }

        [Required]
        public string sifre { get; set; }

        [Required]
        public bool adminMi { get; set; }

        public string email { get; set; }

        public virtual List<myform> forms { get; set; }
    }
}
