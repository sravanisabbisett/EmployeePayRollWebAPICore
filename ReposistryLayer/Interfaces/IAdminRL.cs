using CommonLayer.RequestModel;
using CommonLayer.ResponseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReposistryLayer.Interfaces
{
    public interface IAdminRL
    {
        EmployeeModel AdminLogin(AdminModel login);
        bool RegisterAdmin(RegisterModel admin);
        List<EmployeeModel> GetAllEmployee();
    }
}
