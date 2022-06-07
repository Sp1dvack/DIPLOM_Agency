using System;
using System.Text;
using System.Windows;

namespace Agency
{
    /// <summary>
    /// Логика взаимодействия для AddType.xaml
    /// </summary>
    public partial class AddType : Window
    {
        private ObjectType _currentObject = new ObjectType();
        public AddType(ObjectType selectedObject)
        {
            InitializeComponent();

            if (selectedObject != null)
                _currentObject = selectedObject;

            DataContext = _currentObject;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_currentObject.TypeID == 0)
            {
                AgencyEntities1.GetContext().ObjectType.Add(_currentObject);
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
                    MessageBox.Show("Введите наименование");
            }
        }

        private void TextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (Char.IsDigit(e.Text, 0)) e.Handled = true;
        }
    }
}
