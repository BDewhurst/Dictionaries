using System;
using System.Net.Http.Headers;
using System.Collections.Generic;

namespace DictionariesDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            Employee[] employees = {
                new Employee("CEO", "Gwyn", 95, 200),
                new Employee("Dentist", "Pixie", 24, 50),
                new Employee("Police Officer", "Sherry", 25, 33),
                new Employee("Astronaut", "Whistie", 35, 23),
                new Employee("Personal Trainer", "Shahid", 45, 100),
                new Employee("Intern", "Frederick", 20, 70),
                new Employee("Footballer", "Ian", 28, 2000),
            };

            Dictionary<string, Employee> employeeDictionary = new Dictionary<string, Employee>();
            foreach (Employee emp in employees)
            {
                employeeDictionary.Add(emp.Role, emp);
            }

            Employee empl = employeeDictionary["CEO"];
            Console.WriteLine($"Name: {empl.Name}, Role: {empl.Role}, Salary: {empl.Salary}");

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(1232);
            Console.WriteLine(stack.Peek());

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(200);
            queue.Dequeue();
            Console.WriteLine(queue.Peek());

        }
    }
    class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }
        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }
        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;

        }
    }
}
