﻿namespace Core.Domain
{
    public class Owner : EntityBase
    {
        public string FullName { get; set; }
        public string JobTitle { get; set; }
        public string Avatar { get; set; }
        public Address Address { get; set; }
    }
}