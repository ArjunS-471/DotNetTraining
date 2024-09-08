﻿using System;
using System.Collections.Generic;

namespace EmployeeRecords.Models;

public partial class Product
{
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public string ProductDescription { get; set; } = null!;

    public int Quantity { get; set; }

    public double Price { get; set; }
}