using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDBFirst.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(50)]
        public string EmployeeFirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string EmployeeLastName { get; set; }


        //one to Many Relationship
        public int ManagerId { get; set; }
        public Manager Manager { get; set; } 

        // One to One Relationship
        //Reference Navigation to Dependent
        public EmployeeDetails employeeDetails { get; set; }

        //Collection Navigation Property (Many to Many)
        public ICollection<EmployeeProject> EmployeeProject { get; set; }
    }
}
