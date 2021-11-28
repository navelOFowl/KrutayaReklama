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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KrutayaReklama
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttExit_Click(object sender, RoutedEventArgs e)
        {
            buttExit.Content = "КНОПКА";

            tb1.Visibility = Visibility.Visible;
            DoubleAnimation First = new DoubleAnimation();
            First.From = 5;
            First.To = 50;
            First.Duration = TimeSpan.FromSeconds(1);
            First.RepeatBehavior = RepeatBehavior.Forever;
            First.AutoReverse = true;

            tb2.Visibility = Visibility.Visible;
            tbNot1.Visibility = Visibility.Visible;
            tbNot2.Visibility = Visibility.Visible;
            tbNot3.Visibility = Visibility.Visible;

            tb1.BeginAnimation(HeightProperty, First);
            tb2.BeginAnimation(HeightProperty, First);
            tbNot1.BeginAnimation(HeightProperty, First);
            tbNot2.BeginAnimation(HeightProperty, First);
            tbNot3.BeginAnimation(HeightProperty, First);


            ColorAnimation Down = new ColorAnimation();
            Color cStart = Color.FromRgb(255, 0, 0);
            tbDown.Foreground = new SolidColorBrush(cStart);
            Down.From = cStart;
            Down.To = Color.FromRgb(0, 0, 255);
            Down.Duration = TimeSpan.FromSeconds(1);
            Down.RepeatBehavior = RepeatBehavior.Forever;
            Down.AutoReverse = true;
            tbDown.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, Down);

            DoubleAnimation Ad = new DoubleAnimation();
            Ad.From = 5;
            Ad.To = 250;
            Ad.Duration = TimeSpan.FromSeconds(1);
            Ad.RepeatBehavior = RepeatBehavior.Forever;
            Ad.AutoReverse = true;
            tbAd.BeginAnimation(WidthProperty, Ad);

            DoubleAnimation Button = new DoubleAnimation();
            First.From = 5;
            First.To = 50;
            First.Duration = TimeSpan.FromSeconds(1);
            First.RepeatBehavior = RepeatBehavior.Forever;
            First.AutoReverse = true;
            buttExit.BeginAnimation(HeightProperty, First);
            buttExit.BeginAnimation(WidthProperty, Ad);
        }
    }
}
