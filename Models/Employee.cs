using System;
using System.Collections.Generic;

namespace EMSLINQ.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int DepartmentId { get; set; }

    public int RoleId { get; set; }

    public DateOnly HireDate { get; set; }

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual Department Department { get; set; } = null!;

    public virtual ICollection<Payroll> Payrolls { get; set; } = new List<Payroll>();

    public virtual Role Role { get; set; } = null!;
}
