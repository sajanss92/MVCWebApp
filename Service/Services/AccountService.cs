using Core.Models;
using Infrastructure.DBContext;
using Infrastructure.UnitOfWork;
using Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json;
using System.Linq.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Service.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork<MVCAppContext> m_UnitOfWork;

        public AccountService(IUnitOfWork<MVCAppContext> unitOfWork)
        {
            m_UnitOfWork = unitOfWork;
        }

        public string GetEmpDetails()
        {
            var empDetails = JsonConvert.SerializeObject(m_UnitOfWork.EmployeeRepository.GetAll());
            return empDetails;
        }

        public IEnumerable<Department> GetTeamDetails()
        {
            var teams = m_UnitOfWork.DepartmentRepository.GetAll();
            return teams;
        }

        public IEnumerable<Employee> CreateEmployee(EmployeeViewModel empViewModel)
        {
            MVCAppContext _db = new MVCAppContext();
            Employee emp = new Employee()
            {
                Name = empViewModel.Name,
                Email = empViewModel.Email,
                Mobile = empViewModel.Mobile,
                Team = empViewModel.Team,
                Dob = empViewModel.Dob,
                Doj = empViewModel.Doj,
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now
            };
            var addEmp = m_UnitOfWork.EmployeeRepository.Add(emp);
            return null;
        }

        public bool DeleteEmployee(int Id)
        {
            var empTODelete = m_UnitOfWork.EmployeeRepository.Get(Id);
            m_UnitOfWork.EmployeeRepository.Delete(empTODelete);
            return true;
        }

        public string EditEmployee(int Id)
        {
            var empForEdit = JsonConvert.SerializeObject(m_UnitOfWork.EmployeeRepository.Get(Id));
            return empForEdit;
        }

        public bool UpdateEmployee(EmployeeViewModel viewModel)
        {
            var empForUpdate = m_UnitOfWork.EmployeeRepository.Get(viewModel.EmpId);
            Employee emp = new Employee()
            {
                EmpId = viewModel.EmpId,
                Name = viewModel.Name,
                Email = viewModel.Email,
                Mobile = viewModel.Mobile,
                Dob = viewModel.Dob,
                Doj = viewModel.Doj,
                Team = viewModel.Team,
                CreatedOn = viewModel.CreatedOn,
                UpdatedOn = DateTime.Now
            };
            m_UnitOfWork.EmployeeRepository.Update(emp);
            return true;
        }
    }
}
