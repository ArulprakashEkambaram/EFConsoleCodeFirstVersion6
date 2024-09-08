using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDBFirst.Models
{
    public class Manager
    {
        public int ManagerId { get; set; }
        public string ManagerName { get; set; }
        public string Department { get; set; }

        //one to Many Relationship
        // Collection Navigation property to represent the enployee managed by Manager
       public ICollection<Employee> Employees { get; set; }
    }
}
