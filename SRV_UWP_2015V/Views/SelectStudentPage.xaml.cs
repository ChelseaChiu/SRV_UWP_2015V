using SRV_UWP_2015V.Models;
using SRV_UWP_2015V.WCFClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SRV_UWP_2015V.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SelectStudentPage : Page
    {
        public SelectStudentPage()
        {
            this.InitializeComponent();
            this.Loaded += new RoutedEventHandler(Page_Load);
        }
        private void Page_Load(object sender, RoutedEventArgs e)
        {
            Proxy proxy = new Proxy();
            var students = proxy.GetStudentList();
            comboStudents.ItemsSource = students;
            foreach (var s in students)
            {
                s.
            }
        }

        private async void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            Proxy proxy = new Proxy();
            string id = comboStudents.SelectedItem.ToString();
            var student = proxy.GetStudentById(id);

            if (student!=null)
            {                
                    Frame.Navigate(typeof(Result_Student_View), id);
            }
            else
            {
                var message = new MessageDialog("Please select student");
                await message.ShowAsync();
            }


        }
        private void btnHome_Click(object sender, RoutedEventArgs e)
        {

            Frame.Navigate(typeof(LoginPage)); 

        }
    }
}
