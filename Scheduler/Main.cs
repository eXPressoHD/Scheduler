using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Scheduler
{    
    public partial class Main : MetroFramework.Forms.MetroForm
    {

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FillCells();
        }


        private void FillCells()
        {
            List<MetroLabel> dateList = new List<MetroLabel>();
            //For every row Initialize workingday here
            for (int i = 0; i < GetControls<MetroLabel>("labDateMain").Count; i++)
            {                
                dateList.Add(GetControls<MetroLabel>("labDateMain")[i] as MetroLabel);
                dateList[i].Text = SetDates(i);                
            }
        }


        /// <summary>
        /// Sets the parsed label with number to specific value 
        /// </summary>
        /// <param name="count">Each day per week</param>
        /// <returns></returns>
        private string SetDates(int count)
        {
            DateTime startOfWeek = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
            return startOfWeek.AddDays(count).ToString("dd.MM.yyyy");
        }

        /// <summary>
        /// Returns a controList for each column
        /// </summary>
        /// <typeparam name="T">Control type</typeparam>
        /// <param name="controlNameBeginning">Identic name of control for each column</param>
        /// <returns>List of Controls</returns>
        private List<Control> GetControls<T>(string controlNameBeginning)
        {
            List<Control> controlList = new List<Control>();
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                if (c is T && c.Name.StartsWith(controlNameBeginning))
                {
                    controlList.Add(c as Control);
                }
            }
            return controlList;
        }
    }
























    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
    }
}
