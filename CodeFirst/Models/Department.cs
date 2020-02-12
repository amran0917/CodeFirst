﻿

using System.Collections.Generic;

namespace CodeFirst.Models
{
    public class Department
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Employee> Employees { get; set; }
    }
}