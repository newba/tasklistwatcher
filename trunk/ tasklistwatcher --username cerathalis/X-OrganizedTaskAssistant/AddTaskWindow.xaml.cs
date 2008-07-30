using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
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
    /// Interaction logic for AddTaskWindow.xaml
    /// </summary>
    public partial class AddTaskWindow : Window
    {
        private XHubWindow ParentWindow;
        private XTaskListWindow TaskListWindow;
        private BaseTask CurrentTask;
        private int LastTaskRank;

        public AddTaskWindow(XHubWindow pWindow, XTaskListWindow tWindow)
        {
            InitializeComponent();
            ParentWindow = pWindow;
            TaskListWindow = tWindow;
            CurrentTask = null;
            LastTaskRank = 0;            
        }

        public void SetTask(BaseTask InputTask)
        {
            CurrentTask = InputTask;
            if (CurrentTask != null)
            {
                TRank.SetIntValue(InputTask.TaskRank);
                LastTaskRank = InputTask.TaskRank;
            }
        }
        public BaseTask GetTask()
        {
            return CurrentTask;
        }

        private void MouseDragAddTitle(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void AllowAlerts(object sender, RoutedEventArgs e)
        {
            EmailAlrt.IsEnabled = true;
            PopupAlrt.IsEnabled = true;
            SoundAlrt.IsEnabled = true;
            CmdAlrt.IsEnabled = true;
        }

        private void ClearAlerts(object sender, RoutedEventArgs e)
        {
            if (NoAlerts.IsChecked == true && EmailAlrt != null)
            {
                EmailAlrt.IsChecked = false;
                EmailAlrt.IsEnabled = false;
            }
            if (NoAlerts.IsChecked == true && PopupAlrt != null)
            {
                PopupAlrt.IsChecked = false;
                PopupAlrt.IsEnabled = false;
            }
            if (NoAlerts.IsChecked == true && SoundAlrt != null)
            {
                SoundAlrt.IsChecked = false;
                SoundAlrt.IsEnabled = false;
            }
            if (NoAlerts.IsChecked == true && CmdAlrt != null)
            {
                CmdAlrt.IsChecked = false;
                CmdAlrt.IsEnabled = false;
            }
        }

        private void DockTLW_Click(object sender, RoutedEventArgs e)
        {
            double LeftOrient = 0;
            double TopOrient = 0;


            LeftOrient = ParentWindow.Left - ParentWindow.Width;
            TopOrient = ParentWindow.Top + ParentWindow.Height;
            this.Left = LeftOrient;
            this.Top = TopOrient;  
        }

        private void CloseTLW_Click(object sender, RoutedEventArgs e)
        {
            ParentWindow.ADWClose = true;
            this.Close();
        }

        private void AddBTN_Click(object sender, RoutedEventArgs e)
        {
            

            //SetCreation Date.
            //CurrentTask.Creation = DateTime.Now;
            CurrentTask.LastModified = DateTime.Now;

            if (CurrentTask.Creation == null)
                CurrentTask.Creation = CurrentTask.LastModified;

            //Critical = 0, High = 1, Medium = 2, Low = 3, AnyTime = 4
            if (TSevLevelCB.SelectedIndex != -1)
            {
                ListBoxItem lbi = (TSevLevelCB.SelectedItem as ListBoxItem);
                if (lbi.Content.ToString() == "Critical")
                    CurrentTask.TaskSeverity = SeverityLevel.Critical;
                else if (lbi.Content.ToString() == "High")
                    CurrentTask.TaskSeverity = SeverityLevel.High;
                else if (lbi.Content.ToString() == "Medium")
                    CurrentTask.TaskSeverity = SeverityLevel.Medium;
                else if (lbi.Content.ToString() == "Low")
                    CurrentTask.TaskSeverity = SeverityLevel.Low;
                else if (lbi.Content.ToString() == "AnyTime")
                    CurrentTask.TaskSeverity = SeverityLevel.AnyTime;
                else
                    CurrentTask.TaskSeverity = SeverityLevel.AnyTime;
            }
            else
                CurrentTask.TaskSeverity = SeverityLevel.AnyTime;

            //This Number will be set by a function to be implimented.
            CurrentTask.TaskRank = TRank.GetIntValue();
            CurrentTask.Status = StatusTxt.Text;
            CurrentTask.DueDate = DueDateTxt.Text;
            CurrentTask.Summary = TaskSummary.Text;
            CurrentTask.Description = TaskDescripTxt.Text;
            
            //RunDown CheckBox logic
            if (NoAlerts.IsChecked == false)
            {//There are alerts
                if (EmailAlrt.IsChecked == true)
                {
                    CurrentTask.Aemail = true;
                    CurrentTask.Email = EmailInput.Text;
                }
                if (PopupAlrt.IsChecked == true)
                {
                    CurrentTask.Apopup = true;
                }
                if (CmdAlrt.IsChecked == true)
                {
                    CurrentTask.Acommand = true;
                    CurrentTask.Command = CmdInput.Text;
                }
                if (SoundAlrt.IsChecked == true)
                {
                    CurrentTask.Asound = true;
                    CurrentTask.Sound = "null";
                }
            }
            else
            {//No Alerts
                CurrentTask.Aemail = false;
                CurrentTask.Email = EmailInput.Text;

                CurrentTask.Apopup = false;

                CurrentTask.Acommand = false;
                CurrentTask.Command = "null";

                CurrentTask.Asound = false;
                CurrentTask.Sound = "null";
            }
            ParentWindow.SaveTask(CurrentTask);
            CloseTLW_Click(null, null);
                        
        }

        private void ClearBTN_Click(object sender, RoutedEventArgs e)
        {
            TRank.SetIntValue(0);
            StatusTxt.Text = "";
            DueDateTxt.Text = "";
            TaskSummary.Text = "";
            TaskDescripTxt.Text = "";

            TSevLevelCB.SelectedIndex = -1;

            EmailInput.Text = "";
            CmdInput.Text = "";

            NoAlerts.IsChecked = true;
            ClearAlerts(null, null);

            
        }
    }
}
