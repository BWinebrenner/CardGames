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
using Deck1;
using Card1;


namespace HitOrStay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int f = 0;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Hit_Click(object sender, RoutedEventArgs e)
        {
            Label[] player = new Label[5];
            player[0] = player1;
            player[1] = player2;
            player[2] = player3;
            player[3] = player4;
            player[4] = player5;
            player[f].Content = BlackJackEngine.Hit();
            if (f < 4)
            {
                f++;
            }
            else
            {
                f = 0;
            }
        }


        private void Stay_Click(object sender, RoutedEventArgs e)
        {

        }
    }

}
