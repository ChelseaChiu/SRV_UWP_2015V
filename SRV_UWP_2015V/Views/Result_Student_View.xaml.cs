﻿using SRV_UWP_2015V.Models;
using SRV_UWP_2015V.Viewmodels;
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
    public sealed partial class Result_Student_View : Page
    {

        public Result_Student_View()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Proxy proxy = new Proxy();
            string id = (string)e.Parameter;
            var student = proxy.GetStudentById(id);

            stackStudentDetail.DataContext = student;
            var qualifications = proxy.GetQualificationList(id);
            comboQual.ItemsSource = qualifications;
            //foreach (var q in qualifications)
            //{
            //    comboQual.Items.Add(q.QualCode+" "+q.QualName);
            //} 
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(LoginPage)); 
        }

        private void Select_Qualification(object sender, SelectionChangedEventArgs e)
        {
            Proxy proxy = new Proxy();
            var selectedQual = comboQual.SelectedItem as string;
            //Qualification sQual = comboQual.SelectedItem as Qualification;
            //if (sQual != null)
            //{
            //    stackComp.Visibility = Visibility.Visible;
            //    stackReqUnits.DataContext = sQual;
            //    stackStudentDetail.DataContext = Student;
            //    List<Competency> compList = new List<Competency>();
            //    compList = Competency.GetCompetencyList(Student.UserID, sQual.QualCode).ToList();
            //    listBoxCompetency.ItemsSource = compList;

            //    // set progress bar
            //    progressC.Value = sQual.DoneC;
            //    progressE.Value = sQual.DoneE;
            //    progressLE.Value = sQual.DoneLE;

            //    if (Qualification.IsCompleted(sQual))
            //    {
            //        sQual.DoneTotal = sQual.TotalUnits;
            //        progressT.Value = sQual.DoneTotal;
            //        btnReqParche.IsEnabled = true;
            //    }
            //    else
            //    {
            //        sQual.DoneTotal = sQual.DoneC + sQual.DoneE + sQual.DoneLE;
            //        progressT.Value = sQual.DoneTotal;
            //    }
            //    stackUnits.DataContext = sQual;
            //    stackProg.DataContext = sQual;
            //    btnReqParche.Visibility = Visibility.Visible;
            //    Student.Qualification = sQual;


            //}
        }

        private async void Req_Parchment_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //if (Student.IsParchmentRequested(Student, Student.Qualification.QualCode))
                //{
                //    var message1 = new MessageDialog("Your request is in progress", "Please wait");
                //    await message1.ShowAsync();
                //}
                //else
                //{
                //Student.RequestParchment(Student, Student.Qualification.QualCode);
                var message = new MessageDialog("Your request is submitted.", "Success");
                await message.ShowAsync();
                //}

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
