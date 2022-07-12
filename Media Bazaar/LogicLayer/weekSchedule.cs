using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class weekSchedule
    {
        public int id;

        public string shift;
        public string department;
        public string date;

        public string Monday;
        public string Tuesday;
        public string Wednesday;
        public string Thursday;
        public string Friday;
        public string Saturday;
        public string Sunday;

        public string Department { get => department; set => department = value; }
        public string Date { get => date; set => date = value; }

        public weekSchedule()
        { }

        public weekSchedule(int id, string shift, string department, string date, string mon, string tue, string wed, string thu, string fri, string sat, string sun)
        {
            this.id = id;
            this.date = date;
            this.shift = shift;
            this.department = department;
            this.Monday = mon;
            this.Tuesday = tue;
            this.Wednesday = wed;
            this.Thursday = thu;
            this.Friday = fri;
            this.Saturday = sat;
            this.Sunday = sun;
        }
    }
}
