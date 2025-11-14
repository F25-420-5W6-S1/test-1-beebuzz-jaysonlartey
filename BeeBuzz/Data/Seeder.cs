using BeeBuzz.Data;
using BeeBuzz.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace DutchTreat.Data
{
    public class Seeder
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _hosting;

        public Seeder(ApplicationDbContext context, IWebHostEnvironment hosting)
        {
            _db = context;
            _hosting = hosting;  // will be used to find the full path of the project
        }

        public void Seed()
        {
            _db.Database.EnsureCreated();

            if (!_db.Users.Any())
            {
                var file = Path.Combine(_hosting.ContentRootPath, "Data/adminuser.json");
                var json = File.ReadAllText(file);

                var users = JsonSerializer.Deserialize<IEnumerable<ApplicationUser>>(json);


                // Create a sample order
                var user = new ApplicationUser()
                {
                    UserId = 1,
                    Beehives = [],
                    OrganizationId = 1,
                    Role = "Admin"
                };

                _db.Users.Add(user);

                _db.SaveChanges();  
            }
        }
    }
}
