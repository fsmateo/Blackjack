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
using MUXC = Microsoft.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Blackjack
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePage : Page
    {

        Blackjack newGame = new Blackjack();
        public GamePage()
        {
            this.InitializeComponent();
            
        }

        private void BackToMain(MUXC.NavigationView sender, MUXC.NavigationViewBackRequestedEventArgs args)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void Hit(object sender, RoutedEventArgs e)
        {
            newGame.Hit();

        }

        private void Stand(object sender, RoutedEventArgs e)
        {
            newGame.Stand();
        }
    }
}
