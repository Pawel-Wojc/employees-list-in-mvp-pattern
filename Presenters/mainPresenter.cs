using System.Collections.Generic;
using System.Linq;

namespace List.Presenters
{
    internal class mainPresenter
    {
        
        private View.Employees _view;
        private Models.mainModel _model;
        
        public mainPresenter(View.Employees view, Models.mainModel model) 
        {
            _view  = view;
            _model = model;

            _view.AddEmployees += _view_AddEmployees;
            _view.SelectEmployee += _view_SelectEmployee;
            _view.EditEmployees += _view_EditEmployees;
            _view.SaveEmployeesa += _view_SaveEmployees;
            _view.LoadEmployees += _view_LoadEmployees;
           

        }
        private void _view_AddEmployees(List<string> obj)
        {
            
            if (_model._model_AddEmployees(obj))
            {
                 _view.SetEmployeeListBox(_model.DataEmployeesInList()); 
            }
            else {
                _view.error();
            }

        }

        private void _view_LoadEmployees() 
        {
            _view.clearListBox();
            List<List<string>> list = _model._model_LoadEmployees();

            foreach (List<string> employee in list) {
                _view.SetEmployeeListBox(employee);
            }     
            
        }

        

        private void _view_SaveEmployees()
        {
            _model._model_SaveEmployees();
            
        }

     
        private void _view_SelectEmployee(string obj)
        {
            string[] employee = obj.Split(',');
            if (employee.Length >= 6) {
                _view.SetPracownikTextBoxes(employee.ToList());
            }
            
        }


        private void _view_EditEmployees(List<string> data_employee, int index_employee_to_change) {
           bool zmiana = _model._model_AddEmployees(data_employee, index_employee_to_change);

            if (zmiana)
            {
                _view.SetEmployeeListBox(_model.DataEmployeesInList(index_employee_to_change), index_employee_to_change);
            }
            else {
                _view.error();
            
            }
        }

      

    }
}
