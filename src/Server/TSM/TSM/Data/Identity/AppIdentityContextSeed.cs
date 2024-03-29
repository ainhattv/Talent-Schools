﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSM.Common;
using TSM.Data.Entities;

namespace TSM.Data.Identity
{
    public class AppIdentityContextSeed
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager)
        {
            try
            {
                if (userManager.FindByEmailAsync("admin@talentvn.com").Result == null)
                {
                    ApplicationUser admin = new ApplicationUser
                    {
                        Id = "0f07555c-00b6-4be9-ab0f-e75c7617efe4",
                        Email = "admin@talentvn.com",
                        UserName = "admin@talentvn.com",
                        FirstName = "TalentVN",
                        LastName = "Software Development",
                        JwtRole = JwtRole.Admin,
                        EmailConfirmed = true,
                    };

                    await userManager.CreateAsync(admin, "12345678X@x");

                    ApplicationUser user = new ApplicationUser
                    {
                        Id = "8228941f-2b67-4d25-b8ae-e59f8381ebfb",
                        Email = "user@talentvn.com",
                        UserName = "user@talentvn.com",
                        FirstName = "TalentVN",
                        LastName = "Software Development",
                        JwtRole = JwtRole.User,
                        EmailConfirmed = true,
                    };

                    await userManager.CreateAsync(user, "12345678X@x");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
