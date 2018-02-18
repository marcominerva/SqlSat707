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

namespace SqlClientUwpApp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void LoadEmployees_Click(object sender, RoutedEventArgs e)
        {
            var employees = NorthwindData.Northwind.LoadEmployeesFromDatabase();
            var results = employees.Select().Select(d => new
            {
                EmployeeId = Convert.ToInt32(d["EmployeeID"]),
                FirstName = d["FirstName"].ToString(),
                LastName = d["LastName"].ToString(),
                Title = d["Title"].ToString()
            });

            EmployeesListView.ItemsSource = results;
        }
    }
}
