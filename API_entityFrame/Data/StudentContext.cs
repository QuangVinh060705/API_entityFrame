//File StudentContext.cs

using Microsoft.AspNetCore.Hosting.Server;
//using System.Data.Entity;//winform
using Microsoft.EntityFrameworkCore;//webapi
using System.Security.Cryptography;
using System;
using API_entityFrame.Models;
using System.Collections.Generic;


namespace API_entityFrame.Data
{
    public class StudentContext : DbContext
    {
        // public StudentContext() : base("name=StudentDBConnectionString") //winform
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) //webapi
        {
        }

        public DbSet<Students> Students { get; set; }

    }
}