﻿using System.ComponentModel.DataAnnotations;

namespace Fotuber.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string password { get; set; }
    }
}
