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

            //pobranie wartości początkowych do wyświetlenia
            currency1.Content = bitcoin.GetPrice();
            currency2.Content = litecoin.GetPrice();
            currency3.Content = etherium.GetPrice();
            currency4.Content = 0;           

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
                currency1.Content = bitcoin.GetPrice();
                currency2.Content = litecoin.GetPrice();
                currency3.Content = etherium.GetPrice();
            }));
        }

        private void Button1Pressed(object sender, RoutedEventArgs e)
        {           
            currency4.Content = new Random().NextDouble(); //zmienia na losowego Double po wciśnięciu przycisku
        }        
    }
}
