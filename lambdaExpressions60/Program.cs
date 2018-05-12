using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaExpressions60
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> myEmployees = new List<Employee>();

            Employee employee1 = new Employee() { firstName = "Joe", lastName = "Smith", Id = 1 };
            myEmployees.Add(employee1);
            Employee employee2 = new Employee() { firstName = "Joe", lastName = "Johnson", Id = 2 };
            myEmployees.Add(employee2);
            Employee employee3 = new Employee() { firstName = "Mike", lastName = "Smith", Id = 3 };
            myEmployees.Add(employee3);
            Employee employee4 = new Employee() { firstName = "James", lastName = "Walton", Id = 4 };
            myEmployees.Add(employee4);
            Employee employee5 = new Employee() { firstName = "Jarvis", lastName = "Landry", Id = 5 };
            myEmployees.Add(employee5);
            Employee employee6 = new Employee() { firstName = "Mo", lastName = "Walker", Id = 6 };
            myEmployees.Add(employee6);
            Employee employee7 = new Employee() { firstName = "Keegan", lastName = "Rolenc", Id = 7 };
            myEmployees.Add(employee7);
            Employee employee8 = new Employee() { firstName = "Ariel", lastName = "Orbison", Id = 8 };
            myEmployees.Add(employee8);
            Employee employee9 = new Employee() { firstName = "Severus", lastName = "Snape", Id = 9 };
            myEmployees.Add(employee9);
            Employee employee10 = new Employee() { firstName = "Walt", lastName = "Disney", Id = 10 };
            myEmployees.Add(employee10);

            //// 2. FOREACH ////
            //List<Employee> sameName = new List<Employee>();
            //foreach (Employee employee in myEmployees)
            //{
            //    if (employee.firstName == "Joe")
            //    {
            //        sameName.Add(employee);
            //        Console.WriteLine("Last Names for Joe repeats are: {0}", employee.lastName);
            //    }
            //}
            //Console.ReadLine();

            //// 3. USING LAMBDA ////
            int count = myEmployees.Count(x => x.firstName == "Joe");
            Console.WriteLine(count);


            List<Employee> greaterThanFive = myEmployees.Where(y => y.Id > 5).ToList();

            foreach (Employee employee in greaterThanFive)
            {
                Console.WriteLine("Employee: {0} {1}, {2}", employee.firstName, employee.lastName, employee.Id);
            }
            Console.ReadLine();


        }
    }
}
