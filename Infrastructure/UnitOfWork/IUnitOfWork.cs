using Core.Models;
using Infrastructure.Respositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.UnitOfWork
{
    public interface IUnitOfWork<T> where T : class
    {
        void Commit();

        IRepository<Department> DepartmentRepository { get; }

        IRepository<Employee> EmployeeRepository { get; }
    }
}
