﻿namespace Jemus.Domain.Auth
{
    public class AuthenticationRequest
    {
        public string UserName { get; set; }
        public string PbikId { get; set; }
        public string Password { get; set; }
    }
}
