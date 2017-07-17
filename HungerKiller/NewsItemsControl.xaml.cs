﻿using HungerKiller.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace HungerKiller
{
    public sealed partial class NewsItemsControl : UserControl
    {
        public Model.NewsItem NewsItem { get { return this.DataContext as Model.NewsItem; } }
        public NewsItemsControl()
        {
            this.InitializeComponent();
            this.DataContextChanged += (s, e) => Bindings.Update();
        }

        private void MyImage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame root = Window.Current.Content as Frame;
            root .Navigate(typeof(introduce), NewsItem.Id);
        }
    }
}
