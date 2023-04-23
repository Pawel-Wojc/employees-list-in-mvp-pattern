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
    public partial class Employees : Form
    {
        private bool pracownik_edytowany;
        int idex_of_selected_employee;
        public event Action<List<string>> AddEmployees; 
        public event Action<List<string>, int> EditEmployees; 
        public event Action<string> SelectEmployee;
        public event Action SaveEmployeesa;
        public event Action LoadEmployees;
      
        public Employees()
        {
            InitializeComponent();
        }

        //funkcja która ustawia list box, dostaje na wejsciu Liste stringow 
        public void SetEmployeeListBox(List<String> employee, int index = -1) {         
            var ready_employee = "";
            foreach (var item in employee)
            {
                ready_employee += item + ", ";
            }

            if (index != -1)
            {
                listBox1.Items.RemoveAt(index);
                
                listBox1.Items.Insert(index, ready_employee);
            }
            else {
                listBox1.Items.Add(ready_employee);
            }
            
        }

        //funkcja do ustawiania tekst boxow po wybraniu ktorego z pracownikow w List boxie
        public void SetPracownikTextBoxes(List<string> employee_list)
        {        
            textname.Text = employee_list[0].Trim();
            textsurname.Text = employee_list[1].Trim();
            dateTimePicker.Text = employee_list[2].Trim();
            numericSalary.Text = employee_list[3].Trim();
            comboBoxposition.Text = employee_list[4].Trim();
            if (radioButton1.Text == employee_list[5].Trim())
                radioButton1.Checked=true;
            if (radioButton2.Text == employee_list[5].Trim())
                radioButton2.Checked = true;
            if (radioButton3.Text == employee_list[5].Trim())
                radioButton3.Checked = true;

        }


        // Jesli klikniemi ktorys element w listboxie
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            pracownik_edytowany = true;
            idex_of_selected_employee = listBox1.SelectedIndex;
            SelectEmployee?.Invoke(listBox1.Text);
        }
        
        //przycisk tworzy liste stringow i przekazuja ja do presentera
        private void buttonDodaj_Click(object sender, EventArgs e) {
            if (textname.Text == string.Empty || textsurname.Text == string.Empty)
            {
                return;
            }
            List<string> Employee_list = new List<string> { textname.Text, textsurname.Text, dateTimePicker.Text, numericSalary.Text, comboBoxposition.Text };            
            if (radioButton1.Checked)
                Employee_list.Add(radioButton1.Text);
            if (radioButton2.Checked)
                Employee_list.Add(radioButton2.Text);
            if (radioButton3.Checked)
                Employee_list.Add(radioButton3.Text);
            if (pracownik_edytowany) {
                EditEmployees?.Invoke(Employee_list, idex_of_selected_employee);
                pracownik_edytowany = false;
                clearTextBoxes();
                return;
            }
           

            clearTextBoxes();
            AddEmployees?.Invoke(Employee_list);
            

        }


        public void buttonSave_Click(object sender, EventArgs e) {
            SaveEmployeesa?.Invoke();
        } 

        public void buttonLoad_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            LoadEmployees?.Invoke();
            
        }

        public void error()
        {
            errorProvidersurname.SetError(textsurname, "Data not correct ");
        }


        //    errorProvidername.SetError(textname, null);



        
        public void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker.MaxDate = DateTime.Now.AddYears(-18);
            dateTimePicker.MinDate = DateTime.Now.AddYears(-90);
            comboBoxposition.Text = "Developer";
        }
        public void clearTextBoxes() {
            textname.Clear();
            textsurname.Clear();
            numericSalary.Text = "1000";
            var data = DateTime.Now.AddYears(-19);
            dateTimePicker.Text = data.ToString();

        }

        

        public void clearListBox() => listBox1.Items.Clear();

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox1.SelectedIndex = -1;
        
        }
    }
}
