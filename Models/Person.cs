using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTestMVC.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Surname { get; set; }
        [Required] public int Age { get; set; }
        [Required] public string Email { get; set; }
        [Required] public string Passwor { get; set; }
        public string Address { get; set; }
        public int PositionId { get; set; }
        public int SalaryID { get; set; }
        
    }
}
