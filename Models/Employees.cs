using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace List.Models
{
    [DataContract] 
    [Serializable]
    public class Employees
    {
     
        private string name;
        public string Name    // the Name property
        {
            get => name;
            set => name = value;
        }

        private string surname;
        public string Surname    // the Name property
        {
            get => surname;
            set => surname = value;
        }

        private string birthDate;
        public string BirthDate    // the Name property
        {
            get => birthDate;
            set => birthDate = value;
        }
        private string salary;
        public string Salary    // the Name property
        {
            get => salary;
            set => salary = value;
        }

        private string position;
        public string Position    // the Name property
        {
            get => position;
            set => position = value;
        }

        private string contractType;
        public string ContractType    // the Name property
        {
            get => contractType;
            set => contractType = value;
        }



        public Employees() { 
        }
        public Employees(List<string> Employee)
        {
            name = Employee[0];
            surname = Employee[1];
            birthDate = Employee[2];
            salary = Employee[3];
            position = Employee[4];
            contractType = Employee[5];
        }

        public List<string> StringList()
        {
            
            List<string> Employee = new List<string> { name, surname, birthDate, salary, position, contractType };

            return Employee;
        }

        public void Konsoleprint()
        {

            Console.WriteLine(name, surname, birthDate, salary, position, contractType);
        }
    }
}
