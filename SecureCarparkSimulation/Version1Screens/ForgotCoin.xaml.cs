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
    public sealed partial class ForgotCoin : Page
    {
        public ForgotCoin()
        {
            this.InitializeComponent();
        }

        private void btn_Continue_Click(object sender, RoutedEventArgs e)
        {
            if (CheckPassword())
            {
                this.Frame.Navigate(typeof(SpaceFree));
            }            
        }

        private bool CheckPassword()
        {
            if (Pass_EnterPass.Password.Length == 0)
            {
                passwordStatusText.Text = "The password field cannot be left empty";
                return false;
            }
            if (Pass_EnterPass.Password == "Password")
            {
                passwordStatusText.Text = " 'Password' is not allowed to be set as a password";
                return false;
            }
            else if (Pass_EnterPass.Password.Length <= 16)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
