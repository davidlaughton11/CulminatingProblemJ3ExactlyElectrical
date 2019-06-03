/*david Laughton
 * May 29th 2019
 * J3 problem on driving with electric car
 */
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

namespace CulminatingProblemJ3ExactlyElectrical
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

        private void start_Click(object sender, RoutedEventArgs e)
        {
            string startingCoords = startingCoordinate.Text;
            double a;           
            string aString;
            double b;
            string bString;
            string[] splitStarting = startingCoords.Split(null);
            aString = splitStarting[0].ToString();
            double.TryParse(aString, out a);
            bString = splitStarting[1].ToString();
            double.TryParse(bString, out b);

            string destinationCoords = destinationCoordinate.Text;
            double c;
            string cString;
            double d;
            string dString;
            string[] splitDestination = destinationCoords.Split(null);
            cString = splitDestination[0].ToString();
            double.TryParse(cString, out c);
            dString = splitDestination[1].ToString();
            double.TryParse(dString, out d);

            double t;
            double.TryParse(chargeOfBattery.Text, out t);

            Math.Abs(a);
            Math.Abs(b);
            Math.Abs(c);
            Math.Abs(d);

            if (Math.Abs(a - c) + Math.Abs(b - d) == t)
            {
                lblOutput.Content = "Y";
            }
            else
            {
                lblOutput.Content = "N";
            }
        }
    }
}
