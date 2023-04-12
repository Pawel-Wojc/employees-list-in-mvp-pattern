using List.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List.Presenters
{
    internal class mainPresenter
    {
        

        private View.Form1 _view;
        private Models.mainModel _model;


       // List<Models.Pracownik> listaObjPracownikow = new List<Models.Pracownik>(); //lista obiektow pracowniko
        public mainPresenter(View.Form1 view, Models.mainModel model) // kontruktor presentera
        {
            _view  = view;
            _model = model;

            _view.DodajPracownika += _view_DodajPracownika;
            _view.WybierzPracownika += _view_WybierzPracownika;
            _view.EdytujPracownika += _view_EdytujPracownika;
            _view.ZapiszPracownika += _view_ZapiszPracownik;
            _view.WczytajPracownika += _view_WczytajPracownika;

        }



        private void _view_DodajPracownika(List<string> obj)
        {
            if (_model._model_DodajPracownika(obj))
            {
                 _view.SetPracownikListBox(_model.Dane_pracowika_list()); 
            }
            else {
                _view.error();
                
            }

        }

        private void _view_WczytajPracownika() // wczytanie listy pracownikow z pliku
        {

            _model._model_WczytajPracownika();
            //_view.SetPracownikListBox();


            
        }

        private void _view_ZapiszPracownik() // zapisanie listy pracownikow do pliku
        {
            _model._model_ZapiszPracownik();
            
        }



        // uruchamiane po wybraniu ktorego elementu z listboxa,
        // uruchamia funkcje odpowiedzialna za uzupelnienie textboxow danymi danego pracwnik
        private void _view_WybierzPracownika(string obj)
        {
            string[] Pracownik = obj.Split(',');
            if (Pracownik.Length >= 6) {
                _view.SetPracownikTextBoxes(Pracownik.ToList());
            }
            
        }


        private void _view_EdytujPracownika(List<string> dane_pracownika, int index_pracownika_do_zmiany) {
           bool zmiana = _model._model_DodajPracownika(dane_pracownika, index_pracownika_do_zmiany);

            if (zmiana)
            {
                _view.SetPracownikListBox(_model.Dane_pracowika_list(index_pracownika_do_zmiany), index_pracownika_do_zmiany);
            }
            else {
                _view.error();
            
            }
        }

      

    }
}
