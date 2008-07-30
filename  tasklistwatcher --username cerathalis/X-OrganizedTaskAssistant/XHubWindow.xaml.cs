using System;
using System.Collections;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace X_Hub
{
    /// <summary>
    /// Interaction logic for XTaskListWindow.xaml
    /// </summary>
    /// 

    public enum SeverityLevel { Critical = 0, High = 1, Medium = 2, Low = 3, AnyTime = 4 };

    public partial class XHubWindow : Window
    {
        private XTaskListWindow TaskAssistantWindow;
        
        private AddTaskWindow AddTaskWindow;
        
        private ArrayList ListOfTasks;

        public XHubWindow()
        {
            InitializeComponent();
            TaskAssistantWindow = new XTaskListWindow(this);
            AddTaskWindow = new AddTaskWindow(this,TaskAssistantWindow);
            ListOfTasks = new ArrayList();
            tawclosed = false;
            adwclosed = false;
        }

        private bool tawclosed;
        public bool TAWClose
        {
            get
            {
                return tawclosed;
            }
            set
            {
                tawclosed = value;
            }
        }

        private bool adwclosed;
        public bool ADWClose
        {
            get
            {
                return adwclosed;
            }
            set
            {
                adwclosed = value;
            }
        }

        public void SaveTask(BaseTask CurrInput)
        {
            ListOfTasks.Add(CurrInput);
        }

        private void TestFilleArray()
        {
            for( int i = 0; i < 10; i++)
            {
                BaseTask temptask = new BaseTask();
                temptask.Acommand = false;
                temptask.Aemail = false;
                temptask.Anone = true;
                temptask.Apopup = false;
                temptask.Asound = false;

                temptask.Command = null;
                temptask.Creation = DateTime.Now;
                temptask.Summary = "Temp Summary: " + i.ToString();
                temptask.Description = "Temporary task: " + i.ToString();
                temptask.DueDate = "10/10/2008";
                temptask.Email = "admin@test.com";
                temptask.LastModified = temptask.Creation;
                temptask.Sound = null;
                temptask.Status = "In progress";
                temptask.TaskRank = i;
                temptask.TaskSeverity = SeverityLevel.Critical;
                ListOfTasks.Add( temptask );
            }
        }
        


        private void MouseOverTitle(object sender, MouseEventArgs e)
        {
            SolidColorBrush red = new SolidColorBrush();
            red.Color = Colors.Red;
            HeaderTxt.Foreground = red;
            
        }
        private void MouseLeaveTitle(object sender, MouseEventArgs e)
        {
            SolidColorBrush white = new SolidColorBrush();
            white.Color = Colors.White;
            HeaderTxt.Foreground = white;
        }
        private void MouseDragTitle(object sender, MouseEventArgs e)
        {
            this.DragMove();
        }

        private void ApplicationHub_Loaded(object sender, RoutedEventArgs e)
        {
            FooterTxt.Text += " " + System.DateTime.Today.Month + "/" + DateTime.Today.Day + "/" + DateTime.Today.Year;
        }

        private void ShowTasks_Click(object sender, RoutedEventArgs e)
        {
            TestFilleArray();
            TaskAssistantWindow.ListOfTasks = ListOfTasks;
            TaskAssistantWindow.Show();
            TaskAssistantWindow.DisplayList();
        }
        private void DockHubW_Click(object sender, RoutedEventArgs e)
        {
            double ScreenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double ScreenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;


            double VirtualScreenWidth = System.Windows.SystemParameters.VirtualScreenWidth;
            double VirtualScreenHeight = System.Windows.SystemParameters.VirtualScreenHeight;

            if (DockToVirtual.IsChecked == true)
            {
                this.Left = VirtualScreenWidth - this.Width;
                this.Top = 0;
            }
            else
            {
                this.Left = ScreenWidth - this.Width;
                this.Top = 0;
            }
            
        }
        private void CloseHubW_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            TaskAssistantWindow.Close();
            AddTaskWindow.Close();
        }
        //Tasks modification section:
        private void AddTasks_Click(object sender, RoutedEventArgs e)
        {
            BaseTask newtask = new BaseTask();
            newtask.TaskRank = ListOfTasks.Count;

            if (adwclosed == false)
            {
                AddTaskWindow.SetTask(newtask);
                AddTaskWindow.Show();               
            }
            else
            {
                if (tawclosed == false)
                {
                    AddTaskWindow = new AddTaskWindow(this, TaskAssistantWindow);
                    AddTaskWindow.SetTask(newtask);
                    AddTaskWindow.Show();
                }
                else
                {
                    TaskAssistantWindow = new XTaskListWindow(this);
                    AddTaskWindow = new AddTaskWindow(this, TaskAssistantWindow);
                    AddTaskWindow.SetTask(newtask);
                    AddTaskWindow.Show();
                }
            }
 //           TaskAssistantWindow.Show();
        }
        private void RemoveTasks_Click(object sender, RoutedEventArgs e)
        {
  //          TaskAssistantWindow.Show();
        }
        private void EditTasks_Click(object sender, RoutedEventArgs e)
        {
 //           TaskAssistantWindow.Show();
        }
        private void HideTasks_Click(object sender, RoutedEventArgs e)
        {
  //          TaskAssistantWindow.Show();
        }
    }
}
