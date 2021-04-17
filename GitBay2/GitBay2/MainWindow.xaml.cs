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
        User myUser = new User();
        Account plnAccount = new Account("PLN", 10000);
        Account btcAccount = new Account("BTC", 0);
        Account ltcAccount = new Account("LTC", 0);
        Account ethAccount = new Account("ETH", 0);

        MarketManager myMarketManager = new MarketManager();
        Currency bitcoin = new Currency("BTC", 250);
        Currency litecoin = new Currency("LTC", 10);
        Currency etherium = new Currency("ETH", 99);        

        System.Timers.Timer t;
                  
        public MainWindow()
        {
            InitializeComponent();

            //dodanie walut do marketu
            myMarketManager.AddCurrency(bitcoin);
            myMarketManager.AddCurrency(litecoin);
            myMarketManager.AddCurrency(etherium);

            //dodanie rachunków do konta użytkownika
            myUser.AddAccount(plnAccount);
            myUser.AddAccount(btcAccount);
            myUser.AddAccount(ltcAccount);
            myUser.AddAccount(ethAccount);

            //pobranie nazw wyświetlenia w currency exchange
            currency1.Content = bitcoin.GetName();
            currency2.Content = litecoin.GetName();
            currency3.Content = etherium.GetName();           

            //pobranie wartości początkowych do wyświetlenia
            currency1val.Content = bitcoin.GetPrice();
            currency2val.Content = litecoin.GetPrice();
            currency3val.Content = etherium.GetPrice();

            //pobranie nazw wyświetlenia w user data
            currency0obt.Content = plnAccount.GetName();
            currency1obt.Content = btcAccount.GetName();
            currency2obt.Content = ltcAccount.GetName();
            currency3obt.Content = ethAccount.GetName();

            //users initial wallet
            currency0obt_value.Content = plnAccount.GetBalance();
            currency1obt_value.Content = btcAccount.GetBalance();
            currency2obt_value.Content = ltcAccount.GetBalance();
            currency3obt_value.Content = ethAccount.GetBalance();

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

        private void Buy_c1_Clicked(object sender, RoutedEventArgs e)
        {
            myUser.GetAccount("PLN").ChangeBalance(-1 * myMarketManager.GetPrice())
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
