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
    public sealed partial class SpaceFree : Page
    {
        public SpaceFree()
        {
            this.InitializeComponent();
        }

        private void Btn_EnterDiscountCode_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(discountCode));
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AndroidPay));
        }

        private void Pic_ApplePay_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ApplePay));
        }

        private void Pic_ContactLessPay_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ContactlessPay));
        }

        private void Pic_VisaOrCreditPay_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(VisaOrCreditPay));
        }

        private void Image_Tapped_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
