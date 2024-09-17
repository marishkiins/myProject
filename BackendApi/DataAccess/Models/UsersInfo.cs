using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class UsersInfo
{
    public int UserId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? PlaceOfStudy { get; set; }

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();

    public virtual User User { get; set; } = null!;
}
