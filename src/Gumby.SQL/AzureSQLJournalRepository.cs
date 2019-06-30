using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Gumby.Climb.Journal.Contract;
using Gumby.Climb.Route.Contract;

namespace Gumby.Climb.Database
{
    public class AzureSQLJournalRepository : IJournalRepository, IDisposable
    {
        private SqlConnection _sqlConnection;
        public AzureSQLJournalRepository(string dbConnectionString)
        {
            _sqlConnection = new SqlConnection(dbConnectionString);
            _sqlConnection.Open();
        }

        public async Task<IJournalData> GetAsync(Guid id)
        {
            var text = "SELECT * FROM Climb.Journal WHERE Id=@id";
            return new JournalData()
            {
                Id = id,
                Name = "Test"
            };
        }

        public async Task<Guid> CreateAsync(IJournalData journal)
        {
            return Guid.NewGuid();
        }

        public void Dispose()
        {
            _sqlConnection.Dispose();
        }

        private class JournalData : IJournalData
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public DateTimeOffset OccurredAt { get; set; }
            public Guid RouteId { get; set; }
            public string RouteName { get; set; }
            public ProtectionType ProtectionType { get; set; }
        }
    }
}
