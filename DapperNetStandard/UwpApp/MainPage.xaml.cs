﻿using DapperNetStandard;
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

namespace UwpApp
{
    public sealed partial class MainPage : Page
    {
        private const string ConnectionString = @"";

        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void FindPlacesButton_Click(object sender, RoutedEventArgs e)
        {
            var db = new Places(ConnectionString);
            var data = await db.SearchAsync(QueryTextBox.Text);
            PlacesListView.ItemsSource = data;
        }
    }
}
