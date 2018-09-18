﻿using System;
using FinalApp.Models;
using FinalApp.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(FinalApp.Areas.Identity.IdentityHostingStartup))]
namespace FinalApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MyIdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("FinalApp")));

                //services.AddDefaultIdentity<IdentityUser>(config =>
                //{
                //    config.SignIn.RequireConfirmedEmail = false;
                //})
                services.AddIdentity<IdentityUser, IdentityRole>(config =>
                    {
                        config.SignIn.RequireConfirmedEmail = true;
                    })
                //.AddRoles<IdentityRole>()
                    .AddDefaultUI()
                    .AddDefaultTokenProviders()
                    .AddEntityFrameworkStores<MyIdentityContext>();
            });
        }
    }
}