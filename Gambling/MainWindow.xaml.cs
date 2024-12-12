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

namespace Gambling
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        string[] emojis = new string[] { "😶", "😮", "😐", "😑", "😯", "😉" };
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Start_Click(object sender, RoutedEventArgs e)
        {
            Start.IsEnabled = false;
            int scor = 0;


            Slot1.Content = chooseicon();
            Slot2.Content = chooseicon();
            Slot3.Content = chooseicon();

            await Task.Delay(2000);

            if (Slot1 == Slot2.Content && Slot2.Content == Slot3.Content)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Beep();
                }
                Score.Content = scor+50;
            }
            Start.IsEnabled = true;
        }

        private string chooseicon()
        {
            int x = random.Next(1, 1);
            string Icon = emojis[x];
            Console.Beep();

            return Icon;
        }
    }
}
