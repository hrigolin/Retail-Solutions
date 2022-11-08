using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BreakTracking.Context;
using BreakTracking.Domain.Models;
using BreakTracking.Aplication.Startup;

using BreakTracking.Repository;
using System.Globalization;

namespace BreakTracking
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {

            BreakTrackingContext context = new FirstLoading().DataLoading();
            
            var employeeRepository = new EmployeeRepository(context);

            var employeeGrid = employeeRepository.GetEmployeeGridViewModel().ToList();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form1 = new Form1(context);
            employeeGrid.ForEach(f => { form1.dataGridView1.Rows.Add(f.EmployeeId, f.EmployeeName, f.DepartmentName,f.ShiftName); });


            Application.Run(form1);

        }
       
    }
}
