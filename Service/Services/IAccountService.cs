using Core.Models;
using Microsoft.AspNetCore.Mvc;
using Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public interface IAccountService
    {
        string GetEmpDetails();

        IEnumerable<Department> GetTeamDetails();

        IEnumerable<Employee> CreateEmployee(EmployeeViewModel empViewModel);

        bool DeleteEmployee(int Id);

        string EditEmployee(int Id);

        bool UpdateEmployee(EmployeeViewModel viewModel);
    }
}
