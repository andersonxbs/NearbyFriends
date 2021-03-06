﻿using System.ComponentModel.DataAnnotations;

namespace NearbyFriends.Api.Models.Auth
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
