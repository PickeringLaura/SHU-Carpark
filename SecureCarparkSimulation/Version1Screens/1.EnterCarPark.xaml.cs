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
using SecureCarparkSimulation.Version1Screens;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SecureCarparkSimulation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        TextBlock[] txtBlcks;

        Button[] buttons;

        public MainPage()
        {
            this.InitializeComponent();

            //Load from the "database" the carpark
            LocalInterface.LoadCarpark("Wheatfield");

            txtBlcks = new TextBlock[] { txt_space1, txt_space2, txt_space3, txt_space4, txt_space5, txt_space6, txt_space7, txt_space8, txt_space9, txt_space10, txt_space11, txt_space12, txt_space13, txt_space14, txt_space15, txt_space16, txt_space17, txt_space18 };

            UpdateSpaces();
        }

        private void EnterCarparkButton(object sender, RoutedEventArgs e)
        {
            AllocateNewSpace();
        }

        private void AllocateNewSpace()
        {
            Space space = CarparkManager.Instance.GetCarpark(3).nextAvailableCarParkingSpace();
            space.SetAllocated(true);
            txtBlcks[space.GetId()].Text = "Locked";
        }

        private void UpdateSpaces()
        {
            txt_NumberOfSpaces.Text = LocalInterface.Instance.GetSpaces() + " spaces available.";
        }

        private void spaces_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void txt_NumberOfSpaces_SelectionChanged_1(object sender, RoutedEventArgs e)
        {

        }

        private void txt_cannotAdd_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged_1(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Enter_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CoinDispensed));
        }

        private void btn_AddNewCar_Click(object sender, RoutedEventArgs e)
        {
            txt_NumberOfSpaces.Text = CarparkManager.Instance.GetCarpark(3).GetEmptySpaces().ToString();
            AllocateNewSpace();
        }

        private void txt_space1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(amountDueBay1));
        }
    }
}
