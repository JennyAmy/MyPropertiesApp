﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingAPI.Dtos.UserDto
{
    public class LoginResponseDto
    {
        public string UserName { get; set; }
        public string Token { get; set; }

    }
}
