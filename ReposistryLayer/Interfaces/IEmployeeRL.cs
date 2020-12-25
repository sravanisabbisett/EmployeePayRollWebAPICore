using CommonLayer.RequestModel;
using ReposistryLayer.ContextModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReposistryLayer.Interfaces
{
    public interface IEmployeeRL
    {
        bool RegisterEmployee(RegisterModel employee);
        bool Delete(int EmpId);
        bool EditEmployee(UpdateModel updatedEmployee, int EmpId);
        List<CompanyEmployee> GetAllEmployee();
    }
}
