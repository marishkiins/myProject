using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class UserInfo
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public DateOnly DateOfBirth { get; set; }

    public string PlaceOfStudy { get; set; } = null!;

    public virtual User IdNavigation { get; set; } = null!;
}
