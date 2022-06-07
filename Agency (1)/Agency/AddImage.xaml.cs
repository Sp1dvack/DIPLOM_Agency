using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Agency
{
    /// <summary>
    /// Логика взаимодействия для AddImage.xaml
    /// </summary>
    public partial class AddImage : Window
    {
        OpenFileDialog Op = new OpenFileDialog();
        private Images _currentImg = new Images();

        public AddImage(Images selectedImg)
        {
            InitializeComponent();
            if (selectedImg != null)
                _currentImg = selectedImg;

            comboObject.ItemsSource = AgencyEntities1.GetContext().Object.ToList();

            DataContext = _currentImg;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Op.Title = "image selection";
            Op.Filter = "JPG(.jpg)|*.jpg|PNG(.png)|*.png|JPEG(.jpeg)|*.jpeg";

            if (Op.ShowDialog() == true)
            {
                img1.Source = new BitmapImage(new Uri(Op.FileName));
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_currentImg.ImgID == 0)
                {
                    _currentImg.Img= File.ReadAllBytes(Op.FileName);
                    AgencyEntities1.GetContext().Images.Add(_currentImg);
                    AgencyEntities1.GetContext().SaveChanges();
                    MessageBox.Show("Сохранено");
                    this.Close();
                }
            }

            catch 
            {
                string error = "";
                if (comboObject.SelectedItem == null)
                    error+="Выберите объект\n";
                if (_currentImg.Img == null)
                    error += "Выберите фото";
                MessageBox.Show(error);
            }
            
           
        }
    }
}
