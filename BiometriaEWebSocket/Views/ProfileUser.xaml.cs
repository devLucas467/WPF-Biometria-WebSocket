using BiometriaEWebSocket.Classes;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace BiometriaEWebSocket.Views
{
    /// <summary>
    /// Interaction logic for ProfileUser.xaml
    /// </summary>
    public partial class ProfileUser : Window
    {
        private User user;
        public ProfileUser()
        {
            InitializeComponent();
        }

        public void SetUserData(User user)
        {
            this.user = user;
            FirstNameBox.Text = user.FirstName;
            LastNameBox.Text = user.LastName;
            DescriptionBox.Text = user.Description;
            PhoneBox.Text = user.Phone;
            EmailBox.Text = user.Email;
            if (user.HasCredential)
            {
                HasCredentialBox.Content = true;
            }
            else
            {
                HasCredentialBox.Content = false;
            }
        }

    }
}
