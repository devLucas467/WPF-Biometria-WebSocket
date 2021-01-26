using BiometriaEWebSocket.Classes;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace BiometriaEWebSocket.Views
{
    /// <summary>
    /// Interaction logic for UserIndex.xaml
    /// </summary>
    public partial class UserIndex : Window
    {
        public UserIndex()
        {
            InitializeComponent();
            UsersList.ItemsSource = App.Database;
        }

        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow reg = new MainWindow();
            reg.Show();
            
            ICollectionView view = CollectionViewSource.GetDefaultView(UsersList.ItemsSource);
            view.Refresh();
        }

        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var item = sender as ListViewItem;
            if (item != null && item.IsSelected)
            {
                ProfileUser profile = new ProfileUser();
                Debug.WriteLine(item.IsSelected);
                profile.Show();
            }
        }


    }
}
