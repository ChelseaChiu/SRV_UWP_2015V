using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using SRV_UWP_2015V.Models;
using Windows.UI.Popups;
using SRV_UWP_2015V.WCFClient;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SRV_UWP_2015V.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        string DEFAULT_PASSWORD = "srv";
        public LoginPage()
        {
            this.InitializeComponent();
        }
        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Proxy proxy = new Proxy();
            string id = txtId.Text;
            string pw = txtPassword.Password;

            //validate if passwoed = DEFULT_PASSWORD
            if (pw != DEFAULT_PASSWORD)
            {
                var message = new MessageDialog("Please enter valid password");
                await message.ShowAsync();
            }
            else
            {
                if (proxy.Login(id))
                {
                    Frame.Navigate(typeof(SelectStudentPage));
                }
                else
                {
                    var message = new MessageDialog("Please enter valid ID");
                    await message.ShowAsync();
                }
            }


        }
    }
}
