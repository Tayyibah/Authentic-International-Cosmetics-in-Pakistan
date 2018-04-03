using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;
using Entities;
using Entities.DBEntities;

namespace DAL
{
    public class PRMDataContext : DbContext
    {
        private static readonly string ConnectionString = DatabaseHelper.Instance.MainDBConnectionString;

        public DbSet<Users> SampleStudents { get; set; }
        public DbSet<EmailRequest> EmailRequests { get; set; }

        public PRMDataContext()
            : base(ConnectionString)
        {
            // We'll eager load entities whenever required.
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = 3000;
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}



