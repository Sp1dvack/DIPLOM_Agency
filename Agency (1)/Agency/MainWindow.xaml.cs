using System.Collections.Generic;
using System.Linq;
using System.Windows;


namespace Agency
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        AgencyEntities1 db;

        public MainWindow()
        {
            InitializeComponent();
            db = new AgencyEntities1();
            List<User> users = db.User.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = tbLogin.Text.Trim();
            string password = tbPass.Password.Trim();
            if (tbLogin.Text == "" || tbPass.Password == "")
            {
                MessageBox.Show("Введите логин и пароль");
            }
            else
            {
                User auth = null;
                using (AgencyEntities1 db = new AgencyEntities1())
                {
                    auth = db.User.Where(b => b.Login == login && b.Password == password).FirstOrDefault();
                }
                if (auth != null)
                {
                    Home homepage = new Home();
                    this.Close();
                    homepage.Show();
                }
                else
                    MessageBox.Show("Неверный логин и(или) пароль");
            }
        }
    }
}
