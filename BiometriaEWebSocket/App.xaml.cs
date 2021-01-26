using BiometriaEWebSocket.Classes;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Windows;

namespace BiometriaEWebSocket
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ObservableCollection<User> Database;

        public App()
        {
            InitializeComponent();
            Database = new ObservableCollection<User>();
            Database.Add(new User() { 
                FirstName = "Lucas",
                LastName = "Souza",
                Description = "Hajimeshite",
                Phone = "1232432",
                Email = "ululu@gmail.com",
                HasCredential = true
            });

            Database.Add(new User()
            {
                FirstName = "Hana",
                LastName = "Yokumichi",
                Description = "Ohayo minna",
                Phone = "567832",
                Email = "tamago@gmail.com",
                HasCredential = false
            });




        }

    }
}


/* 
 * 
 *         const string systemID = "00000000-0000-0000-0000-000000000001";
        const string customerID = "1";
        const string server = "172.16.100.49";
             using(var client =  new HttpClient())
            {
                client.BaseAddress = new Uri("http://" + server+ "/connected-architecture/customer/"+customerID+ "/system/" + systemID + "/user");
                try
                {
                    var responseTask = client.GetAsync(client.BaseAddress);
                    responseTask.Wait();
                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<ObservableCollection<User>>();
                        readTask.Wait();
                        Database = readTask.Result;
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.ToString());
                }
            }
 
 */