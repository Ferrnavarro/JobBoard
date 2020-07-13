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
    }
}
