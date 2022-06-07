
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
    /// Логика взаимодействия для Photo.xaml
    /// </summary>
    public partial class Photo : UserControl
    {
        public Photo()
        {
            InitializeComponent();
            var currentImg = AgencyEntities1.GetContext().Images.ToList();
            list.ItemsSource = currentImg;

            var objects = AgencyEntities1.GetContext().Object.ToList();
            pAdress.ItemsSource = objects;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddImage img = new AddImage(null);
            img.Show();
            
        }

        private void pAdress_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currPass = AgencyEntities1.GetContext().Images.ToList();

            if (pAdress.SelectedIndex >= 0)
            {
                var typeItem = pAdress.SelectedItem as Object;
                currPass = AgencyEntities1.GetContext().Images.Where(p => p.Object.NumberOfRooms.Equals(typeItem.NumberOfRooms)).ToList();
            }

            list.ItemsSource = currPass;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var delObj = list.SelectedItems.Cast<Images>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить {delObj.Count()} элемент", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    AgencyEntities1.GetContext().Images.RemoveRange(delObj);
                    AgencyEntities1.GetContext().SaveChanges();

                    list.ItemsSource = AgencyEntities1.GetContext().Images.ToList();
                }

                catch
                {
                    MessageBox.Show("Элемент уже удален");
                }
                             
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AddImage editeImg = new AddImage((sender as Button).DataContext as Images);
            editeImg.Show();
        }




        public class Foo // Класс для печати документа
        {
            public string Adress { get; set; }
            public int Rooms { get; set; }
            public decimal Price { get; set; }
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (var printServer = new LocalPrintServer())
            {
                try
                {
                    var dialog = new PrintDialog();
                    var qs = printServer.GetPrintQueues();
                    var queue = qs.FirstOrDefault(q => q.Name.Contains("PDF"));
                    dialog.PrintQueue = queue;
                    dialog.PrintVisual(grid, "Квартира");
                }

                catch 
                {
                    MessageBox.Show("Не удалось сохранить файл");
                }
               
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var currentImg = AgencyEntities1.GetContext().Images.ToList();
            list.ItemsSource = currentImg;
        }
    }

  
}
