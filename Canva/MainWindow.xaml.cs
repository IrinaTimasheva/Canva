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

namespace Canva
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

        

        private void kord_canva(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
            Point point = e.GetPosition(canvas);
            Canvas.SetLeft(recta, point.X);
            Canvas.SetTop(recta, point.Y);
            tblock.Text = "Координаты курсора:" + point.ToString();
            }
        }

        private void key(object sender, KeyEventArgs e)
        {
            Key key = e.Key;
            tblock.Text = ((int)key).ToString();
            tblock.Text =  "Последняя нажатая клавиша:" + key.ToString();
        }

        private void canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
