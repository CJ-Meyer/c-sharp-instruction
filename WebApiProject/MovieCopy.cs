using System;
using System.Collections.Generic;

namespace WebApiProject;

public partial class MovieCopy
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int Year { get; set; }

    public string Rating { get; set; } = null!;

    public string Director { get; set; } = null!;
}
