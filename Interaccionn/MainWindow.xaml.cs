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

namespace Interaccionn
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnBoton.Click += BtnBoton_Click;
                                                                                        
        }

        private void BtnBoton_Click(object sender, RoutedEventArgs e)
        {
            lblHolaMundo.Text = "Adios guorl UnU";
            lblHolaMundo.FontSize = 35;
            lblHolaMundo.Foreground = Brushes.DarkRed;
        }

        private void BtnBoton2_Click(object sender, RoutedEventArgs e)
        {
            lblHolaMundo.Text = "Naa te creas no estoy morido XD";
            lblHolaMundo.FontSize = 20;
            lblHolaMundo.Foreground = Brushes.Blue;
        }

        private void BtnBoton3_Click(object sender, RoutedEventArgs e)
        {
            lblHolaMundo.Text = "ARRIBA ESPAÑA!!!";
            lblHolaMundo.FontSize = 100;
            lblHolaMundo.Foreground = Brushes.Red;
        }
    }
}
