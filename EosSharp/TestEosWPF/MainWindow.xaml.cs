using EosSharp;
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

namespace TestEosWPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _Result;

        public string Result
        {
            get { return _Result; }
            set
            {
                LabelA.Content = value;
                _Result = value;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        public async Task CheckAsync()
        {
            Eos eos = new Eos(new EosConfigurator()
            {
                HttpEndpoint = "https://nodes.eos42.io", //Mainnet
                ChainId = "aca376f206b8fc25a6ed44dbdc66547c36c6c33e3a119ffbeaef943642f0e906",
                ExpireSeconds = 60,
                SignProvider = new DefaultSignProvider("myprivatekey")
            });

            var result = await eos.GetInfo();
            Result = result.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CheckAsync();
        }
    }
}
