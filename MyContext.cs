using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Scoliosis.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Scoliosis
{
    public class MyContext : IdentityDbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<UsersModel> Users { get; set; }

        public DbSet<PersonalInfoModel> PersonalInfo { get; set; }

        public DbSet<PersonalInfoLogViewModel> PersonalInfoLog { get; set; }

        public DbSet<VisitsModel> Visits { get; set; }

        public DbSet<ActionLogViewModel> ActionLog { get; set; }

        public DbSet<InitAssessViewModel> InitAssess { get; set; }

        public DbSet<ErrorLogViewModel> ErrorLog { get; set; }

        public DbSet<OperativeDataViewModel> OperativeData { get; set; }

        public DbSet<VisitsLogViewModel> VisitsLog { get; set; }

        public DbSet<UsersSupplementViewModel> UsersSupplement { get; set; }

        public DbSet<UploadDocumentViewModel> UploadDocument { get; set; }

        public DbSet<TemplateRemarksContentViewModel> TemplateRemarksContent { get; set; }

        public DbSet<TemplateRemarksHeaderViewModel> TemplateRemarksHeader { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<VisitsModel>().HasKey(t => new { t.SCN, t.DOC });
            builder.Entity<OperativeDataViewModel>().HasKey(t => new { t.SCN, t.RecordID });
            builder.Entity<POVisitModel>().HasKey(t => new { t.SCN, t.DOC });
        }

        public DbSet<ImageModel> ImageMeasurement { get; set; }
        public DbSet<POVisitModel> POVisit { get; set; }
        public DbSet<POImportModel> POImport { get; set; }
        public DbSet<POConfigModel> POConfig { get; set; }
        public DbSet<POEvaluationModel> POEvaluation { get; set; }
        public DbSet<PhysioModel> Physio { get; set; }
        public DbSet<PODOCModel> PODOC { get; set; }
    }
}
