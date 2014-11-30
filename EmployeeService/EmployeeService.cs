using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class EmployeeService : IEmployeeService
    {

        public Employee GetEmployee()
        {
            Project[] projects = new Project[3];

            for (int i = 0; i < projects.Length; i++)
            {
                projects[i] = new Project
                {
                    ProjectID = Guid.NewGuid(),
                    Duration = DateTime.Now,
                    ProjectName = string.Format("Project{0}",i)
                }; 
            }

            return new Employee{
                Id = 100,
                Name = "Tom",
                Projects = projects
            };
        }
    }
}
