using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

/*
 * Startup.cs主要由ConfigureServices及Configure組成：
 */

namespace IronmenMvcWeb
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
        /* 設定網站所需的服務
         * 執行生命週期在Configure之前
         * 預設呼叫的方法Pattern為Add{Service}
         * 可使用IServiceCollection加入所需的服務
         * 註冊DI服務的地方
         */
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        /* 將每個服務以中介軟體方式註冊，在架構調整上增加許多彈性
         * 中介軟體(Middleware)註冊的順序會影響請求事件發生的結果
         * 
         * Middleware中文翻譯成「中介軟體」，
         * 是指從發出請求(Request)之後，
         * 到接收回應(Response)這段來回的途徑上，
         * 用來處理特定用途的程式。
         */
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"); // 路由規則: 由Index開始，可以改成About等等
            });


            /*
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("middleware - use test before map check -  request in\n");
                var condition = true;
                if (condition)
                {
                    await next();
                }
                await context.Response.WriteAsync("middleware - use test before map check -  response out\n");
            });

            app.Map("/map1", applicationBuilder =>
            {
                applicationBuilder.Use(async (context, next) =>
                {
                    await context.Response.WriteAsync("middleware -  use test in map1 - request in\n");
                    await next.Invoke();
                    await context.Response.WriteAsync("middleware -  use test in map1 - response out\n");
                });

                applicationBuilder.Run(async context =>
                {
                    await context.Response.WriteAsync("middleware - run test in map1\n");
                });
            });

            app.Map("/map2", applicationBuilder =>
            {
                applicationBuilder.Run(async context =>
                {
                    await context.Response.WriteAsync("middleware - run test only in map2\n");
                });
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("middleware - use test after map check - request in\n");
                var condition = true;
                if (condition)
                {
                    await next();
                }
                await context.Response.WriteAsync("middleware - use test after map check - response out\n");
            });

            app.Run(async context =>
            {
                await context.Response.WriteAsync("middleware - run test in the end\n");
            });
            */
        }
    }

}
