using System;
using System.Text;
using System.Windows;

namespace Agency
{
    /// <summary>
    /// Логика взаимодействия для AddDepartment.xaml
    /// </summary>
    public partial class AddDepartment : Window
    {
        private Department _currentDep = new Department();
        public AddDepartment(Department selectedDep)
        {
            InitializeComponent();

            if (selectedDep != null)
                _currentDep = selectedDep;

            DataContext = _currentDep;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_currentDep.DepartmentID == 0)
            {
                AgencyEntities1.GetContext().Department.Add(_currentDep);
            }

            try
            {
                AgencyEntities1.GetContext().SaveChanges();
                MessageBox.Show("Сохранено");
                this.Close();
            }

            catch 
            {
                if (name.Text == "")
                {
                    MessageBox.Show("Введите наименование");
                    return;
                }
            }
        }

        private void TextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (Char.IsDigit(e.Text, 0)) e.Handled = true;
        }
    }
}
