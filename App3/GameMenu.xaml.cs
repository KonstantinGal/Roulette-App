using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Gaming.UI;
using Windows.UI.Core;
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
        public Double Coins = 50;

        public void ChangeCoinNumber(double result)
        {
            Coins += result;
        }
    }

    public class BetChecker
    {


        public int CheckSingles(int bet, int rouletteNumber)
        {
            if (bet == rouletteNumber)
            {
                return 33;
            }

            else
            {
                return -1;
            }
        }

        public double CheckForStreetsRowsHalfs(List<int> list, int rouletteNumber)
        {
            if (list.Contains(rouletteNumber))
            {
                return 3;
            }
            else
            {
                return -1;
            }
        }

        public double CheckForOddEven(int rouletteNumber, int remainder)
        {
            if (rouletteNumber <= 0) return -1;

            if (rouletteNumber % 2 == remainder)
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
            Coins = 50,
            
        };
        private Random RouletteNumberGenerator = new Random();
        private BetChecker BetChecker = new BetChecker();

        private List<int> row1 = new List<int>{ 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
        private List<int> row2 = new List<int>{ 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
        private List<int> row3 = new List<int>{ 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };

        private List<int> street1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        private List<int> street2 = new List<int> { 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
        private List<int> street3 = new List<int> { 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };

        private List<int> red = new List<int> { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
        private List<int> black = new List<int> { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };

        private List<int> firstHalf = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
        private List<int> secondHalf = new List<int> { 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };

        private const int DoubleZero = -1;
        private const int SingleZero = -0;

        private double result;



        public GameMenu()
        {
            this.InitializeComponent();
            
        }

        private void BetOnSingle(object sender, RoutedEventArgs e)
        {
            var pressedButtonNumber = Convert.ToInt32(((Button)sender).Content.ToString());
            var rouletteNumber = RouletteNumberGenerator.Next(-1, 37);

            result = BetChecker.CheckSingles(pressedButtonNumber, rouletteNumber);
            ListView.Items.Add(rouletteNumber);

            if (result > 0) WinLossTextBlock.Text = "WIN! your winnings are: " + result;
            if (result < 0) WinLossTextBlock.Text = "LOSS! ";


            Player.ChangeCoinNumber(result);
            CurrentCoins.Text = Player.Coins.ToString();
        }

        private void BetOn0(object sender, RoutedEventArgs e)
        {
            result = BetChecker.CheckSingles(SingleZero,RouletteNumberGenerator.Next(-1, 37));

            ListView.Items.Add("0");

            if (result > 0) WinLossTextBlock.Text = "WIN! your winnings are: " + result;
            if (result < 0) WinLossTextBlock.Text = "LOSS! ";

            Player.ChangeCoinNumber(result);
            CurrentCoins.Text = Player.Coins.ToString();
        }

        private void BetOn00(object sender, RoutedEventArgs e)
        {
            result = BetChecker.CheckSingles(DoubleZero, RouletteNumberGenerator.Next(-1, 37));

            ListView.Items.Add("00");

            if (result > 0) WinLossTextBlock.Text = "WIN! your winnings are: " + result;
            if (result < 0) WinLossTextBlock.Text = "LOSS! ";

            Player.ChangeCoinNumber(result);
            CurrentCoins.Text = Player.Coins.ToString();
        }

        private void BetOnStreetRowsHalfs(object sender, RoutedEventArgs e)
        {
            var pressedButton = ((Button)sender).Tag.ToString();

            switch (pressedButton)
            {
                case "1st12":
                    result = BetChecker.CheckForStreetsRowsHalfs(street1, RouletteNumberGenerator.Next(-1, 37));
                    break;
                case "2nd12":
                    result = BetChecker.CheckForStreetsRowsHalfs(street2, RouletteNumberGenerator.Next(-1, 37));
                    break;
                case "3rd12":
                    result = BetChecker.CheckForStreetsRowsHalfs(street3, RouletteNumberGenerator.Next(-1, 37));
                    break;
                case "Row1":
                    result = BetChecker.CheckForStreetsRowsHalfs(row1, RouletteNumberGenerator.Next(-1, 37));
                    break;
                case "Row2":
                    result = BetChecker.CheckForStreetsRowsHalfs(row2, RouletteNumberGenerator.Next(-1, 37));
                    break;
                case "Row3":
                    result = BetChecker.CheckForStreetsRowsHalfs(row3, RouletteNumberGenerator.Next(-1, 37));
                    break;
                case "black":
                    result = BetChecker.CheckForStreetsRowsHalfs(black, RouletteNumberGenerator.Next(-1, 37));
                    break;
                case "red":
                    result = BetChecker.CheckForStreetsRowsHalfs(red, RouletteNumberGenerator.Next(-1, 37));
                    break;
                case "1stHalf":
                    result = BetChecker.CheckForStreetsRowsHalfs(red, RouletteNumberGenerator.Next(-1, 37));
                    break;
                case "2ndHalf":
                    result = BetChecker.CheckForStreetsRowsHalfs(red, RouletteNumberGenerator.Next(-1, 37));
                    break;

            }

            if (result > 0) WinLossTextBlock.Text = "WIN! your winnings are: " + result;
            if (result < 0) WinLossTextBlock.Text = "LOSS! ";

            Player.ChangeCoinNumber(result);
            CurrentCoins.Text = Player.Coins.ToString();
        }

        private void BetOnOddEven(object sender, RoutedEventArgs e)
        {
            var pressedButton = ((Button)sender).Tag.ToString();

            switch (pressedButton)
            {
                case "Odd":
                    result = BetChecker.CheckForOddEven(RouletteNumberGenerator.Next(-1, 37), 1);
                    break;
                case "Even":
                    result = BetChecker.CheckForOddEven( RouletteNumberGenerator.Next(-1, 37), 0);
                    break;
            }

            if (result > 0) WinLossTextBlock.Text = "WIN! your winnings are: " + result;
            if (result < 0) WinLossTextBlock.Text = "LOSS! ";

            Player.ChangeCoinNumber(result);
            CurrentCoins.Text = Player.Coins.ToString();
        }
    }

    public class Bet
    {
        public List<int> currentBet { get; set; }
    }
}
