﻿using System;
namespace SchoolProjectClient.Client.Model.User
{
	public class UpdateUser
	{
        public string Id { get; set; }
        public string NickName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public bool IsProfilePrivate { get; set; }
    }
}

