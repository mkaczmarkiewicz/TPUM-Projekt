using GitBay2.Presentation;
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
using GitBay2.Logic;

namespace GitBay2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
 
        System.Timers.Timer t;

        ViewModel viewModel;
        
        public MainWindow()
        {
            
            InitializeComponent();
            //var commMgr = new CommunicationManager(8080);
            //commMgr.Begin();
            /////
            for (var i = 0; i < 10000; i++)
            GitBayAsyncClient.StartClient();
            Console.ReadLine();
            viewModel = new ViewModel();

            viewModel.InitMarket();

            /////////////////////////////////////////////////////////////////////////
            //timer
            t = new System.Timers.Timer();
            t.Interval = 2000;
            t.Elapsed += OnTimeEvent;
            t.Start();

            ////////////////////////////////////////////////////////////////////////
            //pobranie nazw wyświetlenia w currency exchange        
            currency1.Content = viewModel.FetchCurrencyName(0);
            currency2.Content = viewModel.FetchCurrencyName(1);
            currency3.Content = viewModel.FetchCurrencyName(2);

            //pobranie wartości początkowych do wyświetlenia
            currency1val.Content = viewModel.FetchPriceOfCurrency(0);
            currency2val.Content = viewModel.FetchPriceOfCurrency(1);
            currency3val.Content = viewModel.FetchPriceOfCurrency(2);
            ////////////////////////////////////////////////////////////////////////
            
            //pobranie nazw wyświetlenia w user data
            //currency0obt.Content = viewModel.FetchAccountName(0);
            // currency1obt.Content = viewModel.FetchAccountName(1);
            //currency2obt.Content = viewModel.FetchAccountName(2);
            //currency3obt.Content = viewModel.FetchAccountName(3);

            //users initial wallet
            // currency0obt_value.Content = viewModel.FetchAccountBalance(0);
            // currency1obt_value.Content = viewModel.FetchAccountBalance(1);
            //  currency2obt_value.Content = viewModel.FetchAccountBalance(2);
            //  currency3obt_value.Content = viewModel.FetchAccountBalance(3);
        }
        ////////////////////////////////////////////////////////////////////////
        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e) //zmienia kurs walut
        {
            this.Dispatcher.BeginInvoke(new Action (() =>
            {
                viewModel.ChangeCurrencyValues();
                currency1val.Content = viewModel.FetchPriceOfCurrency(0);
                currency2val.Content = viewModel.FetchPriceOfCurrency(1);
                currency3val.Content = viewModel.FetchPriceOfCurrency(2);
            }));
        }
        ////////////////////////////////////////////////////////////////////////
        /*
        private void Buy_c1_Clicked(object sender, RoutedEventArgs e)
        {
            viewModel.BuyCrypto(c1_buy_input.Text, "BTC");
    //        currency0obt_value.Content = viewModel.FetchAccountBalance(0);          
    //        currency1obt_value.Content = viewModel.FetchAccountBalance(1);
        }

        private void Sell_c1_Clicked(object sender, RoutedEventArgs e)
        {
            viewModel.SellCrypto(c1_sell_input.Text, "BTC");
      //      currency0obt_value.Content = viewModel.FetchAccountBalance(0);
      //      currency1obt_value.Content = viewModel.FetchAccountBalance(1);
        }

        private void Buy_c2_Clicked(object sender, RoutedEventArgs e)
        {
            viewModel.BuyCrypto(c2_buy_input.Text, "LTC");
      //      currency0obt_value.Content = viewModel.FetchAccountBalance(0);
       //     currency2obt_value.Content = viewModel.FetchAccountBalance(2);
        }

        private void Sell_c2_Clicked(object sender, RoutedEventArgs e)
        {
            viewModel.SellCrypto(c2_sell_input.Text, "LTC");
       //     currency0obt_value.Content = viewModel.FetchAccountBalance(0);
      //      currency2obt_value.Content = viewModel.FetchAccountBalance(2);
        }

        private void Buy_c3_Clicked(object sender, RoutedEventArgs e)
        {
            viewModel.BuyCrypto(c3_buy_input.Text, "ETH");
    //        currency0obt_value.Content = viewModel.FetchAccountBalance(0);
     //       currency3obt_value.Content = viewModel.FetchAccountBalance(3);
        }

        private void Sell_c3_Clicked(object sender, RoutedEventArgs e)
        {
            viewModel.SellCrypto(c3_sell_input.Text, "ETH");
         //   currency0obt_value.Content = viewModel.FetchAccountBalance(0);
       //     currency3obt_value.Content = viewModel.FetchAccountBalance(3);
        }*/
    }
}

/*
 * 
 * 
 * 
 //pobranie nazw wyświetlenia w currency exchange
            currency1.Content = model.bitcoin.GetName();
            currency2.Content = model.litecoin.GetName();
            currency3.Content = model.etherium.GetName();

//pobranie nazw wyświetlenia w user data
    currency1val.Content = model.bitcoin.GetPrice();
            currency2val.Content = model.litecoin.GetPrice();
            currency3val.Content = model.etherium.GetPrice();

//pobranie wartości początkowych do wyświetlenia
    currency1val.Content = model.bitcoin.GetPrice();
            currency2val.Content = model.litecoin.GetPrice();
            currency3val.Content = model.etherium.GetPrice();

    //users initial wallet
            currency0obt_value.Content = model.plnAccount.GetBalance();
            currency1obt_value.Content = model.btcAccount.GetBalance();
            currency2obt_value.Content = model.ltcAccount.GetBalance();
            currency3obt_value.Content = model.ethAccount.GetBalance();
 * */
