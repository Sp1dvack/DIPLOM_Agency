using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace Agency
{
    /// <summary>
    /// Логика взаимодействия для Dapartment.xaml
    /// </summary>
    public partial class Dapartment : UserControl
    {
        public Dapartment()
        {
            InitializeComponent();

            var currentPass = AgencyEntities1.GetContext().Department.ToList();
            dgDep.ItemsSource = currentPass;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var delObj = dgDep.SelectedItems.Cast<Department>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить {delObj.Count()} элемент", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    AgencyEntities1.GetContext().Department.RemoveRange(delObj);
                    AgencyEntities1.GetContext().SaveChanges();

                    dgDep.ItemsSource = AgencyEntities1.GetContext().Department.ToList();
                }

                catch 
                {
                    MessageBox.Show("Элемент уже удален");
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddDepartment addDepartment = new AddDepartment(null);
            addDepartment.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddDepartment editeObj = new AddDepartment((sender as Button).DataContext as Department);
            editeObj.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var currentPass = AgencyEntities1.GetContext().Department.ToList();
            dgDep.ItemsSource = currentPass;
        }
    }
}
