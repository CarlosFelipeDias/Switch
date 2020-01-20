using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Switch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Switch.API
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<SwitchContext>
    {
        public SwitchContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("config.json")
                .Build();
            var builder = new DbContextOptionsBuilder<SwitchContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseMySql("Server=localhost;userid=root;password=1234;database=SwitchDB");
            return new SwitchContext(builder.Options);
        }
    }
}
