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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SRV_UWP_2015V.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            this.InitializeComponent();
        }
        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {

                string userid = txtId.Text;
                //string password = txtPassword.Password.ToString();
                User user = new User();
                if (user.Login(userid)) 
                {
                    Frame.Navigate(typeof(Result_Student_View), userid);   
                }
                else
                {
                    var message = new MessageDialog("Please enter valid ID");
                    await message.ShowAsync();
                }
            }



        
    }
}
