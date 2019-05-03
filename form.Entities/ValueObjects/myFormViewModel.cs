using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form.Entities.ValueObjects
{
    public class myFormViewModel
    {
        [DisplayName("form adı "), Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string name { get; set; }

        [DisplayName("fdescription "), Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string description { get; set; }

        [ Required]
        public int createdBy { get; set; }
    }
}
