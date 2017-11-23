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
using SecureCarparkSimulation.CarparkSimulationScripts;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SecureCarparkSimulation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            //Load from the "database" the carpark
            LocalInterface.LoadCarpark("Wheatfield");
            UpdateSpaces();
        }

        private void EnterCarparkButton(object sender, RoutedEventArgs e)
        {
            AllocateNewSpace();
        }

        private void AllocateNewSpace()
        {
            throw new NotImplementedException();
        }

        private void UpdateSpaces()
        {
            NumberOfSpacesAvailable.Text = LocalInterface.Instance.GetSpaces() + " spaces are available";
        }
    }
}
