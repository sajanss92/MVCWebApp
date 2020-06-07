using Core.Models;
using Infrastructure.DBContext;
using Infrastructure.Respositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork<T> : Disposable, IUnitOfWork<T> where T : class
    {
        private readonly MVCAppContext m_DataContext;

        public UnitOfWork(MVCAppContext dbContext)
        {
            m_DataContext = dbContext;
        }
        /// <summary>
        /// Saves all pending changes
        /// </summary>
        public virtual void Commit()
        {
            m_DataContext.SaveChanges();
        }

        /// <summary>
        /// Disposes all external resources.
        /// </summary>
        protected override void DisposeCore()
        {
            if (m_DataContext != null)
                m_DataContext.Dispose();
        }

        private IRepository<Department> m_DepartmentRepository;
        public IRepository<Department> DepartmentRepository
        {
            get { return m_DepartmentRepository ?? (m_DepartmentRepository = new RepositoryBase<Department>(m_DataContext)); }
        }

        private IRepository<Employee> m_EmployeeRepository;
        public IRepository<Employee> EmployeeRepository
        {
            get { return m_EmployeeRepository ?? (m_EmployeeRepository = new RepositoryBase<Employee>(m_DataContext)); }
        }
    }
}
