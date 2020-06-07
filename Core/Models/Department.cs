using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class Department
    {
        public int DepId { get; set; }
        public string DepName { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
