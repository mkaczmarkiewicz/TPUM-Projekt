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
        Model model = new Model();

               

        System.Timers.Timer t;
                  
        public MainWindow()
        {
            InitializeComponent();

            //dodanie walut do marketu
            model.myMarketManager.AddCurrency(model.bitcoin);
            model.myMarketManager.AddCurrency(model.litecoin);
            model.myMarketManager.AddCurrency(model.etherium);

            //dodanie rachunków do konta użytkownika
            model.myUser.AddAccount(model.plnAccount);
            model.myUser.AddAccount(model.btcAccount);
            model.myUser.AddAccount(model.ltcAccount);
            model.myUser.AddAccount(model.ethAccount);

            //pobranie nazw wyświetlenia w currency exchange
            currency1.Content = model.bitcoin.GetName();
            currency2.Content = model.litecoin.GetName();
            currency3.Content = model.etherium.GetName();           

            //pobranie wartości początkowych do wyświetlenia
            currency1val.Content = model.bitcoin.GetPrice();
            currency2val.Content = model.litecoin.GetPrice();
            currency3val.Content = model.etherium.GetPrice();

            //pobranie nazw wyświetlenia w user data
            currency0obt.Content = model.plnAccount.GetName();
            currency1obt.Content = model.btcAccount.GetName();
            currency2obt.Content = model.ltcAccount.GetName();
            currency3obt.Content = model.ethAccount.GetName();

            //users initial wallet
            currency0obt_value.Content = model.plnAccount.GetBalance();
            currency1obt_value.Content = model.btcAccount.GetBalance();
            currency2obt_value.Content = model.ltcAccount.GetBalance();
            currency3obt_value.Content = model.ethAccount.GetBalance();

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
                model.myMarketManager.ChangeCurrenciesValues();
                currency1val.Content = model.bitcoin.GetPrice();
                currency2val.Content = model.litecoin.GetPrice();
                currency3val.Content = model.etherium.GetPrice();
            }));
        }        

        private void Buy_c1_Clicked(object sender, RoutedEventArgs e)
        {
            model.myUser.GetAccount("PLN").ChangeBalance(- Convert.ToInt32(c1_buy_input.Text) * model.myMarketManager.GetPrice("BTC"));
            currency0obt_value.Content = model.plnAccount.GetBalance();

            model.myUser.GetAccount("BTC").ChangeBalance(Convert.ToInt32(c1_buy_input.Text));
            currency1obt_value.Content = model.btcAccount.GetBalance();
        }

        private void Sell_c1_Clicked(object sender, RoutedEventArgs e)
        {
            model.myUser.GetAccount("PLN").ChangeBalance(Convert.ToInt32(c1_sell_input.Text) * model.myMarketManager.GetPrice("BTC"));
            currency0obt_value.Content = model.plnAccount.GetBalance();

            model.myUser.GetAccount("BTC").ChangeBalance(-Convert.ToInt32(c1_sell_input.Text));
            currency1obt_value.Content = model.btcAccount.GetBalance();
        }

        private void Buy_c2_Clicked(object sender, RoutedEventArgs e)
        {
            model.myUser.GetAccount("PLN").ChangeBalance(-Convert.ToInt32(c2_buy_input.Text) * model.myMarketManager.GetPrice("LTC"));
            currency0obt_value.Content = model.plnAccount.GetBalance();

            model.myUser.GetAccount("LTC").ChangeBalance(Convert.ToInt32(c2_buy_input.Text));
            currency2obt_value.Content = model.ltcAccount.GetBalance();
        }

        private void Sell_c2_Clicked(object sender, RoutedEventArgs e)
        {
            model.myUser.GetAccount("PLN").ChangeBalance(Convert.ToInt32(c2_sell_input.Text) * model.myMarketManager.GetPrice("LTC"));
            currency0obt_value.Content = model.plnAccount.GetBalance();

            model.myUser.GetAccount("LTC").ChangeBalance(-Convert.ToInt32(c2_sell_input.Text));
            currency2obt_value.Content = model.ltcAccount.GetBalance();
        }

        private void Buy_c3_Clicked(object sender, RoutedEventArgs e)
        {
            model.myUser.GetAccount("PLN").ChangeBalance(-Convert.ToInt32(c3_buy_input.Text) * model.myMarketManager.GetPrice("ETH"));
            currency0obt_value.Content = model.plnAccount.GetBalance();

            model.myUser.GetAccount("ETH").ChangeBalance(Convert.ToInt32(c3_buy_input.Text));
            currency3obt_value.Content = model.ethAccount.GetBalance();
        }

        private void Sell_c3_Clicked(object sender, RoutedEventArgs e)
        {
            model.myUser.GetAccount("PLN").ChangeBalance(Convert.ToInt32(c3_sell_input.Text) * model.myMarketManager.GetPrice("ETH"));
            currency0obt_value.Content = model.plnAccount.GetBalance();

            model.myUser.GetAccount("ETH").ChangeBalance(-Convert.ToInt32(c3_sell_input.Text));
            currency3obt_value.Content = model.ethAccount.GetBalance();
        }
    }
}
