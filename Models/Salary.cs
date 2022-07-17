using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTestMVC.Models
{
    public class Salary
    {
        public int SalaryId { get; set; }
        public string Amount { get; set; }
    }
}
