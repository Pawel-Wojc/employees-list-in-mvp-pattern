using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List.View
{
    public partial class Form1 : Form
    {
        private bool pracownik_edytowany;
        int idexwybranegopracownika;
        public event Action<List<string>> DodajPracownika; 
        public event Action<List<string>, int> EdytujPracownika; 
        public event Action<String> WybierzPracownika;
        public event Action ZapiszPracownika;
        public event Action WczytajPracownika;
      
        public Form1()
        {
            InitializeComponent();
        }

        //funkcja która ustawia list box, dostaje na wejsciu Liste stringow 
        public void SetPracownikListBox(List<String> pracownik, int index = -1) {         
            var gotowy_pracownik = "";
            foreach (var item in pracownik)
            {
                gotowy_pracownik += item + ", ";
            }

            if (index != -1)
            {
                listBox1.Items.RemoveAt(index);
                
                listBox1.Items.Insert(index, gotowy_pracownik);
            }
            else {
                listBox1.Items.Add(gotowy_pracownik);
            }
            
        }

        //funkcja do ustawiania tekst boxow po wybraniu ktorego z pracownikow w List boxie
        public void SetPracownikTextBoxes(List<string> pracownik_list )
        {        
            textImie.Text = pracownik_list[0].Trim();
            textNazwisko.Text = pracownik_list[1].Trim();
            dateTimePicker.Text = pracownik_list[2].Trim();
            numericSalary.Text = pracownik_list[3].Trim();
            comboBoxStanowisko.Text = pracownik_list[4].Trim();
            if (radioButton1.Text == pracownik_list[5].Trim())
                radioButton1.Checked=true;
            if (radioButton2.Text == pracownik_list[5].Trim())
                radioButton2.Checked = true;
            if (radioButton3.Text == pracownik_list[5].Trim())
                radioButton3.Checked = true;

        }


        // Jesli klikniemi ktorys element w listboxie
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            pracownik_edytowany = true;
            idexwybranegopracownika = listBox1.SelectedIndex;
            WybierzPracownika?.Invoke(listBox1.Text);
        }
        
        //przycisk tworzy liste stringow i przekazuja ja do presentera
        private void buttonDodaj_Click(object sender, EventArgs e) {
            if (textImie.Text == string.Empty || textNazwisko.Text == string.Empty)
            {
                return;
            }
            List<string> Pracownik_list = new List<string> { textImie.Text, textNazwisko.Text, dateTimePicker.Text, numericSalary.Text, comboBoxStanowisko.Text };            
            if (radioButton1.Checked)
                Pracownik_list.Add(radioButton1.Text);
            if (radioButton2.Checked)
                Pracownik_list.Add(radioButton2.Text);
            if (radioButton3.Checked)
                Pracownik_list.Add(radioButton3.Text);
            if (pracownik_edytowany) {
                EdytujPracownika?.Invoke(Pracownik_list, idexwybranegopracownika);
                pracownik_edytowany = false;
                clearTextBoxes();
                return;
            }
           

            clearTextBoxes();
            DodajPracownika?.Invoke(Pracownik_list);
            

        }


        internal void buttonZapisz_Click(object sender, EventArgs e) {
            ZapiszPracownika?.Invoke();
        } 

        public void buttonWczytaj_Click(object sender, EventArgs e)
        {
            WczytajPracownika?.Invoke();
        }

        internal void error()
        {
            errorProviderNazwisko.SetError(textNazwisko, "Nieprawidłowe dane ");
        }

                  
        //    errorProviderImie.SetError(textImie, null);
       
       

        //dodatkowe ustawienie roku, minimum to 18 lat od dzisiejszej daty, maksimum to 90 lat wstecz od dzisiaj
        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker.MaxDate = DateTime.Now.AddYears(-18);
            dateTimePicker.MinDate = DateTime.Now.AddYears(-90);
           
        }
        private void clearTextBoxes() {
            textImie.Clear();
            textNazwisko.Clear();
            numericSalary.Text = "1000";
            var data = DateTime.Now.AddYears(-19);
            dateTimePicker.Text = data.ToString();

        }
    }
}
