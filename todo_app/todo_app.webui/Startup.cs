using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using todo_app.business.Abstract;
using todo_app.business.Concrete;
using todo_app.data.Abstract;
using todo_app.data.Concrete.EfCore;


namespace todo_app.webui{





            public class Startup
                {

                    public void ConfigureServices(IServiceCollection services)
                    {
                        services.AddScoped<ITaskRepository,EfCoreTaskRepository>();
                        services.AddScoped<ITaskService,TaskManager>();
                        services.AddControllersWithViews();
                    }


                    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
                    {

                        if(env.IsDevelopment())
                        {
                            SeedDatabase.Seed();
                            app.UseDeveloperExceptionPage();

                        }

                        app.UseRouting();

                        app.UseEndpoints(endpoints =>
                        {

                            endpoints.MapControllerRoute(

                                name: "default",
                                pattern: "{controller=Home}/{action?}"
                            );

                        
                        });

                    }

                }
}