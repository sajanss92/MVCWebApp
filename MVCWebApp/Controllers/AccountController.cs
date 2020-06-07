using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Service.Services;
using Service.ViewModels;

namespace MVCWebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountSevice;

        public AccountController(IAccountService accountService)
        {
            _accountSevice = accountService;
        }

        public IActionResult Employees()
        {
            var jSONEmpDetails = _accountSevice.GetEmpDetails();
            List<EmployeeViewModel> EmpViewModel = JsonConvert.DeserializeObject<List<EmployeeViewModel>>(jSONEmpDetails);
            return View(EmpViewModel);
        }

        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateEmployee(EmployeeViewModel empViewModel)
        {
            if (ModelState.IsValid)
            {
                _accountSevice.CreateEmployee(empViewModel);
            }
            else { return View("AddEmployee"); }
            return View("Employees");
        }

        public IActionResult DeleteEmployee(int Id)
        {
            _accountSevice.DeleteEmployee(Id);
            return RedirectToAction("Employees", "Account");
        }

        public IActionResult EditEmployee(int Id)   
        {
            var jsonResult = _accountSevice.EditEmployee(Id);
            var EmpViewModel = JsonConvert.DeserializeObject<EmployeeViewModel>(jsonResult);
            return View(EmpViewModel);
        }

        public IActionResult ViewEmployee(int Id)
        {
            var jsonResult = _accountSevice.EditEmployee(Id);
            var EmpViewModel = JsonConvert.DeserializeObject<EmployeeViewModel>(jsonResult);
            return View(EmpViewModel);
        }

        [HttpPost]
        public IActionResult UpdateEmployee(EmployeeViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _accountSevice.UpdateEmployee(viewModel);
            }
            else { return View("EditEmployee");  }
            return RedirectToAction("Employees", "Account");
        }
    }
}
