﻿using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SecureCarparkSimulation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class IForgotMyCoin : Page
    {
        public IForgotMyCoin()
        {
            this.InitializeComponent();
        }

        private void btn_ForgotCoin_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ForgotCoin));
        }

        private void btn_ForgotPassword_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ForgotPassword));
        }
    }
}
