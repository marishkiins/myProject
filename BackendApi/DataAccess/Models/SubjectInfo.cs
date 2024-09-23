using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class SubjectInfo
{
    public int Id { get; set; }

    public int SubjectId { get; set; }

    public int TeacherId { get; set; }

    public string? Classroom { get; set; }

    public virtual Subject Subject { get; set; } = null!;

    public virtual Teacher Teacher { get; set; } = null!;
}
