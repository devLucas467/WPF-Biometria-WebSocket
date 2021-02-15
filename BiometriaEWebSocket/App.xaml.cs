using BiometriaEWebSocket.Classes;
using BiometriaEWebSocket.Controllers;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows;
using System.Windows.Documents;

namespace BiometriaEWebSocket
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ObservableCollection<User> Database;
        public static UserController UserController;

        public App()
        {
            InitializeComponent();
            UserController.Authentication();
            Database = new ObservableCollection<User>();
            try
            {
                Database = UserController.GetAllUsers();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Erro no request de usuarios");
                throw;
            }
            
        }


    }
}


