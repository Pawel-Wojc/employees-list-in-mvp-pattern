using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Xml;
using System.Runtime.ConstrainedExecution;

namespace List.Models
{
    internal class FileUsage
    {
        
        public void zapisz(List<Pracownik> listaObjPracownikow) {
            
            string path = "E:\\Studia\\Semestr 4\\Programowanie obiektowe i graficzne\\List\\List\\Baza\\Pracownicy.xml";         
            var ser  = new DataContractSerializer(typeof(Pracownik));
            foreach (Pracownik obiekt in listaObjPracownikow)
                using (var writer = XmlWriter.Create(path))
                {
                writer.WriteStartElement("Employear");
                ser.WriteObject(writer, listaObjPracownikow);
                writer.WriteEndElement();


            }
            
        }

        public void wczytaj()
        {
            //List<Models.Pracownik> listaObjPracownikow = new List<Models.Pracownik>(); //lista obiektow pracowniko

            string path = "E:\\Studia\\Semestr 4\\Programowanie obiektowe i graficzne\\List\\List\\Baza\\Pracownicy.xml";
            DataContractSerializer serializer = new DataContractSerializer(typeof(Pracownik));

           
            using (XmlReader reader = XmlReader.Create(path))
            {
              Pracownik obj = serializer.ReadObject(reader) as Pracownik;
                //listaObjPracownikow.Add(obj);


                List<string> names = obj.ListaStringow();
                var result = String.Join(", ", names.ToArray());

                Console.WriteLine(result);
            }
            //return listaObjPracownikow;
        }


        //public void zapisz(List<Models.Pracownik> obj) {
        //    string path = "E:\\Studia\\Semestr 4\\Programowanie obiektowe i graficzne\\List\\List\\Baza\\Pracownicy.csv";
        //    try
        //    {
        //        StreamWriter sw = new StreamWriter(path);
        //        foreach (Models.Pracownik p in obj)
        //        {
        //            string gotowy_pracownik = "";
        //            List<string> pracownik_list = p.ListaStringow();
        //            foreach (string pracownik in pracownik_list) { 
        //                gotowy_pracownik += pracownik+", ";
        //            }
        //            sw.WriteLine(gotowy_pracownik);
        //        }
        //        sw.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Exception: " + e.Message);
        //    }
        //}


        //public List<Models.Pracownik> wczytaj() {
        //    String line;
        //    string path = "E:\\Studia\\Semestr 4\\Programowanie obiektowe i graficzne\\List\\List\\Baza\\Pracownicy.csv";

        //    List<Models.Pracownik> listaObjPracownikow = new List<Models.Pracownik>(); //lista obiektow pracowniko

        //    try
        //    {
        //        //Pass the file path and file name to the StreamReader constructor
        //        StreamReader sr = new StreamReader(path);
        //        //Read the first line of text
        //        line = sr.ReadLine();

        //        List<string> pracownik_list = line.Split(',').ToList();
        //        Models.Pracownik pracownik = new Models.Pracownik(pracownik_list);
        //        listaObjPracownikow.Add(pracownik);

        //        //Continue to read until you reach end of file
        //        while (line != null)
        //        {
        //            //Read the next line
        //            line = sr.ReadLine();
        //            line = "Wsda, Fsq, 30.03.2004, 124342, Admin, Umowa o pracę, ";
        //            string[] temp = line.Split(',');
        //            List<string> pracownik_list2 = temp.ToList(); 
        //            Pracownik pracownik2 = new Models.Pracownik(pracownik_list2);
        //            listaObjPracownikow.Add(pracownik2);
        //        }
        //        sr.Close();
        //        Console.ReadLine();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Exception: " + e.Message);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Executing finally block.");
        //    }

        //    return listaObjPracownikow;

        //}
    }
}
