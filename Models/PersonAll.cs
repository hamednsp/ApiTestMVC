﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTestMVC.Models
{
    public class PersonAll
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PositionName { get; set; }
        public string DepartmentName { get; set; }
        public string Salary { get; set; }
        public string PersonCity { get; set; }
    }
}
