using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace X_Hub
{
    [XmlRoot("BaseTask")]
    public class BaseTask : IComparable 
    {
        public BaseTask()
        {
            creation = DateTime.Now;
            duedate = null;
            taskrank = 0;
            status = null;
            description = null;
            anone = true;
            aemail = false;
            email = null;
            apopup = false;
            acommand = false;
            command = null;
            asound = false;
            sound = null;
        }

        int IComparable.CompareTo(object obj)
        {
            BaseTask input = (BaseTask)obj;
            return taskrank.CompareTo(input.TaskRank);
        }

        //Dates- 
        [XmlElement("Creation_Date")]
        private DateTime creation;
        public DateTime Creation
        {
            get
            {
                return creation;
            }
            set
            {
                creation = value;
            }
        }
        [XmlElement("Date_Last_Modified")]
        private DateTime lastmodified;
        public DateTime LastModified
        {
            get
            {
                return lastmodified;
            }
            set
            {
                lastmodified = value;
            }
        }
        [XmlElement("Date_Complete")]
        private DateTime completed;
        public DateTime Completed
        {
            get
            {
                return completed;
            }
            set
            {
                completed = value;
            }
        }
        [XmlElement("Due_Date")]
        private string duedate;
        public string DueDate
        {
            get
            {
                return duedate;
            }
            set
            {
                duedate = value;
            }
        }

        //Rank-
        //Numerical # representing location in the list.
        [XmlElement("Task_Rank")]
        private int taskrank;
        public int TaskRank
        {
            get
            {
                return taskrank;
            }
            set
            {
                taskrank = value;
            }
        }

        //Severity-
        //Critical
        //High
        //Medium
        //Low
        //AnyTime
        [XmlElement("Task_Severity")]
        private SeverityLevel taskseverity;
        public SeverityLevel TaskSeverity
        {
            get
            {
                return taskseverity;
            }
            set
            {
                taskseverity = value;
            }
        }

        //Status-
        //Scheduled
        //Planning
        //Researching
        //Started
        //MileStone X
        //Completed
        [XmlElement("Task_Status")]
        private string status;
        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        //Description-
        //User Entered String - Char Limit ?
        [XmlElement("Task_Description")]
        private string description;
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        [XmlElement("Task_Summary")]
        private string summary;
        public string Summary
        {
            get
            {
                return summary;
            }
            set
            {
                summary = value;
            }
        }

        //Reminder Types-
        [XmlElement("Task_Set_No_Reminder")]
        private bool anone;
        public bool Anone
        {
            get
            {
                return anone;
            }
            set
            {
                anone = value;
            }
        }
        [XmlElement("Task_Set_Alert_Email")]
        private bool aemail;
        public bool Aemail
        {
            get
            {
                return aemail;
            }
            set
            {
                aemail = value;
            }
        }
        [XmlElement("Task_Alert_Email_Address")]
        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        [XmlElement("Task_Popup")]
        private bool apopup;
        public bool Apopup
        {
            get
            {
                return apopup;
            }
            set
            {
                apopup = value;
            }
        }
        [XmlElement("Task_Set_Command")]
        private bool acommand;
        public bool Acommand
        {
            get
            {
                return acommand;
            }
            set
            {
                acommand = value;
            }
        }
        [XmlElement("Task_Command")]
        private string command;
        public string Command
        {
            get
            {
                return command;
            }
            set
            {
                command = value;
            }
        }
        [XmlElement("Task_Set_Sound")]
        private bool asound;
        public bool Asound
        {
            get
            {
                return asound;
            }
            set
            {
                asound = value;
            }
        }
        [XmlElement("Task_Sound")]
        private string sound;
        public string Sound
        {
            get
            {
                return sound;
            }
            set
            {
                sound = value;
            }
        }
    }
}
