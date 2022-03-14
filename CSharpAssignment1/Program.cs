using System;

namespace CSharpAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 0;
            bool isIdCorrect = false;
            do
            {
                Console.WriteLine("Enter the Employee Id  ");
                isIdCorrect = int.TryParse(Console.ReadLine(), out id);
                if(!isIdCorrect)
                {
                    Console.WriteLine("Please Provide Id in Integer!");
                }
            } while (!isIdCorrect);

            Console.WriteLine("Enter the Employee Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Employee Department Name");
            string departmentName = Console.ReadLine();
            Employee employee = new Employee(id, name, departmentName);

            employee.DetailsDelegate += EmployeeMethodCalled;

            Console.WriteLine("Employee Details are - ");
            Console.WriteLine($"  Id - {employee.GetId()}");
            Console.WriteLine($"  Name - {employee.GetName()}");
            Console.WriteLine($"  Department Name - {employee.GetDepartmentName()}");

        }
        public static void EmployeeMethodCalled(object sender, MessageEventArgs messageEventArgs)
        {
            Console.WriteLine(messageEventArgs.Message);
        }
        
    }
}
