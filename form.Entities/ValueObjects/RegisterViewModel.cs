using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace form.Entities.ValueObject
{
    public class RegisterViewModel
    {
        [DisplayName("Kullanıcı adı"), Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string ad { get; set; }

        [DisplayName("Kullanıcı soyadı"), Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string soyad { get; set; }

        [DisplayName("Kullanıcı yası"), Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public int yas { get; set; }

        [DisplayName("Şifre"), Required(ErrorMessage = "{0} alanı boş geçilemez."), DataType(DataType.Password)]
        public string sifre { get; set; }

        [DisplayName("Şifre"), Required(ErrorMessage = "{0} alanı boş geçilemez."), DataType(DataType.Password), Compare("sifre",ErrorMessage ="{0} ile {1} uyumlu olmalıdır")]
        public string resifre { get; set; }

        [DisplayName("Kullanıcı email"), Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string email { get; set; }
    }
}