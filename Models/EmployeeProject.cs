using System;
using System.Collections.Generic;

namespace EMSLINQ.Models;

public partial class EmployeeProject
{
    public int EmployeeId { get; set; }

    public int? ProjectId { get; set; }

    public string RoleInProject { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual Project? Project { get; set; }
}
