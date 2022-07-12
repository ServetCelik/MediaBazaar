using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class dateLogic
    {
        public string getStartDateWeek(int week, int year)
        {
            //Get Week nr from Date
            //System.Globalization.ISOWeek.GetWeekOfYear(date);
            //if(week < System.Globalization.ISOWeek.GetWeekOfYear(DateTime.Now))     //MUST hide previous week's schedules fot this
            //{
            //    year++;
            //}

            DateTime date = System.Globalization.ISOWeek.ToDateTime(year, week, DayOfWeek.Monday);
            
            string sDate = date.ToShortDateString();
            sDate = sDate.Replace('/', '-');

            return sDate;
        }
    }
}
