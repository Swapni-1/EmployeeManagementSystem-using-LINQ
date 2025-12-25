using EMSLINQ.Models;

namespace EMSLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
           using var context = new EmployeeManagementContext();
           
         /*
          1. Query Syntax & Method Syntax
          
            Question:
            "Write a LINQ query to retrieve the names of all employees in the 'HR' department
            using both Query Syntax and Method Syntax."
          */

         var QSQuestion1 = from employee in context.Employees
                where employee.Department.DepartmentName == "HR"
                    select $"{employee.FirstName} {employee.LastName}";

         var MSQuestion1 = context.Employees.Where(employee =>
                 employee.Department.DepartmentName == "HR")
             .Select(employee => $"{employee.FirstName} {employee.LastName}");
         
         /*
          2. Lambda Expressions and Anonymous Types
            • Question:
            "Write a LINQ query to get a list of employees with their names and roles. Use lambda
            expressions and return the result as an anonymous type."
          */

         var LEATQuestion2 = context.Employees.Select(employee => new
         {
             Name = $"{employee.FirstName} {employee.LastName}",
             Role = employee.Role.RoleName
         });
         
         /*
          3. Deferred & Immediate Execution
            • Question:
            "Write a LINQ query that uses deferred execution to retrieve all employees in the
            'Marketing' department and then force immediate execution by converting the result to a
            list."
          */

         var DfQuestion3 = context.Employees.Where(employee => employee.Department.DepartmentName == "Marketing");

         var IEQuestion3 = context.Employees.ToList();

         
         /*
          4. Using Where, OrderBy, and ThenBy
            • Question:
            "Write a LINQ query that returns employees in the 'Engineering' department, sorted first by
            LastName in ascending order and then by FirstName in descending order. Use Where and
            OrderBy, followed by ThenBy."
          */

         var WOTQuestion4 = context.Employees
             .Where(employee => employee.Department.DepartmentName == "Engineering")
             .OrderBy(employee => employee.LastName)
             .ThenByDescending(employee => employee.FirstName);

         /*
          5. Select and SelectMany
            • Question:
            "Write a LINQ query to retrieve the department names and a list of all employees working in
            each department. Use Select and SelectMany to flatten the employee list."
          */

         var departmentEmpoyees = context.Departments
             .Select(department => new
             {
                 Department = department.DepartmentName,
                 Employee = department.Employees.Select(employee => $"{employee.FirstName} {employee.LastName}")
             });

         var allEmployeesFlattened = context.Departments
             .SelectMany(department => department.Employees);
         
         /*
          6. FirstOrDefault, LastOrDefault
            • Question:
            "Write a LINQ query to find the first employee hired in 2020 and the last employee who left
            the company in 2019 using FirstOrDefault and LastOrDefault."
          */

         var firstHired2020 = context.Employees
             .Where(employee => employee.HireDate.Year == 2020)
             .OrderBy(employee => employee.HireDate)
             .FirstOrDefault();

         var firstHired2019 = context.Employees
             .Where(employee => employee.HireDate.Year == 2019)
             .OrderBy(employee => employee.HireDate)
             .LastOrDefault();

         
        }
    }
}