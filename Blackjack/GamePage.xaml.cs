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
using System.Collections.ObjectModel;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Blackjack
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePage : Page
    {
        // These need to be outside of the constructor so they can be acessed be the other methods!!!!!
        Blackjack blackjack = new Blackjack();
        ObservableCollection<String> myHand = new ObservableCollection<string>();
        

        public GamePage()
        {
            this.InitializeComponent();
            myHand.Add(blackjack.playerHand[0]);
            myHand.Add(blackjack.playerHand[1]);
           // System.Diagnostics.Debug.WriteLine(myHand[0]);
            PlayerHand.ItemsSource = myHand;


        }

        /// <summary>
        /// Returns to title screen from game page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Return_Title(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        /// <summary>
        /// Closes flyout from return to title screen if user cancels.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Flyout(object sender, RoutedEventArgs e)
        {
            ReturnToTitleFlyout.Hide();
        }

        /// <summary>
        /// Pressing settings button will bring up the options menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            CoolMenu.IsPaneOpen = !CoolMenu.IsPaneOpen;
        }

        /// <summary>
        /// Toggles option one depending on which radio button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Toggle_Option_1(object sender, RoutedEventArgs e)
        {
            // TODO: FIGURE OUT OPTION 1 AND CHANGE NAME IN XAML
        }

        // TODO: KEEP OPTIONS CHECKED BETWEEN PAGE CHANGES.

        /// <summary>
        /// Toggles option two depending on which radio button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Toggle_Option_2(object sender, RoutedEventArgs e)
        {
            // TODO: FIGURE OUT OPTION 2 AND CHANGE NAME IN XAML
        }

        
        private void Hit(object sender, RoutedEventArgs e)
        {
            blackjack.Hit();

            // Need to figure out to check for aces to minus 10 from the playerHandValue
            // make sure all fringe cases are handled as well
            // TODO: Implement and check for bust.
            if (blackjack.playerHandValue > 21)
            {
                // You busted!!! display a message and restart the game
                blackjack.nextRound();

                myHand.Clear();
                myHand.Add(blackjack.playerHand[0]);
                myHand.Add(blackjack.playerHand[1]);
               // System.Diagnostics.Debug.WriteLine(myHand[0]);
                PlayerHand.ItemsSource = myHand;
            }
        }

        private void Stand(object sender, RoutedEventArgs e)
        {
            blackjack.Stand();
        }
        
    }
}