using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace List.Models
{
    public class mainModel
    {
        List<Employees> ListObjectsEmployees = new List<Employees>(); //lista obiektow pracowniko
       

        public List<string> DataEmployeesInList(int index = -1){ // jesli dostanie jakis parametr to zwroci tylko okreslony idex
            if (index == -1) 
                return ListObjectsEmployees.Last().StringList();
            else return ListObjectsEmployees[index].StringList();
        }

        public bool _model_AddEmployees(List<string> data_employee, int index_employee_to_change  = -1) // tutaj rowniez edytuje pracownika
        {
            var pracownik = new Employees(data_employee);
            Regex name_regex = new Regex("^[A-Z][a-z]\\p{L}{1,}$");
            Regex surname_regex = new Regex("^[A-Z][a-ząęółśżźć]*(-[A-Z][a-ząęółśżźć]+)*$");

            if (!name_regex.IsMatch(data_employee[0])) {
                return false;
            }


            if (!surname_regex.IsMatch(data_employee[1])) {
                return false;
            }
            
            if (index_employee_to_change == -1)
            {
                ListObjectsEmployees.Add(pracownik);
            }
            else {
                
                ListObjectsEmployees[index_employee_to_change] = pracownik;
            }            
             return true;

        }

        public List<List<string>> _model_LoadEmployees()  // wczytanie listy pracownikow z pliku
        {
            List<List<string>> list_employees = new List<List<string>>();
            //FileUsage plik = new FileUsage();
            SavingToDB savingToDB = new SavingToDB();


           // ListObjectsEmployees = plik.Load();


            foreach (Employees obiekt in ListObjectsEmployees) {      

                list_employees.Add(obiekt.StringList());
            }
            return list_employees;
        }

        public void _model_SaveEmployees()
        {
            FileUsage plik = new FileUsage();
            plik.Save(ListObjectsEmployees);

            SavingToDB savingToDB = new SavingToDB();
            try
            {
            savingToDB.Save(ListObjectsEmployees);

            }catch(Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
            

        }



    }
  
}
