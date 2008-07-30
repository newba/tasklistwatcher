using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numeric;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace X_Hub
{
    /// <summary>
    /// Interaction logic for CustNumericUpDown.xaml
    /// </summary>
    public partial class CustNumericUpDown : UserControl
    {
        public CustNumericUpDown()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            int numeric = 0;
            if (int.TryParse(Input.Text.ToString(), out numeric) == true)
            {
                Input.Text = (++numeric).ToString();
            }
            else
                Input.Text = "0";
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            int numeric = 0;
            if (int.TryParse(Input.Text.ToString(), out numeric) == true)
            {
                Input.Text = (--numeric).ToString();
            }
            else
                Input.Text = "0";

        }
        private void NumericCheck(object sender, RoutedEventArgs e)
        {
            int numeric = 0;
            if (int.TryParse(Input.Text.ToString(), out numeric) == false)
            {
                Input.Text = "0";
            }
        }
        public int GetIntValue()
        {
            return (System.Convert.ToInt32(Input.Text));
        }
        public void SetIntValue(int curval)
        {
            Input.Text = curval.ToString();
        }
    }
}
