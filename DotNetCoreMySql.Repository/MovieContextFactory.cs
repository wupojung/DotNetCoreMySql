using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DotNetCoreMySql.Repository
{
    public class MovieContextFactory : IDesignTimeDbContextFactory<MovieContext>
    {
        public MovieContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MovieContext>();
            optionsBuilder.UseMySQL("server=localhost;database=movie;user=movie;password=movie;SslMode=none");
            return new MovieContext(optionsBuilder.Options);
        }
    }
}
