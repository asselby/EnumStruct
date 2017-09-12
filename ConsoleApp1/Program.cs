/*1.	Создать массив сотрудников. Длина массива задается пользователем, заполнение массива производится им же. Выполнить следующее:
a.	вывести полную информацию обо всех сотрудниках;
b.	найти в массиве всех менеджеров, зарплата которых больше средней зарплаты всех клерков, вывести на экран полную информацию о таких менеджерах отсортированной по их фамилии.
c.	распечатать информацию обо всех сотрудниках, принятых на работу позже босса, отсортированную в алфавитном порядке по фамилии сотрудника.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                List<Employee> employees = new List<Employee>();
                Console.WriteLine("Введите количество сотрудников:");
                int number;
                Int32.TryParse(Console.ReadLine(), out number);
                for (int i = 0; i < number; i++)
                {
                    Employee employee = new Employee();
                    Console.WriteLine("Введите имя сотрудника: ");
                    employee.FirstName = Console.ReadLine();
                    Console.WriteLine("Введите фамилие сотрудника: ");
                    employee.LastName = Console.ReadLine();
                    Console.WriteLine("Введите должность сотрудника: ");
                    employee.Position = Console.ReadLine();
                    Console.WriteLine("Введите зароботную плату сотрудника: ");
                    int salary;
                    Int32.TryParse(Console.ReadLine(), out salary);
                    employee.Salary = salary;
                    employees.Add(employee);
                    Console.Clear();
                                       
                }
                for (; ; )
                {
                    Console.WriteLine("1 - Вывести на экран всех сотрудников!");
                    Console.WriteLine("2 - Поиск по зароботной плате менеджеров больше средней;");
                    int command;

                    Int32.TryParse(Console.ReadLine(), out command);
                    if (command == 1)
                        foreach (Employee i in employees)
                        {
                            Console.WriteLine("FirstName-{0},LastName -{1}, Position-{2}, Salary - {3}", i.FirstName, i.LastName, i.Position, i.Salary);
                        }
                    if (command == 2)
                    {
                        foreach (int i in )
                        {

                        }
                    }
                }
                Console.ReadLine();


            }

        }
    }
}
