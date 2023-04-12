using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace List.Models
{
    // tutaj musza byc obiekty


    internal class mainModel
    {
        List<Pracownik> listaObjPracownikow = new List<Pracownik>(); //lista obiektow pracowniko
       

        internal List<string> Dane_pracowika_list(int index = -1){ // jesli dostanie jakis parametr to zwroci tylko okreslony idex
            if (index == -1) 
                return listaObjPracownikow.Last().ListaStringow();
            else return listaObjPracownikow[index].ListaStringow();
        }

        internal bool _model_DodajPracownika(List<string> dane_pracownika, int index_pracownika_do_zmiany  = -1) // tutaj rowniez edytuje praconiwka
        {
            var pracownik = new Pracownik(dane_pracownika);
            Regex Imie_regex = new Regex("^[A-Z][a-z]\\p{L}{1,}$");
            Regex Nazwisko_regex = new Regex("^[A-Z][a-ząęółśżźć]*(-[A-Z][a-ząęółśżźć]+)*$");

            if (!Imie_regex.IsMatch(dane_pracownika[0])) {
                return false;
            }


            if (!Nazwisko_regex.IsMatch(dane_pracownika[1])) {
                return false;
            }
            
            if (index_pracownika_do_zmiany == -1)
            {
                listaObjPracownikow.Add(pracownik);
            }
            else {
                listaObjPracownikow[index_pracownika_do_zmiany] = pracownik;
            }            
             return true;

        }

        public void _model_WczytajPracownika()  // wczytanie listy pracownikow z pliku
        {
            Models.FileUsage plik = new Models.FileUsage();
            plik.wczytaj();

        }




        internal void _model_ZapiszPracownik()
        {
            Models.FileUsage plik = new Models.FileUsage();
            plik.zapisz(listaObjPracownikow);
        }

    }
  
}
