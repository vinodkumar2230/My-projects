﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Crud.Models
{
    public class EmployeeContext:DbContext
    {
        
        
            public DbSet<Employee> Employees { get; set; }
        
    }
}