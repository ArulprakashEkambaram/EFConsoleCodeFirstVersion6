using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDBFirst.Models
{
    public class EmployeeDetails
    {
        public int Address { get; set; }
        public int Id { get; set; }
        public long Salary { get; set; }

        //Foreign Key
        public int EmployeeId { get; set; }
        // Reference to Principal entity
        public Employee employee { get; set; }
    }
}
