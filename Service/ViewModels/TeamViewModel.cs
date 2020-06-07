using System;
using System.Collections.Generic;
using System.Text;

namespace Service.ViewModels
{
    public class TeamViewModel
    {
        public int DepId { get; set; }
        public string DepName { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
