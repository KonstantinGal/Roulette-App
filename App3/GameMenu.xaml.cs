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

        public double CheckForRows(List<int> list, int rouletteNumber)
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

        public double CheckForStreet(List<int> list, int rouletteNumber, int row)
        {
            if (rouletteNumber % 3 == row)
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

    }
    
    public sealed partial class GameMenu : Page 
    {
        private Player Player = new Player();
        private Random RouletteNumberGenerator = new Random();
        private BetChecker BetChecker = new BetChecker();

        private List<int> row1 = new List<int>{1,4,7,10,13,16,19,22,25,28,31,34};
        private List<int> row2 = new List<int>{2,5,8,11,14,17,20,23,26,29,32,35};
        private List<int> row3 = new List<int>{3,6,9,12,15,18,21,24,27,30,33,36};

        private const int DoubleZero = -2;
        private const int SingleZero = -1;

        private const int Red = -3;
        private const int Black = -4;



        public GameMenu()
        {
            this.InitializeComponent();
        }

        private void BetOn1(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(1);
        }

        private void BetOn2(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(2);
        }

        private void BetOn3(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(3);
        }

        private void BetOn4(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(4);
        }

        private void BetOn5(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(5);
        }

        private void BetOn6(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(6);
        }

        private void BetOn7(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(7);
        }

        private void BetOn8(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(8);
        }

        private void BetOn9(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(9);
        }

        private void BetOn10(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(10);
        }

        private void BetOn11(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(11);
        }

        private void BetOn12(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(12);
        }

        private void BetOn13(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(13);
        }

        private void BetOn14(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(14);
        }

        private void BetOn15(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(15);
        }

        private void BetOn16(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(16);
        }

        private void BetOn17(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(17);
        }

        private void BetOn18(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(18);
        }

        private void BetOn20(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(20);
        }

        private void BetOn19(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(19);
        }

        private void BetOn21(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(21);
        }

        private void BetOn22(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(22);
        }

        private void BetOn23(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(23);
        }

        private void BetOn24(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(24);
        }

        private void BetOn25(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(25);
        }

        private void BetOn26(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(26);
        }

        private void BetOn27(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(27);
        }

        private void BetOn28(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(28);
        }

        private void BetOn29(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(29);
        }

        private void BetOn30(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(30);
        }

        private void BetOn31(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(31);
        }

        private void BetOn32(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(32);
        }

        private void BetOn33(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(33);
        }

        private void BetOn34(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(34);
        }

        private void BetOn35(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(35);
        }

        private void BetOn36(object sender, RoutedEventArgs e)
        {
            Player.Bet.currentBet.Add(36);
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
