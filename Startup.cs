using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Scoliosis.Repositories;
using Scoliosis.Models;




namespace Scoliosis
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddCors();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<MyContext>(options =>

            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IRepository<UsersModel, string>, UserRepository>();

            services.AddScoped<IRepository<PersonalInfoModel, string>, PersonalInfoRepository>();

            services.AddScoped<IRepository<PersonalInfoLogViewModel, int>, PersonalInfoLogRepository>();

            //services.AddScoped<IRepository<VisitsModel, string>, VisitRepository>();

            services.AddScoped<IRepository<ActionLogViewModel, int>, ActionLogRepository>();

            services.AddScoped<IRepository<InitAssessViewModel, string>, InitAssessRepository>();

            services.AddScoped<IRepository<ErrorLogViewModel, int>, ErrorLogRepository>();

            services.AddScoped<IRepository<OperativeDataViewModel, string>, OperativeDataRepository>();

            services.AddScoped<IRepository<VisitsLogViewModel, int>, VisitsLogRepository>();

            services.AddScoped<IRepositoryVisit<VisitsModel, string>, VisitRepository>();

            services.AddScoped<IRepository<UsersSupplementViewModel, string>, UsersSupplementRepository>();

            services.AddScoped<IRepository<ImageModel, string>, ImageRepository>();

            services.AddScoped<IRepository<UploadDocumentViewModel, long>, UploadDocumentRepository>();

            services.AddScoped<IRepository<TemplateRemarksContentViewModel, int>, TemplateRemarksContentRepository>();

            services.AddScoped<IRepository<TemplateRemarksHeaderViewModel, int>, TemplateRemarksHeaderRepository>();
            services.AddScoped<IRepositoryPOVisit<POVisitModel, string>, POVisitRepository>();
            services.AddScoped<IRepositoryPOImport<POImportModel, string>, POImportRepository>();
            services.AddScoped<IRepository<POConfigModel, string>, POConfigRepository>();
            services.AddScoped<IRepositoryPOEvaluation<POEvaluationModel, string>, POEvaluationRepository>();
            services.AddScoped<IRepositoryDOC<PhysioModel, string>, PhysioRepository>();
            services.AddScoped<IRepositoryPODOC<PODOCModel, string>, PODOCRepository>();

            services.AddDefaultIdentity<IdentityUser>()
              .AddRoles<IdentityRole>()
              .AddEntityFrameworkStores<MyContext>();

            services.AddAuthorization(options => {
                options.AddPolicy("readonlypolicy",
                    builder => builder.RequireRole("Admin", "Manager", "Clerk"));
                options.AddPolicy("writepolicy",
                    builder => builder.RequireRole("Admin", "Manager"));
            });
            services.AddAuthentication()
              .AddCookie(option =>
              {
                  option.Cookie.Expiration = TimeSpan.FromHours(2);
              });
            services.AddSession(options =>
            {
                // Set a short timeout for easy testing.
                options.IdleTimeout = TimeSpan.FromSeconds(100000);
                options.Cookie.HttpOnly = true;
                // Make the session cookie essential
                options.Cookie.IsEssential = true;
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, MyContext dbContext)
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

            app.UseCors(
               options =>
               options
               .AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader()
               .AllowCredentials()
               );

            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Login}/{action=Index}/{id?}");
            });

            dbContext.Database.EnsureCreated();
            app.UseMvcWithDefaultRoute();



        }
    }
}
