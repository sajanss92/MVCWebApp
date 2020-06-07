using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Service.ViewModels
{
    public class EmployeeViewModel
    {
        public int EmpId { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [DisplayName("Dob")]
        [Required(ErrorMessage = "Date of Birth is required")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Dob { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email Id is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [DisplayName("Mobile")]
        [Required(ErrorMessage = "Mobile Number is required")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string Mobile { get; set; }

        [DisplayName("Team")]
        [Required(ErrorMessage = "Team is Required")]
        public string Team { get; set; }

        [DisplayName("Doj")]
        [Required(ErrorMessage = "Date of Joining is required")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Doj { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }
    }
}
