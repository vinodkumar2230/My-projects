﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crud.Models
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeeAddress { get; set; }
    }
}