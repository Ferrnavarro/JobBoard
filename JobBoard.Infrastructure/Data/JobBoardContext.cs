using JobBoard.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobBoard.Infrastructure.Data
{
    public class JobBoardContext: DbContext
    {
        public JobBoardContext(DbContextOptions<JobBoardContext> options): base(options)
        {

        }

        public DbSet<Job> Jobs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Job>().HasData(

                new Job()
                {
                    Id = Guid.Parse("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                    Title = "Python Developer",
                    Description = "We are looking for a Python Web Developer responsible for managing the interchange of data between the server and the users.",
                    CreatedAt = DateTime.Now,
                    ExpiresAt = DateTime.Now.AddDays(15)
                },
                new Job()
                {
                    Id = Guid.Parse("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                    Title = "React Native Developer",
                    Description = "Architect, build and maintain excellent React Native applications with clean code.",
                    CreatedAt = DateTime.Now,
                    ExpiresAt = DateTime.Now.AddDays(15)
                },
                new Job()
                {
                    Id = Guid.Parse("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                    Title = "UX Designer",
                    Description = "Our enterprise-level client is looking for a junior to mid-level Product Designer to assist with the launch of several pilots.",
                    CreatedAt = DateTime.Now,
                    ExpiresAt = DateTime.Now.AddDays(15)
                },
                new Job()
                {
                    Id = Guid.Parse("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                    Title = "DevOps engineer",
                    Description = "Analyze current technology utilized within the company and develop steps and processes to improve and expand upon them.",
                    CreatedAt = DateTime.Now,
                    ExpiresAt = DateTime.Now.AddDays(15)
                }

                );
            

            base.OnModelCreating(modelBuilder);
        }


    }

}
