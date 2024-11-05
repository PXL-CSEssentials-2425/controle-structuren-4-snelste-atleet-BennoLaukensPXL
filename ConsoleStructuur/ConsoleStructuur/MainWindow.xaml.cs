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

namespace ConsoleStructuur
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        StringBuilder sb = new StringBuilder();
        string nameFastest;
        int secondsFastest = 0;

        private void newBtn_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(timeTxtBox.Text, out int secondsCurrent))
            {
                if (secondsFastest == 0 || secondsCurrent < secondsFastest)
                {
                    secondsFastest = secondsCurrent;
                    nameFastest = nameTxtBox.Text;
                }
            }

            nameTxtBox.Clear();
            timeTxtBox.Clear();
            //nameTxtBox.Text = string.Empty;
            //timeTxtBox.Text = string.Empty;

        }
        

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            nameTxtBox.Clear();
            timeTxtBox.Clear();
            resultTxtBox.Clear();
            sb.Clear();

            nameTxtBox.Focus();
        }

        private void fastestBtn_Click(object sender, RoutedEventArgs e)
        {
            sb.Clear();
            int seconds;
            int minutes;
            int hours;

            seconds = secondsFastest;
            minutes = seconds / 60;
            hours = minutes / 60;

            minutes -= hours * 60;
            seconds -= minutes * 60 + hours * 3600;

            sb.AppendLine($"De snelste atleet is {nameFastest}");
            sb.AppendLine($"totaal aantal seconden: {secondsFastest}");
            sb.AppendLine();
            sb.AppendLine($"aantal uren: {hours}");
            sb.AppendLine($"aantal minuten: {minutes}");
            sb.AppendLine($"aantal seconden: {seconds}");
            resultTxtBox.Text = sb.ToString();
        }
        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
