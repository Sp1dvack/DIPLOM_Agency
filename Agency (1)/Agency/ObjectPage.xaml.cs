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
    /// Логика взаимодействия для ObjectPage.xaml
    /// </summary>
    public partial class ObjectPage : UserControl
    {
        public ObjectPage()
        {
            InitializeComponent();
            var currentObj = AgencyEntities1.GetContext().Object.ToList();

            var type = AgencyEntities1.GetContext().ObjectType.ToList();
            list.ItemsSource = currentObj;

            cType.ItemsSource = type;
            cPlace.ItemsSource = currentObj;     
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddObject addObject = new AddObject(null);
            addObject.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var delObj = list.SelectedItems.Cast<Object>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить {delObj.Count()} элемент", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    AgencyEntities1.GetContext().Object.RemoveRange(delObj);
                    AgencyEntities1.GetContext().SaveChanges();

                    list.ItemsSource = AgencyEntities1.GetContext().Object.ToList();
                }

                catch
                {
                    MessageBox.Show("Элемент уже удален");
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var currentObject = AgencyEntities1.GetContext().Object.ToList();
            currentObject = currentObject.Where(p => p.Employee.FullName.ToString().ToLower().Contains(Search.Text.ToLower())).ToList();
            list.ItemsSource = currentObject.OrderBy(p => p.Employee.FullName).ToList();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddObject editeObj = new AddObject((sender as Button).DataContext as Object);
            editeObj.Show();
        }

    
        private void cType_Selected(object sender, SelectionChangedEventArgs e)
        {
            var currPass = AgencyEntities1.GetContext().Object.ToList();


            if (cType.SelectedIndex >= 0)
            {
                var typeItem = cType.SelectedItem as ObjectType;
                currPass = AgencyEntities1.GetContext().Object.Where(p => p.TypeID == typeItem.TypeID).ToList();
            }


            list.ItemsSource = currPass;
        }

        private void cPlace_Selected(object sender, SelectionChangedEventArgs e)
        {
            var currPass = AgencyEntities1.GetContext().Object.ToList();

            if (cPlace.SelectedIndex >= 0)
            {
                var typeItem = cPlace.SelectedItem as Object;
                currPass = AgencyEntities1.GetContext().Object.Where(p => p.NumberOfRooms.Equals(typeItem.NumberOfRooms)).ToList();
            }


            list.ItemsSource = currPass;
        }

        private void cPrice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currPass = AgencyEntities1.GetContext().Object.ToList();

            var selectedIndex = cPrice.SelectedIndex;

            switch(selectedIndex)
            {
                case 0:
                    currPass = AgencyEntities1.GetContext().Object.OrderBy(p => p.Price).ToList();
                    break;
                case 1:
                    currPass = AgencyEntities1.GetContext().Object.OrderByDescending(p => p.Price).ToList();
                    break;
            }
            list.ItemsSource = currPass;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AddImage img = new AddImage(null);
            img.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            FlowDocument fd = new FlowDocument();

            Object Obj = (sender as Button).DataContext as Object;

            var images = AgencyEntities1.GetContext().Images.Where(x => x.ObjectID == Obj.ObjectID);

            Paragraph myParagraph1 = new Paragraph();
            Paragraph myParagraph2 = new Paragraph();
            Paragraph myParagraph3 = new Paragraph();
            Paragraph myParagraph4 = new Paragraph();
            Paragraph myParagraph5 = new Paragraph();
            Paragraph myParagraph6 = new Paragraph();

            FooImg fooImg = new FooImg();
            Image cover = new Image();
            var c = new BitmapImage();
            c.BeginInit();
            c.CacheOption = BitmapCacheOption.OnLoad;
            c.StreamSource = new System.IO.MemoryStream((Obj.Cover));
            c.EndInit();

            cover.Source = c;
            cover.Height = 300;
            fooImg.Img = cover;

            myParagraph1.Inlines.Add(new Run("Адрес: " + Obj.Adress)); ;
            myParagraph2.Inlines.Add(new Run("Кол-во комнат: " + Obj.NumberOfRooms)); ;
            myParagraph3.Inlines.Add(new Run("Тип: " + Obj.ObjectType.TypeName));
            myParagraph4.Inlines.Add(new Run("Стоимость: " + Obj.Price));
            myParagraph5.Inlines.Add(new Run("Сотрудник: " + Obj.Employee.FullName));
            myParagraph6.Inlines.Add(new InlineUIContainer(fooImg.Img));

            fd.Blocks.Add(myParagraph1);
            fd.Blocks.Add(myParagraph2);
            fd.Blocks.Add(myParagraph3);
            fd.Blocks.Add(myParagraph4);
            fd.Blocks.Add(myParagraph5);
            fd.Blocks.Add(myParagraph6);

            foreach (var imgs in images)
            {
                List<FooImg> items = new List<FooImg>();
                Image img = new Image();
                var i = new BitmapImage();
                i.BeginInit();
                i.CacheOption = BitmapCacheOption.OnLoad;
                i.StreamSource = new System.IO.MemoryStream((imgs.Img));
                i.EndInit();

                img.Source = i;
                img.Height = 300;
                items.Add(new FooImg { Img = img });

                foreach (var it in items)
                {
                    Paragraph myParagraphPhoto = new Paragraph();
                    myParagraphPhoto.Inlines.Add(new InlineUIContainer(img));
                    fd.Blocks.Add(myParagraphPhoto);
                }
            }

            using (var printServer = new LocalPrintServer())
            {
                try
                {
                    var dialog = new PrintDialog();
                    var qs = printServer.GetPrintQueues();
                    var queue = qs.FirstOrDefault(q => q.Name.Contains("PDF"));
                    dialog.PrintQueue = queue;
                    var paginator = ((IDocumentPaginatorSource)fd).DocumentPaginator;
                    dialog.PrintDocument(paginator, "Квартира");
                }

                catch
                {
                    MessageBox.Show("Не удалось сохранить файл");
                }

            }
        }

        public class FooImg
        {
            public Image Img { get; set; }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var currPass = AgencyEntities1.GetContext().Object.ToList();
            list.ItemsSource = currPass;
        }
    }
}
