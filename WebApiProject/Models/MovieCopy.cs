using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApiProject.Models;

[Keyless]
[Table("MovieCopy")]
public partial class MovieCopy
{
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(75)]
    [Unicode(false)]
    public string Title { get; set; } = null!;

    public int Year { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string Rating { get; set; } = null!;

    [StringLength(75)]
    [Unicode(false)]
    public string Director { get; set; } = null!;
}
