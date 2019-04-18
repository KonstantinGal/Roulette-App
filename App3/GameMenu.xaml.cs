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

namespace App3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public class Player
    {
        public string Name { get; set; }
        public Bet Bet { get; set; }
        public Double Coins { get; set; }

    }

    public class BetChecker
    {
        private List<int> red = new List<int> { 1,3,5,7,9,12,14,16,18,19,21,23,25,27,30,32,34,36};

        public int CheckSingles(List<int> list, int rouletteNumber)
        {
            if (list.Contains(rouletteNumber))
            {
                return 1;
            }

            else
            {
                return -1;
            }
        }

        public double CheckForThirds(List<int> list, int rouletteNumber)
        {
            if (list.Contains(rouletteNumber))
            {
                return 0.33;
            }
            else
            {
                return -1;
            }
        }

        public int CheckForColor(int color)
        {
            if (red.Contains(color))
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public int CheckFirstHalf(int rouletteNumber)
        {
            if (rouletteNumber > 0 && rouletteNumber <= 18)
            {
                return 1;
            }

            else
            {
                return -1;
            }
        }

        public int CheckSecondHalf(int rouletteNumber)
        {
            if (rouletteNumber > 18 && rouletteNumber <= 36)
            {
                return 1;
            }

            else
            {
                return -1;
            }
        }
    }
    
    public sealed partial class GameMenu : Page 
    {
        public Player Player = new Player
        {
            Name = 
        };
        private Random RouletteNumberGenerator = new Random();
        private BetChecker BetChecker = new BetChecker();

        private List<int> row1 = new List<int>{ 1,4,7,10,13,16,19,22,25,28,31,34 };
        private List<int> row2 = new List<int>{ 2,5,8,11,14,17,20,23,26,29,32,35 };
        private List<int> row3 = new List<int>{ 3,6,9,12,15,18,21,24,27,30,33,36 };

        private List<int> street1 = new List<int> { 1,2,3,4,5,6,7,8,9,10,11,12 };
        private List<int> street2 = new List<int> { 12,13,14,15,16,17,18,19,20,21,22,23,24 };
        private List<int> street3 = new List<int> { 25,26,27,28,29,30,31,32,33,34,35,36 };

        private const int DoubleZero = -1;
        private const int SingleZero = -0;



        public GameMenu()
        {
            this.InitializeComponent();
            
        }

        private void BetOnSingle(object sender, RoutedEventArgs e)
        {
            var pressedButtonNumber = ((Button)sender).Content.ToString();
            Player.Bet.currentBet.Add(Convert.ToInt32(pressedButtonNumber));
        }

        private void BetOn0(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(SingleZero);
        }

        private void BetOn00(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(DoubleZero);
        }

        private void BetOnRow1(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet = row1;
        }

        private void BetOnRow2(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet = row2;
        }

        private void BetOnRow3(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet = row3;
        }

        private void BetOn1st12(object sender, RoutedEventArgs e)
        {
            
        }

        private void BetOn2nd12(object sender, RoutedEventArgs e)
        {
            
        }

        private void BetOn3rd12(object sender, RoutedEventArgs e)
        {
           
        }

        private void BetOn1to18(object sender, RoutedEventArgs e)
        {
            
        }

        private void BetOn19to36(object sender, RoutedEventArgs e)
        {
            
        }

        private void BetOnEven(object sender, RoutedEventArgs e)
        {
            
        }

        private void BetOnOdd(object sender, RoutedEventArgs e)
        {
            
        }

        private void BetOnRed(object sender, RoutedEventArgs e)
        {
            
        }

        private void BetOnBlack(object sender, RoutedEventArgs e)
        {
            
        }

    }

    public class Bet
    {
        public List<int> currentBet { get; set; }
    }
}
