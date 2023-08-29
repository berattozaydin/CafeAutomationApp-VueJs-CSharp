using System;
using System.Collections.Generic;

namespace CafeAutomationDAL.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int? Role { get; set; }
}
