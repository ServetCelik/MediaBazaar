using DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class ShiftPreference
    {
        public Shift monday;
        public Shift tuesday;
        public Shift wednesday;
        public Shift thursday;
        public Shift friday;
        public Shift saturday;
        public Shift sunday;
        string userName;
        bool[,] shiftArray = new bool[7, 3];
        EmployeeDatabase db = new EmployeeDatabase();
        
        public ShiftPreference(string userName, bool[,] shiftArray)
        {
            this.userName = userName;
            this.shiftArray = shiftArray;
        }

        public string UserName { get => userName; }
        public bool[,] ShiftArray { get => shiftArray; set => shiftArray = value; }

        public void AddShiftsToDB()
        {
            db.AddShiftPreferencesToDB(userName, ConvertArray());
        }

        public void UpdateShiftInDB()
        {
            db.UpdateShift(userName, ConvertArray());
        }

        public string ConvertArray()
        {
            string b = "";

            for(int i=0; i<7; i++)
            {
                for(int j=0; j<3; j++)
                {
                    string a = Convert.ToString(shiftArray[i,j]);
                    b += $"{a},";
                }
            }

            return b;
        }

        public void ConvertToEnum(string data)
        {
            string[] read;
            char[] seperators = { ',' };

            read = data.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

            bool a = Convert.ToBoolean(read[0]);
            bool b = Convert.ToBoolean(read[1]);
            bool c = Convert.ToBoolean(read[2]);
            bool d = Convert.ToBoolean(read[3]);
            bool e = Convert.ToBoolean(read[4]);
            bool f = Convert.ToBoolean(read[5]);
            bool g = Convert.ToBoolean(read[6]);
            bool h = Convert.ToBoolean(read[7]);
            bool i = Convert.ToBoolean(read[8]);
            bool j = Convert.ToBoolean(read[9]);
            bool k = Convert.ToBoolean(read[10]);
            bool l = Convert.ToBoolean(read[11]);
            bool m = Convert.ToBoolean(read[12]);
            bool n = Convert.ToBoolean(read[13]);
            bool o = Convert.ToBoolean(read[14]);
            bool p = Convert.ToBoolean(read[15]);
            bool q = Convert.ToBoolean(read[16]);
            bool r = Convert.ToBoolean(read[17]);
            bool s = Convert.ToBoolean(read[18]);
            bool t = Convert.ToBoolean(read[19]);
            bool u = Convert.ToBoolean(read[20]);

            if (a == true && b == true)
            {
                monday = Shift.morning_afternoon;
            }
            else if (b == true && c == true)
            {
                monday = Shift.afternoon_evening;
            }
            else if (a == true)
            {
                monday = Shift.morning;
            }
            else if (b == true)
            {
                monday = Shift.afternoon;
            }
            else if (c == true)
            {
                monday = Shift.evening;
            }
            else
            {
                monday = Shift.no_preference;
            }
            if (d == true && e == true)
            {
                tuesday = Shift.morning_afternoon;
            }
            else if (e == true && f == true)
            {
                tuesday = Shift.afternoon_evening;
            }
            else if (d == true)
            {
                tuesday = Shift.morning;
            }
            else if (e == true)
            {
                tuesday = Shift.afternoon;
            }
            else if (f == true)
            {
                tuesday = Shift.evening;
            }
            else
            {
                tuesday = Shift.no_preference;
            }
            if (g == true && h == true)
            {
                wednesday = Shift.morning_afternoon;
            }
            else if (h == true && i == true)
            {
                wednesday = Shift.afternoon_evening;
            }
            else if (g == true)
            {
                wednesday = Shift.morning;
            }
            else if (h == true)
            {
                wednesday = Shift.afternoon;
            }
            else if (i == true)
            {
                wednesday = Shift.evening;
            }
            else
            {
                wednesday = Shift.no_preference;
            }
            if (j == true && k == true)
            {
                thursday = Shift.morning_afternoon;
            }
            else if (k == true && l == true)
            {
                thursday = Shift.afternoon_evening;
            }
            else if (j == true)
            {
                thursday = Shift.morning;
            }
            else if (k == true)
            {
                thursday = Shift.afternoon;
            }
            else if (l == true)
            {
                thursday = Shift.evening;
            }
            else
            {
                thursday = Shift.no_preference;
            }
            if (m == true && n == true)
            {
                friday = Shift.morning_afternoon;
            }
            else if (n == true && o == true)
            {
                friday = Shift.afternoon_evening;
            }
            else if (m == true)
            {
                friday = Shift.morning;
            }
            else if (n == true)
            {
                friday = Shift.afternoon;
            }
            else if (o == true)
            {
                friday = Shift.evening;
            }
            else
            {
                friday = Shift.no_preference;
            }
            if (p == true && q == true)
            {
                saturday = Shift.morning_afternoon;
            }
            else if (q == true && r == true)
            {
                saturday = Shift.afternoon_evening;
            }
            else if (p == true)
            {
                saturday = Shift.morning;
            }
            else if (q == true)
            {
                saturday = Shift.afternoon;
            }
            else if (r == true)
            {
                saturday = Shift.evening;
            }
            else
            {
                saturday = Shift.no_preference;
            }
            if (s == true && t == true)
            {
                sunday = Shift.morning_afternoon;
            }
            else if (t == true && u == true)
            {
                sunday = Shift.afternoon_evening;
            }
            else if (s == true)
            {
                sunday = Shift.morning;
            }
            else if (t == true)
            {
                sunday = Shift.afternoon;
            }
            else if (u == true)
            {
                sunday = Shift.evening;
            }
            else
            {
                sunday = Shift.no_preference;
            }
        }
    }
}
