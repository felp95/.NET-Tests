using System;
using System.Collections.Generic;

namespace Demo
{
    public class Person
    {
        public string Name { get; protected set; }
        public string Nickname { get; set; }
    }

    public class Employee : Person
    {
        public double Salary { get; private set; }
        public ProfessionalLevel ProfessionalLevel { get; private set; }
        public IList<string> Skills { get; private set; }

        public Employee(string name, double salary)
        {
            Name = string.IsNullOrEmpty(name) ? "Fulano" : name;
            DefineSalary(salary);
            DefineSkills();
        }

        public void DefineSalary(double salary)
        {
            if(salary < 500) throw new Exception("Salario inferior ao permitido");

            Salary = salary;
            if (salary < 2000) ProfessionalLevel = ProfessionalLevel.Junior;
            else if (salary >= 2000 && salary < 8000) ProfessionalLevel = ProfessionalLevel.MidLevel;
            else if (salary >= 8000) ProfessionalLevel = ProfessionalLevel.Senior;
        }

        private void DefineSkills()
        {
            var basicSkills = new List<string>
            {
                
                "Lógica de Programação",
                "OOP"
            };

            Skills = basicSkills;

            switch (ProfessionalLevel)
            {
                case ProfessionalLevel.MidLevel:
                    Skills.Add("Testes");
                    break;
                case ProfessionalLevel.Senior:
                    Skills.Add("Testes");
                    Skills.Add("Microservices");
                    break;
            }
        }
    }

    public enum ProfessionalLevel
    {
        Junior,
        MidLevel,
        Senior
    }

    public class EmployeeFactory
    {
        public static Employee Create(string name, double salary)
        {
            return new Employee(name, salary);
        }
    }
}