using GitBay2.Logic;
using GitBay2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Timers;

namespace GitBay2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MarketManager myMarketManager = new MarketManager();
        Currency bitcoin = new Currency("BTC", 250);
        Currency litecoin = new Currency("LTC", 10);
        Currency etherium = new Currency("ETH", 990);

        System.Timers.Timer t;
                  
        public MainWindow()
        {
            InitializeComponent();

            //dodanie altcoinów do marketu
            myMarketManager.AddCurrency(bitcoin);
            myMarketManager.AddCurrency(litecoin);
            myMarketManager.AddCurrency(etherium);

            //pobranie nazw wyświetlenia w currency exchange
            currency1.Content = bitcoin.GetName();
            currency2.Content = litecoin.GetName();
            currency3.Content = etherium.GetName();

            //pobranie nazw wyświetlenia w user data
            currency1obt.Content = bitcoin.GetName();
            currency2obt.Content = litecoin.GetName();
            currency3obt.Content = etherium.GetName();

            //pobranie wartości początkowych do wyświetlenia
            currency1val.Content = bitcoin.GetPrice();
            currency2val.Content = litecoin.GetPrice();
            currency3val.Content = etherium.GetPrice();
            //currency4.Content = 0;           

            

            //timer
            t = new System.Timers.Timer();
            t.Interval = 2000;
            t.Elapsed += OnTimeEvent;
            t.Start();        
            //
        }

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e) //zmienia kurs walut
        {
            this.Dispatcher.BeginInvoke(new Action (() =>
            {
                myMarketManager.ChangeCurrenciesValues();
                currency1val.Content = bitcoin.GetPrice();
                currency2val.Content = litecoin.GetPrice();
                currency3val.Content = etherium.GetPrice();
            }));
        }

        private void Button1Pressed(object sender, RoutedEventArgs e)
        {           
            //currency4.Content = new Random().NextDouble(); //zmienia na losowego Double po wciśnięciu przycisku
        }

        private void Buy_c1_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private void Sell_c1_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private void Buy_c2_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private void Sell_c2_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private void Buy_c3_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private void Sell_c3_Clicked(object sender, RoutedEventArgs e)
        {

        }
    }
}
