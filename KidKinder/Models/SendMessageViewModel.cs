using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidKinder.Models
{
    public class SendMessageViewModel
    {
        [Required(ErrorMessage = "Lütfen adinizi bos geçmeyiniz")]
        [StringLength(30, ErrorMessage = "Lütfen en fazla 30 karakter veri girisi yapiniz!")]
        public string NameSurname { get; set; }

        [Required(ErrorMessage = "Lütfen mail adresinizi bos geçmeyiniz")]
        [StringLength(50, ErrorMessage = "Lütfen en fazla 50 karakter veri girisi yapiniz!")]
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir mail adresi giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen konu kismini bos geçmeyiniz")]
        [StringLength(50, ErrorMessage = "Lütfen en fazla 50 karakter veri girisi yapiniz!")]
        [MinLength(5, ErrorMessage = "Lütfen en az 5 karakter veri girisi yapiniz")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Lütfen mesaj kismini bos geçmeyiniz")]
        [StringLength(1000, ErrorMessage = "Lütfen daha az karakter veri girisi yapiniz!")]
        public string Message { get; set; }
    }
}