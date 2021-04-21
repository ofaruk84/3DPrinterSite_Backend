<<<<<<< HEAD
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
=======
using Business.Abstract;
using Business.Concrete;
using Core.DependencyResolver;
using Core.Extensions;
using Core.Utilities.IoC;
using Core.Utilities.Security.Encryption;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
>>>>>>> 7d9f7ea068a475b3012ae3992a2b42333b93d63f
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
<<<<<<< HEAD
=======
using Microsoft.IdentityModel.Tokens;
>>>>>>> 7d9f7ea068a475b3012ae3992a2b42333b93d63f
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
=======
>>>>>>> 7d9f7ea068a475b3012ae3992a2b42333b93d63f

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
<<<<<<< HEAD
            services.AddSingleton<IOrderService, OrderManager>();
            services.AddSingleton<IOrderDal, EfOrderDal>();
            services.AddSingleton<IOrderPositionService, OrderPositionManager>();
            services.AddSingleton<IOrderPositionDal, EfOrderPositionDal>();
=======
            //services.AddSingleton<IUserService,UserManager>();
            //services.AddSingleton<IUserDal, EfUserDal>();

            //services.AddSingleton<ISellerService, SellerManager>();
            //services.AddSingleton<ISellerDal, EfSellerDal>();

            

            var tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = tokenOptions.Issuer,
                        ValidAudience = tokenOptions.Audience,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
                    };
                });

            services.AddDependencyResolvers(new ICoreModule[] {
               new CoreModule() 
            });
>>>>>>> 7d9f7ea068a475b3012ae3992a2b42333b93d63f
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

<<<<<<< HEAD
=======
            app.UseAuthentication();

>>>>>>> 7d9f7ea068a475b3012ae3992a2b42333b93d63f
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
