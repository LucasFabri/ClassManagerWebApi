﻿namespace class_management_web_api.src.Requests.Authentication
{
    public class AuthenticationPostRequest
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
