using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Imaging;

namespace Agency
{
    /// <summary>
    /// Логика взаимодействия для TypePage.xaml
    /// </summary>
    public partial class TypePage : UserControl
    {
        public TypePage()
        {
            InitializeComponent();

            var currentObj = AgencyEntities1.GetContext().ObjectType.ToList();
            dgType.ItemsSource = currentObj;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddType addType = new AddType(null);
            addType.Show();       
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddType editeType = new AddType((sender as Button).DataContext as ObjectType);
            editeType.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
                var delObj = dgType.SelectedItems.Cast<ObjectType>().ToList();

                if (MessageBox.Show($"Вы точно хотите удалить {delObj.Count()} элемент", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        AgencyEntities1.GetContext().ObjectType.RemoveRange(delObj);
                        AgencyEntities1.GetContext().SaveChanges();

                        dgType.ItemsSource = AgencyEntities1.GetContext().ObjectType.ToList();
                    }

                    catch
                    {
                        MessageBox.Show("Элемент уже удален");
                    }
                }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var currentObj = AgencyEntities1.GetContext().ObjectType.ToList();
            dgType.ItemsSource = currentObj;
        }
    }
}
