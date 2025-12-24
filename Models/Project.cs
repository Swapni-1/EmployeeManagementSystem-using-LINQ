using System;
using System.Collections.Generic;

namespace EMSLINQ.Models;

public partial class Project
{
    public int ProjectId { get; set; }

    public string ProjectName { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly? ExpectedEndDate { get; set; }
}
