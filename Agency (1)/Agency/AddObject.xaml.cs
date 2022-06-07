using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Imaging;

namespace Agency
{
    /// <summary>
    /// Логика взаимодействия для AddObject.xaml
    /// </summary>
    public partial class AddObject : Window
    {
        private Object _currentObject = new Object();
        OpenFileDialog Op = new OpenFileDialog();
        public AddObject(Object selectedObject)
        {
            InitializeComponent();

            comboType.ItemsSource = AgencyEntities1.GetContext().ObjectType.ToList();
            comboEmp.ItemsSource = AgencyEntities1.GetContext().Employee.ToList();



            if (selectedObject != null)
                _currentObject = selectedObject;

            DataContext = _currentObject;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          

            try
            {
                if (_currentObject.ObjectID == 0)
                {
                   
                    _currentObject.Cover = File.ReadAllBytes(Op.FileName);
                    AgencyEntities1.GetContext().Object.Add(_currentObject);
                    AgencyEntities1.GetContext().SaveChanges();
                    MessageBox.Show("Сохранено");
                    this.Close();
                } 
            }

            catch 
            {
                string error = "";
                if (place.Text == "")
                    error += "Введите кол-во комнат \n";
                if (adress.Text == "")
                    error += "Введите адрес \n";
                if (price.Text == "")
                    error += "Введите стоимость \n";
                if (comboType.SelectedItem == null)
                    error += "Выберите тип \n";
                if (comboEmp.SelectedItem == null)
                    error += "Выберите сотрудника \n";
                if (_currentObject.Cover == null)
                    error += "Выберите обложку \n";

                MessageBox.Show(error);
            }
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Op.Title = "image selection";
            Op.Filter = "JPG(.jpg)|*.jpg|PNG(.png)|*.png|JPEG(.jpeg)|*.jpeg";

            if (Op.ShowDialog() == true)
            {
                img1.Source = new BitmapImage(new Uri(Op.FileName));
            }

        }

        private void place_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {

          if (!Char.IsDigit(e.Text, 0) & place.Text.Length <= place.MaxLength) e.Handled = true;

        }

        private void price_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0) & price.Text.Length <= price.MaxLength) e.Handled = true;
        }
    }
}

