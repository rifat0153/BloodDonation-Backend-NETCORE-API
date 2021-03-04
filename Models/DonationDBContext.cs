﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace React_API_2._0.Models
{
    public class DonationDBContext: DbContext
    {
        public DonationDBContext(DbContextOptions<DonationDBContext> options): base(options)
        {

        }

        public DbSet<DCandidate> DCandidates { get; set; }
    }
}
