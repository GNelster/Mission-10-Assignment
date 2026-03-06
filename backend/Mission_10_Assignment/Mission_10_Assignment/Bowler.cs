using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mission_10_Assignment;

[Index("BowlerLastName", Name = "BowlerLastName")]
[Index("TeamId", Name = "BowlersTeamID")]
public partial class Bowler
{
    [Key]
    [Column("BowlerID", TypeName = "INT")]
    public int BowlerId { get; set; }

    [Column(TypeName = "nvarchar (50)")]
    public string? BowlerLastName { get; set; }

    [Column(TypeName = "nvarchar (50)")]
    public string? BowlerFirstName { get; set; }

    [Column(TypeName = "nvarchar (1)")]
    public string? BowlerMiddleInit { get; set; }

    [Column(TypeName = "nvarchar (50)")]
    public string? BowlerAddress { get; set; }

    [Column(TypeName = "nvarchar (50)")]
    public string? BowlerCity { get; set; }

    [Column(TypeName = "nvarchar (2)")]
    public string? BowlerState { get; set; }

    [Column(TypeName = "nvarchar (10)")]
    public string? BowlerZip { get; set; }

    [Column(TypeName = "nvarchar (14)")]
    public string? BowlerPhoneNumber { get; set; }

    [Column("TeamID", TypeName = "INT")]
    public int? TeamId { get; set; }
    
    [ForeignKey("TeamId")]
    [InverseProperty("Bowlers")]
    public virtual Team? Team { get; set; }
}
