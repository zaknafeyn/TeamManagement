using System;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace TeamManager.DataAccess
{
    public class TeamManagerDbConfiguration : DbConfiguration
    {
        public TeamManagerDbConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy(1, TimeSpan.FromSeconds(30)));
        }
    }
}