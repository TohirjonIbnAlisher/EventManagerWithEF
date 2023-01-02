
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EventManagement.Broker
{
    public partial class EventManagementBroker : DbContext, IEventManagementBroker
    {
        private readonly string connectionString = @"Server = (localdb)\mssqllocaldb;
            Database = EventManagement;Trusted_Connection=True;
                MultipleActiveResultSets=true;TrustServerCertificate=True";
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly());
        }


    }
}
