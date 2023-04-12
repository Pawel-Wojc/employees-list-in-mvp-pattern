using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace List.Models
{
    [DataContract]
    public class Pracownik
    {
        [DataMember(Name = "Name")]
        public string Imie { get; set; }

        [DataMember(Name = "Surname")]
        private string Nazwisko { get; set; }

        [DataMember(Name = "BirthDate")]
        private string DataUrodzenia { get; set; }

        [DataMember(Name = "Salary")]
        private string Pensja { get; set; }
        [DataMember(Name = "Post")]
        private string Stanowisko { get; set; }
        [DataMember(Name = "ContractType")]
        private string RodzajUmowy { get; set; }

        public Pracownik() { 
        }
        public Pracownik(List<string> Pracownik)
        {
            Imie = Pracownik[0];
            Nazwisko = Pracownik[1];
            DataUrodzenia = Pracownik[2];
            Pensja = Pracownik[3];
            Stanowisko = Pracownik[4];
            RodzajUmowy = Pracownik[5];
        }

        public List<string> ListaStringow()
        {
            
            List<string> Pracownik = new List<string> { Imie, Nazwisko, DataUrodzenia, Pensja, Stanowisko, RodzajUmowy };

            return Pracownik;
        }
    }
}
