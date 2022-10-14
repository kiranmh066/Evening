using BookShowBLL;
using BookShowBLL.Services;
using BookShowDAL;
using BookShowDAL.Repost;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAppCoreAPI
{
    public class Startup//This is middleware(startup.cs)
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionstr = Configuration.GetConnectionString("sqlConnection");
            services.AddDbContext<BookShowDbContext>(Options=>Options.UseSqlServer(connectionstr));

            services.AddTransient<MovieService,MovieService>();//adding services
            services.AddTransient<IMovieOperationRepository,MovieOperationRepository>();

            services.AddTransient<TheatreService, TheatreService>();
            services.AddTransient<ITheatreOpearationRepository, TheatreOpearationRepository>();

            services.AddTransient<ShowTimingService, ShowTimingService>();
            services.AddTransient<IShowTimingOperationRepository,ShowTimingOperationRepository>();

            services.AddTransient<UserService, UserService>();
            services.AddTransient<IUserRepository, UserRepository>();

            services.AddTransient<BookTicketService, BookTicketService>();
            services.AddTransient<IBookTicketRepository, BookTicketRepository>();

            services.AddControllers();
            services.AddSwaggerGen();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "MovieAPI",
                    Description = "Movie Management API System"
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //pipeline means 
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)//URL validating here
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();//Inbuilt middleware
            }

            app.UseRouting();

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "MovieAPI"));

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
