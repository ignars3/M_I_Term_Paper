﻿using System;

namespace HygieiaData.Models
{
    public class User : IModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
