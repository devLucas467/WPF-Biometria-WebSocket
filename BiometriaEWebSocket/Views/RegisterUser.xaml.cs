using BiometriaEWebSocket.Classes;
using BiometriaEWebSocket.Controllers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BiometriaEWebSocket
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private User RegUser;
        public MainWindow()
        {
            InitializeComponent();
            RegUser = new User();
        }

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            RegUser.FirstName = FirstNameBox.Text;
            RegUser.LastName = LastNameBox.Text;
            RegUser.Description = DescriptionBox.Text;
            RegUser.Phone = PhoneBox.Text;
            RegUser.Email = EmailBox.Text;
            RegUser.HasCredential = CheckCredential.IsChecked == true ? true : false;
            //chamada de API
            //Fazer um Post com os dados do usuario
            UserController.CreateUser(RegUser);
            App.Database.Add(RegUser);
            Close();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
        }

    }
}
