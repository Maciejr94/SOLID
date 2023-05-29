using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPMain.Example
{
    internal class EmployeeService
    {
        private EmployeeRepository _employeeRepository = new EmployeeRepository();

        public void Add(Employee employee)
        {
            _employeeRepository.Add(employee);
        }
    }
}
