﻿namespace ECommerce.Services.AuthAPI.Models.Dtos
{
    public class LoginResponseDTO
    {
        public UserDTO User { get; set; }
        public string Token { get; set; }
    }
}
