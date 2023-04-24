using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace List.Models
{
    internal class FileUsage
    {
        
        public void Save(List<Employees> ListObjectsEmployees) {

            string path = "E:\\Studia\\Semestr 4\\Programowanie obiektowe i graficzne\\List\\List\\Baza\\Pracownicy.xml";
            
            XmlSerializer serializer = new XmlSerializer(typeof(List<Employees>));
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {

                    serializer.Serialize(stream, ListObjectsEmployees);
                
            }

        }

        public List<Employees> Load()
        {
            string path = "E:\\Studia\\Semestr 4\\Programowanie obiektowe i graficzne\\List\\List\\Baza\\Pracownicy.xml";

            List<Employees> ListObjectsEmployees = new List<Employees>();

            XmlSerializer serializer = new XmlSerializer(typeof(List<Employees>));

            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                ListObjectsEmployees = (List<Employees>)serializer.Deserialize(fileStream);
            }

            return ListObjectsEmployees;
        }
    }
}
