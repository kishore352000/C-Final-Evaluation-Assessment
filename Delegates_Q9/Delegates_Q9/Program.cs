using System;

namespace Delegates_Q9
{
    public delegate void del(string name);
    class Employee
    {
        public void promotion(string pr)
        {
            Console.WriteLine(pr + " " + "gets the promotion ");
        }
        static void Main(string[] args)
        {
            Employee emp=new Employee();
            del d = new del(emp.promotion);
            string employee_name;
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Enter the name of employee" +" "+ i);
                employee_name = Console.ReadLine();
                d.Invoke(employee_name);
            }
        }
    }
}
