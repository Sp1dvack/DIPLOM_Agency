using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Agency
{
    /// <summary>
    /// Логика взаимодействия для Employee.xaml
    /// </summary>
    public partial class Employeers : UserControl
    {
        public Employeers()
        {
            InitializeComponent();
            var currentEmp = AgencyEntities1.GetContext().Employee.ToList();
            dgEmp.ItemsSource = currentEmp;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var delObj = dgEmp.SelectedItems.Cast<Employee>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить {delObj.Count()} элемент", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    AgencyEntities1.GetContext().Employee.RemoveRange(delObj);
                    AgencyEntities1.GetContext().SaveChanges();

                    dgEmp.ItemsSource = AgencyEntities1.GetContext().Employee.ToList();
                }

                catch 
                {
                    MessageBox.Show("Элемент уже удален");
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddEmployee addObject = new AddEmployee(null);
            addObject.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddEmployee editeObj = new AddEmployee((sender as Button).DataContext as Employee);
            editeObj.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var currentEmp = AgencyEntities1.GetContext().Employee.ToList();
            dgEmp.ItemsSource = currentEmp;
        }
    }
}
