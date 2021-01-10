using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACADEMY.Application.ViewModels.System
{
    public class AuthVm
    {
        public Guid Id { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string AccessToken { get; set; }

        public string Roles { get; set; }

        [JsonIgnore] public string RefreshToken { get; set; }
    }
}