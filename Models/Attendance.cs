using System;
using System.Collections.Generic;

namespace EMSLINQ.Models;

public partial class Attendance
{
    public int AttendanceId { get; set; }

    public int EmployeeId { get; set; }

    public DateOnly Date { get; set; }

    public TimeOnly? CheckInTime { get; set; }

    public TimeOnly? CheckOutTime { get; set; }

    public string Status { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
}
