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
    public sealed partial class EnterRegAndPassword : Page
    {
        public EnterRegAndPassword()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (CheckPassword() && CheckReg())
            {
               this.Frame.Navigate(typeof(InsertCoin));
            }
        }

        private bool CheckReg()
        {
            if (Pass_EnterReg.Password.Length == 0)
            {
                regStatusText.Text = "The registration field cannot be left empty";
                return false;
            }
            else if (Pass_EnterReg.Password.Length <= 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckPassword()
        {
            if (Pass_EnterPass.Password == "Password")
            {
                passwordStatusText.Text = " 'Password' is not allowed to be set as a password";
                return false;
            }
            else if (Pass_EnterPass.Password.Length == 0)
            {
                passwordStatusText.Text = "The password field cannot be left empty";
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
