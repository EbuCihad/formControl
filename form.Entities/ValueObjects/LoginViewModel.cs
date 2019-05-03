using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace form.Entities.ValueObject
{
    public class LoginViewModel
    {
        [DisplayName("email"), Required(ErrorMessage ="{0} alanı boş geçilemez.")]
        public string email { get; set; }

        [DisplayName("Şifre"), Required(ErrorMessage = "{0} alanı boş geçilemez."),DataType(DataType.Password)]
        public string sifre { get; set; }
    }
}