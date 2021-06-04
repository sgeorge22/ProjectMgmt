﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectMgmt.Models;

namespace ProjectMgmt.Data
{
    public class ProjectMgmtContext : DbContext
    {
        public ProjectMgmtContext (DbContextOptions<ProjectMgmtContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectMgmt.Models.Developer> Developers { get; set; }
        public DbSet<ProjectMgmt.Models.Project> Projects { get; set; }
        public DbSet<ProjectMgmt.Models.Assignment> Assignments { get; set; }
    }
}
