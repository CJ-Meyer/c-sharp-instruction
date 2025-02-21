using System;
using System.Collections.Generic;

namespace WebApiProject;

public partial class Actor
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public DateOnly BirthDate { get; set; }

    public virtual ICollection<Credit> Credits { get; set; } = new List<Credit>();
}
