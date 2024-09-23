using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Subject
{
    public int Id { get; set; }

    public string SubjectName { get; set; } = null!;

    public virtual ICollection<SubjectInfo> SubjectInfos { get; set; } = new List<SubjectInfo>();
}
