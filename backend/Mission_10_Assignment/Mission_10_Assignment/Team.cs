using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mission_10_Assignment;

[Index("TeamId", Name = "TeamID", IsUnique = true)]
public partial class Team
{
    [Key]
    [Column("TeamID", TypeName = "INT")]
    public int TeamId { get; set; }

    [Column(TypeName = "nvarchar (50)")]
    public string TeamName { get; set; } = null!;

    [Column("CaptainID", TypeName = "INT")]
    public int? CaptainId { get; set; }

    [InverseProperty("Team")]
    public virtual ICollection<Bowler> Bowlers { get; set; } = new List<Bowler>();
}
