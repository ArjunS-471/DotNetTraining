using System;
using System.Collections.Generic;

namespace EmployeeRecords.Models;

public partial class NewEmployee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Position { get; set; } = null!;

    public int Salary { get; set; }
}
