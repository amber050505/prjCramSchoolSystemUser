using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using prjCramSchoolSystemUser.Data;
using prjCramSchoolSystemUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjCramSchoolSystemUser
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
            #region Identity Database configuration
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultUI()
                .AddDefaultTokenProviders();
            #endregion
            // ���B����razor pages�ͦ����ҭ���
            services.AddRazorPages();

            services.AddDbContext<CramSchoolDBContext>(options =>
                options.UseLazyLoadingProxies().UseSqlServer(
                    Configuration.GetConnectionString("CramSchoolDB")));


            services.AddDatabaseDeveloperPageExceptionFilter();

            // �[�Jsession�A��
            services.AddSession();

            // ���B�[�J�������ҪA��
            services.Configure<IdentityOptions>(options =>
            {
                // �K�X�]�w
                // �ݭn�Ʀr
                options.Password.RequireDigit = true;
                // �ݭn�p�g
                options.Password.RequireLowercase = true;
                // �ݭn�D�^�Ʀr
                options.Password.RequireNonAlphanumeric = true;
                // �ݭn�j�g
                options.Password.RequireUppercase = true;
                // �ݭn�K�X���פj��6
                options.Password.RequiredLength = 6;
                // �ݭn�S��r��
                options.Password.RequiredUniqueChars = 1;

                // ��w�]�w
                // �w�]�K�X��w�G������
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                // �̤j�i���զ���
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // ���\�ϥΪ̦W�٬��G
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;
            });

            // �[�J�H�c���ҪA��
            services.AddTransient<IEmailSender, SendEmail>();

            // �[�Jcookie�A��
            services.ConfigureApplicationCookie(options =>
            {
                //  �]�whttpOnly�ݩʡA�T��JavaScript�����s��cookie�A�קK�L�H�s�αb���C
                options.Cookie.HttpOnly = true;
                // �]�wCookie���Ĵ����G������
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

                // �n�J���|
                options.LoginPath = "/Identity/Account/Login";
                // �]�w��ڵ��s�����|
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                // �]�wCookie�O�_�|�L��
                options.SlidingExpiration = true;
            });

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            //�[�Jsession
            app.UseSession();


            // �Ұ����ҪA��
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
