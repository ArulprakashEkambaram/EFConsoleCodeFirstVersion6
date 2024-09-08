using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDBFirst.Models
{
    [PrimaryKey(nameof(EmployeeId), nameof(ProjectId))]
    public class EmployeeProject
    {
        [Key]
        public int EmployeeId { get; set; }

        [Key]
        public int ProjectId { get; set; }

        public bool IsActiveProject { get; set; }

        public Employee Employee { get; set; } // Reference Navigation Property

        public Project Project { get; set; }// Reference Navigation Property
    }
}
