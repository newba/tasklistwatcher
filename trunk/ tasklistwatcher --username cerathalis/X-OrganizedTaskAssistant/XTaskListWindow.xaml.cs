using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Collections;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace X_Hub
{
    /// <summary>
    /// Interaction logic for XTaskListWindow.xaml
    /// </summary>
    public partial class XTaskListWindow : Window
    {
        private XHubWindow ParentWindow;

        public XTaskListWindow(XHubWindow input)
        {
            InitializeComponent();
            ParentWindow = input;
            listoftasks = null;
        }

        private ArrayList listoftasks;
        public ArrayList ListOfTasks
        {
            get
            {
                return listoftasks;
            }
            set
            {
                listoftasks = value;
            }
        }

        public void DisplayList()
        {

            Brush wBrush = new SolidColorBrush(Colors.White);
            Brush bBrush = new SolidColorBrush(Colors.Black);
            Brush gBrush = new SolidColorBrush(Colors.WhiteSmoke);

            Thickness marpad = new Thickness();
            marpad.Bottom = 1;
            marpad.Left = 1;
            marpad.Right = 1;
            marpad.Top = 1;

            int counter = 1;
            int remainder = 0;

            foreach (BaseTask x in listoftasks)
            {
                
                Expander exptemp = new Expander();

                exptemp.Header = "Rank: " + x.TaskRank.ToString() + "Sev: " + x.TaskSeverity.ToString() + " Summary: " + x.Summary;
                exptemp.Name = "Task" + x.TaskRank.ToString();

                Math.DivRem( counter++, 2,out remainder);

                if(remainder != 0)
                    exptemp.Background = wBrush;
                else
                    exptemp.Background = gBrush;
                exptemp.BorderBrush = bBrush;
                exptemp.Margin = marpad;
                exptemp.Padding = marpad;
                TextBlock tb = new TextBlock();
                tb.TextWrapping = TextWrapping.Wrap;
                tb.Inlines.Add(new Bold(new Run("Creation Date: ")));
                tb.Inlines.Add(x.Creation.ToString() + "\n");
                tb.Inlines.Add(new Bold(new Run("Due Date: ")));
                tb.Inlines.Add(x.DueDate.ToString() + "\n");
                tb.Inlines.Add(new Bold(new Run("Status: ")));
                tb.Inlines.Add(x.Status + "\n");
                tb.Inlines.Add(new Bold(new Run("Reminder Types: ")));
                tb.Inlines.Add("-Not Completed\n");
                tb.Inlines.Add(new Bold(new Run("Description:\n")));
                tb.Inlines.Add(x.Description);

                exptemp.Content = tb;

                ListStacker.Children.Add(exptemp);
            }
        }

        private void TLMouseOverTitle(object sender, MouseEventArgs e)
        {
            SolidColorBrush Green = new SolidColorBrush();
            Green.Color = Colors.Green;
            HeaderTxt.Foreground = Green;
        }
        private void TLMouseLeaveTitle(object sender, MouseEventArgs e)
        {
            SolidColorBrush white = new SolidColorBrush();
            white.Color = Colors.White;
            HeaderTxt.Foreground = white;
        }
        private void DockTLW_Click(object sender, RoutedEventArgs e)
        {
            double LeftOrient = 0;
            double TopOrient = 0;
            

            LeftOrient = ParentWindow.Left;
            TopOrient = ParentWindow.Top + ParentWindow.Height;
            this.Left = LeftOrient;
            this.Top = TopOrient;           
        }
        private void CloseTLW_Click(object sender, RoutedEventArgs e)
        {
            ParentWindow.TAWClose = true;
            this.Close();
        }

        private void MouseDragListTitle(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
