using System;
using System.Collections.Generic;

namespace EMSLINQ.Models;

public partial class Payroll
{
    public int PayrollId { get; set; }

    public int EmployeeId { get; set; }

    public decimal? BaseSalary { get; set; }

    public decimal? Bonuses { get; set; }

    public decimal? Deductions { get; set; }

    public decimal? NetPay { get; set; }

    public DateOnly PayMonth { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
