using Jemus.Domain.Auth;
using Jemus.Domain.Enum;
using System;
using System.Collections.Generic;

namespace Jemus.Persistence.Seeds
{
    public static class DefaultUser
    {
        public static List<User> IdentityBasicUserList()
        {
            return new List<User>()
            {
                new User
                {
                    Id = Constants.SistemAdminUser,
                    UserName = "sistemAdmin",
                    Email = "sistemAdmin@gmail.com",
                    FirstName = "sistemAdmin",
                    LastName = "sistemAdmin",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    // Password@123
                    PasswordHash = "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==",
                    NormalizedEmail= "SUPERADMIN@GMAIL.COM",
                    NormalizedUserName="SUPERADMIN"
                },
                new User
                {
                    Id = Constants.IlUser,
                    UserName = "iladmin",
                    Email = "iladmin@gmail.com",
                    FirstName = "iladmin",
                    LastName = "User",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    // Password@123
                    PasswordHash = "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==",
                    NormalizedEmail= "BASICUSER@GMAIL.COM",
                    NormalizedUserName="BASICUSER"
                }
               
            };
        }
    }
}
