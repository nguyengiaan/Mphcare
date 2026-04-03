using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Identity.Mphcare.Data;
using Identity.Mphcare.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Identity.Mphcare
{
    public static class IdentityServicesRegistration
    {
        public static IServiceCollection ConfigureIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {
            // ... cấu hình Jwt và DbContext ...

            services.AddDbContext<AppDbContext>(options =>
           options.UseSqlServer(configuration.GetConnectionString("MphcareIdentityConnectionString"),
           b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));
            // Đây là nơi đăng ký Identity
            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
      
            // ... đăng ký các dịch vụ AuthService, UserService ...

            return services;
        }
    }
}
