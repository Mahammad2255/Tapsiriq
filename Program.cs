using System;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Employee employee = new Employee();

            employee.Maas("Mehemmed", "Ismayilov", "Developer", 50);
            


        }
    }
    class Employee
    {

        public string Name;
        public string Surname;
        public string Position;
        public int DailySalary;
        public int maas;
        
        public void Maas(string Name, string Surname, string Position, int DailySalary)
        {
            maas = DailySalary * 30;
            Console.WriteLine($" {Name} {Surname} {Position} {maas}");
        }
    }
}

