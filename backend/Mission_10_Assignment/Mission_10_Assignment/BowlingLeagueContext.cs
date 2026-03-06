using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Mission_10_Assignment;

public partial class BowlingLeagueContext : DbContext
{
    public BowlingLeagueContext()
    {
    }

    public BowlingLeagueContext(DbContextOptions<BowlingLeagueContext> options)
        : base(options)
    {
    }

    public DbSet<Bowler> Bowlers { get; set; }

    public DbSet<Team> Teams { get; set; }

}
