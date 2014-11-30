using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace EmployeeService
{
    [DataContract]
    public class Project
    {
        [DataMember]
        public Guid ProjectID { get; set; }
        [DataMember]
        public string ProjectName { get; set; }
        [DataMember]
        public DateTime Duration { get; set; }
 
    }
}
