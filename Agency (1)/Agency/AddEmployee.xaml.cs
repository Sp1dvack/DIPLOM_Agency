using System;
using System.Linq;
using System.Text;
using System.Windows;


namespace Agency
{
    /// <summary>
    /// Логика взаимодействия для AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        private Employee _currentObject = new Employee();

        public AddEmployee(Employee selectedEmp)
        {
            InitializeComponent();
           
            cType.ItemsSource = AgencyEntities1.GetContext().Department.ToList();

            if (selectedEmp != null)
                _currentObject = selectedEmp;

            DataContext = _currentObject;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_currentObject.EmployeeID == 0)
            {
                AgencyEntities1.GetContext().Employee.Add(_currentObject);
            }

            try
            {
                AgencyEntities1.GetContext().SaveChanges();
                MessageBox.Show("Сохранено");
                this.Close();
            }

            catch 
            {
               string errors="";
               if (tb.Text == "")
                    errors += "Введите ФИО\n";
               if (cType.SelectedItem == null)
                    errors += "Выберите отдел\n";
               MessageBox.Show(errors);
            }
        }

        private void tb_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (Char.IsDigit(e.Text, 0)) e.Handled = true;
        }
    }
}
