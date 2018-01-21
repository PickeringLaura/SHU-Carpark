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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SecureCarparkSimulation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class discountCode : Page
    {
        public discountCode()
        {
            this.InitializeComponent();
        }

        private void btn_Continue_Click(object sender, RoutedEventArgs e)
        {
            if (CheckDiscountCode())
            {
                this.Frame.Navigate(typeof(SpaceFree));
            }
        }

        private bool CheckDiscountCode()
        {
            if (pass_EnterDiscount.Password == "BN123")
            {
                return true;
            }
            else if (pass_EnterDiscount.Password == "TH589")
            {
                return true;
            }
            else if (pass_EnterDiscount.Password == "CK490")
            {
                return true;
            }
            else
            {
                DiscountStatusText.Text = "This discount code is invalid";
                return false;
            }
        }
    }
}
