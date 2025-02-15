﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coffeeventureAPI.Dtos.Login
{
    public class LoginRequestDto
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberLogin { get; set; }
        public string ReturnUrl { get; set; }
    }
}
