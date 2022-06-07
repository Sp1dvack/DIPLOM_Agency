using System;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Agency
{
    /// <summary>
    /// Логика взаимодействия для Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
            GridBackground.Children.Add(new Dapartment());
        }

        private void selectItem(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;

            switch (index)
            {
                case 0:
                    GridBackground.Children.Clear();
                    GridBackground.Children.Add(new Dapartment());
                    break;
                case 1:
                    GridBackground.Children.Clear();
                    GridBackground.Children.Add(new Employeers());;
                    break;
                case 2:
                    GridBackground.Children.Clear();
                    GridBackground.Children.Add(new ObjectPage());
                    break;
                case 3:
                    GridBackground.Children.Clear();
                    GridBackground.Children.Add(new Photo());
                    break;
                case 4:
                    GridBackground.Children.Clear();
                    GridBackground.Children.Add(new TypePage());
                    break;
            }
        }

    }
}
