using SRV_UWP_2015V.Models;
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

        List<Student> Students;
        public SelectStudentPage()
        {
            this.InitializeComponent();
            Students = Student.GetStudents();
            comboStudents.DataContext = Students;
        }

        private async void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            Student student = comboStudents.SelectedItem as Student;
            if (student!=null)
            {                
                    Frame.Navigate(typeof(Result_Student_View), student.UserID);
                
            }
            else
            {
                var message = new MessageDialog("Please select student");
                await message.ShowAsync();
            }


        }
        private void btnHome_Click(object sender, RoutedEventArgs e)
        {

            //need log out functionality here

            Frame.Navigate(typeof(LoginPage)); //Log out and navigate to log in page

        }
    }
}
