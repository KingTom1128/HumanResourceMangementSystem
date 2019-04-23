using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem2019B
{
    public class SalarySheetItemReport
    {
        public string EmployeeName { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal Bonus { get; set; }
        public decimal Fine { get; set; }
        public decimal Other { get; set; }
    }
}
