using System;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        public class Department
        {
            private string _name;
            private int _age;

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public int Age
            {
                get { return _age; }
                set { _age = value; }
            }

            public Department(string name, int age)
            {
                _name = name;
                _age = age;
            }

            public void DisplayDepartmentInfo()
            {
                Console.WriteLine("Имя Фамилия: {0}, Возраст: {1}", _name, _age);
            }
        }

        public class Worker : Department
        {
            private int _experience;

            public int Experience
            {
                get { return _experience; }
                set { _experience = value; }
            }

            public Worker(string name, int age, int experience) : base(name, age)
            {
                _experience = experience;
            }

            public void DisplayWorkerInfo()
            {
                DisplayDepartmentInfo();
                Console.WriteLine("Опыт работы: {0} лет", _experience);
            }
        }

        public class Administration : Department
        {
            private int _experience;

            public int Experience
            {
                get { return _experience; }
                set { _experience = value; }
            }

            public Administration(string name, int age, int experience) : base(name, age)
            {
                _experience = experience;
            }

            public void DisplayAdministrationInfo()
            {
                DisplayDepartmentInfo();
                Console.WriteLine("Опыт работы администратора: {0} лет", _experience);
            }
        }

        public class Engineer : Worker
        {
            private string _specialization;

            public string Specialization
            {
                get { return _specialization; }
                set { _specialization = value; }
            }

            public Engineer(string name, int age, int experience, string specialization)
                : base(name, age, experience)
            {
                _specialization = specialization;
            }

            public void DisplayEngineerInfo()
            {
                DisplayWorkerInfo();
                Console.WriteLine("Специальность: {0}", _specialization);
            }
        }
        static void Main(string[] args)
        {
            Department department = new Department("Иван Иванов", 41);
            Worker worker = new Worker("Матвей Матвеев", 32, 10);
            Administration administration = new Administration("Салим Салимов", 19, 9);
            Engineer engineer = new Engineer("Егор Егоров", 23, 23, "3 разряд");

            Console.WriteLine("\n1. Кадры:");
            department.DisplayDepartmentInfo();

            Console.WriteLine("\n2. Рабочий:");
            worker.DisplayWorkerInfo();

            Console.WriteLine("\n3. Администрация:");
            administration.DisplayAdministrationInfo();

            Console.WriteLine("\n4. Инженер:");
            engineer.DisplayEngineerInfo();
        }
    }
}