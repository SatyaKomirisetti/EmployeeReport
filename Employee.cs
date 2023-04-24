using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReport
{
    public class Employee
    {
        public Employee(int empID, string name, JobRole jobRole, DateTime dateJoined, bool remoteWorking, string city)
        {
            EmployeeId = empID;
            Name = name;
            Role = jobRole;
            DateJoined = dateJoined;
            RemoteWorking = remoteWorking;
            City = city;
        }
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public enum JobRole
        {

            Developer = 0,
            SeniorDeveloper = 1,
            Architect = 3,
            Manager = 4,
            HRManager = 5
        }
        public JobRole Role { get; set; }

        public DateTime DateJoined { get; set; }

        public bool RemoteWorking { get; set; }

        public string City { get; set; }
    
  }
}
