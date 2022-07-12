using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;
using DTO;
using Media_Bazaar;

namespace LogicLayer
{
    public class scheduleManager
    {
        public List<weekSchedule> schedules = new List<weekSchedule>();
        private List<weekScheduleDTO> scheduleDTOs = new List<weekScheduleDTO>();

        public List<weekSchedule> copyList = new List<weekSchedule>();

        private scheduleDB ScheduleDB = new scheduleDB();

        dateLogic dateLogic = new dateLogic();

        private static AutoSchedule autoSched = new AutoSchedule();

        private weekSchedule scheduleMapper(weekScheduleDTO dto)
        {
            weekSchedule week = new weekSchedule(dto.id, dto.shift, dto.department, dto.date, dto.Monday, dto.Tuesday, dto.Wednesday, dto.Thursday, dto.Friday, dto.Saturday, dto.Sunday);
            return week;
        }

        private weekScheduleDTO reverseMapper(weekSchedule we)
        {
            weekScheduleDTO week = new weekScheduleDTO(we.id, we.shift, we.department, we.date, we.Monday, we.Tuesday, we.Wednesday, we.Thursday, we.Friday, we.Saturday, we.Sunday);
            return week;
        }
        public void changeShiftLocal(int id, string day, string name)
        {
            int index = -1;
            foreach (weekSchedule w in schedules)
            {
                if (w.id == id)
                {
                    index = schedules.IndexOf(w);
                    break;
                }
            }
            switch (day)
            {
                case "monday": schedules[index].Monday = name; break;
                case "tuesday": schedules[index].Tuesday = name; break;
                case "wednesday": schedules[index].Wednesday = name; break;
                case "thursday": schedules[index].Thursday = name; break;
                case "friday": schedules[index].Friday = name; break;
                case "saturday": schedules[index].Saturday = name; break;
                case "sunday": schedules[index].Sunday = name; break;
                default:
                    break;
            }


        }

        public void saveWeekSetDB()
        {
            scheduleDTOs.Clear();
            foreach (weekSchedule w in schedules)
            {
                scheduleDTOs.Add(reverseMapper(w));
            }

            ScheduleDB.uploadShift(scheduleDTOs);
        }

        public void loadShiftDB(int week, int year, string department)
        {

            string date = dateLogic.getStartDateWeek(week, year);

            ScheduleDB.GetSchedule(date, department, this.scheduleDTOs);

            if (this.scheduleDTOs.Count == 0)                                //Check if schedule exists
            {
                for (int i = 0; i < 5; i++)                                  //Generate new empty schedule
                {
                    scheduleDTOs.Add(new weekScheduleDTO("morning", department, date, "", "", "", "", "", "", ""));
                }
                for (int i = 0; i < 5; i++)
                {
                    scheduleDTOs.Add(new weekScheduleDTO("afternoon", department, date, "", "", "", "", "", "", ""));
                }
                for (int i = 0; i < 5; i++)
                {
                    scheduleDTOs.Add(new weekScheduleDTO("evening", department, date, "", "", "", "", "", "", ""));
                }

                ScheduleDB.uploadEmptySchedule(scheduleDTOs);
                ScheduleDB.GetSchedule(date, department, this.scheduleDTOs);
            }

            this.schedules.Clear();
            foreach (weekScheduleDTO w in this.scheduleDTOs)
            {
                schedules.Add(scheduleMapper(w));
            }
        }

        public bool checkConsecutiveShifts(string name, string day)
        {
            int shifts = 0;
            string cName = "";
            foreach (weekSchedule w in schedules)
            {
                switch (day)
                {
                    case "monday": cName = w.Monday; break;
                    case "tuesday": cName = w.Tuesday; break;
                    case "wednesday": cName = w.Wednesday; break;
                    case "thursday": cName = w.Thursday; break;
                    case "friday": cName = w.Friday; break;
                    case "saturday": cName = w.Saturday; break;
                    case "sunday": cName = w.Sunday; break;
                    default:
                        break;
                }
                if (name == cName)
                {
                    shifts++;
                }
            }
            if (shifts > 1)
            {
                return true;
            }
            return false;
        }

        public bool checkSameShift(string name, string day, int cellIndex)
        {
            int shifts = 0;
            string cName = "";
            int minCheck = 0;
            int maxCheck = 0;

            if (cellIndex <= 4)
            {
                minCheck = 0;
                maxCheck = 4;
            }
            else if (cellIndex <= 9 && cellIndex > 4)
            {
                minCheck = 5;
                maxCheck = 9;
            }
            else
            {
                minCheck = 10;
                maxCheck = 14;
            }

            for (int i = minCheck; i <= maxCheck; i++)
            {
                switch (day)
                {
                    case "monday": cName = schedules[i].Monday; break;
                    case "tuesday": cName = schedules[i].Tuesday; break;
                    case "wednesday": cName = schedules[i].Wednesday; break;
                    case "thursday": cName = schedules[i].Thursday; break;
                    case "friday": cName = schedules[i].Friday; break;
                    case "saturday": cName = schedules[i].Saturday; break;
                    case "sunday": cName = schedules[i].Sunday; break;
                    default:
                        break;
                }
                if (name == cName)
                {
                    shifts++;
                }
            }

            if (shifts == 1)
            {
                return true;
            }
            return false;
        }

        public bool checkFTE(string name, double workHours, int shiftNmb)
        {
            if (workHours != 0)
            {
                foreach (weekSchedule w in schedules)
                {
                    if (w.Monday == name)
                    {
                        if (w.shift == "morning")
                        {
                            workHours = workHours - 4.5;
                        }
                        else if (w.shift == "afternoon")
                        {
                            workHours = workHours - 4.5;
                        }
                        else
                        {
                            workHours = workHours - 5.5;
                        }
                    }
                    if (w.Tuesday == name)
                    {
                        if (w.shift == "morning")
                        {
                            workHours = workHours - 4.5;
                        }
                        else if (w.shift == "afternoon")
                        {
                            workHours = workHours - 4.5;
                        }
                        else
                        {
                            workHours = workHours - 5.5;
                        }
                    }
                    if (w.Wednesday == name)
                    {
                        if (w.shift == "morning")
                        {
                            workHours = workHours - 4.5;
                        }
                        else if (w.shift == "afternoon")
                        {
                            workHours = workHours - 4.5;
                        }
                        else
                        {
                            workHours = workHours - 5.5;
                        }
                    }
                    if (w.Thursday == name)
                    {
                        if (w.shift == "morning")
                        {
                            workHours = workHours - 4.5;
                        }
                        else if (w.shift == "afternoon")
                        {
                            workHours = workHours - 4.5;
                        }
                        else
                        {
                            workHours = workHours - 5.5;
                        }
                    }
                    if (w.Friday == name)
                    {
                        if (w.shift == "morning")
                        {
                            workHours = workHours - 4.5;
                        }
                        else if (w.shift == "afternoon")
                        {
                            workHours = workHours - 4.5;
                        }
                        else
                        {
                            workHours = workHours - 5.5;
                        }
                    }
                    if (w.Saturday == name)
                    {
                        if (w.shift == "morning")
                        {
                            workHours = workHours - 4.5;
                        }
                        else if (w.shift == "afternoon")
                        {
                            workHours = workHours - 4.5;
                        }
                        else
                        {
                            workHours = workHours - 5.5;
                        }
                    }
                    if (w.Sunday == name)
                    {
                        if (w.shift == "morning")
                        {
                            workHours = workHours - 4.5;
                        }
                        else if (w.shift == "afternoon")
                        {
                            workHours = workHours - 4.5;
                        }
                        else
                        {
                            workHours = workHours - 5.5;
                        }
                    }
                }

                if(shiftNmb < 10) { workHours = workHours - 4.5; } else { workHours = workHours - 5.5; }

                if(workHours > 0) { return true; }
            }
            return false;
        }

        public double getFTELeft(string name, double workHours)
        {
            double returnHours = workHours;

            if (workHours != 0)
            {
                foreach (weekSchedule w in schedules)
                {
                    if (w.Monday == name)
                    {
                        if (w.shift == "morning")
                        {
                            returnHours = returnHours - 4.5;
                        }
                        else if (w.shift == "afternoon")
                        {
                            returnHours = returnHours - 4.5;
                        }
                        else
                        {
                            returnHours = returnHours - 5.5;
                        }
                    }
                    if (w.Tuesday == name)
                    {
                        if (w.shift == "morning")
                        {
                            returnHours = returnHours - 4.5;
                        }
                        else if (w.shift == "afternoon")
                        {
                            returnHours = returnHours - 4.5;
                        }
                        else
                        {
                            returnHours = returnHours - 5.5;
                        }
                    }
                    if (w.Wednesday == name)
                    {
                        if (w.shift == "morning")
                        {
                            returnHours = returnHours - 4.5;
                        }
                        else if (w.shift == "afternoon")
                        {
                            returnHours = returnHours - 4.5;
                        }
                        else
                        {
                            returnHours = returnHours - 5.5;
                        }
                    }
                    if (w.Thursday == name)
                    {
                        if (w.shift == "morning")
                        {
                            returnHours = returnHours - 4.5;
                        }
                        else if (w.shift == "afternoon")
                        {
                            returnHours = returnHours - 4.5;
                        }
                        else
                        {
                            returnHours = returnHours - 5.5;
                        }
                    }
                    if (w.Friday == name)
                    {
                        if (w.shift == "morning")
                        {
                            returnHours = returnHours - 4.5;
                        }
                        else if (w.shift == "afternoon")
                        {
                            returnHours = returnHours - 4.5;
                        }
                        else
                        {
                            returnHours = returnHours - 5.5;
                        }
                    }
                    if (w.Saturday == name)
                    {
                        if (w.shift == "morning")
                        {
                            returnHours = returnHours - 4.5;
                        }
                        else if (w.shift == "afternoon")
                        {
                            returnHours = returnHours - 4.5;
                        }
                        else
                        {
                            returnHours = returnHours - 5.5;
                        }
                    }
                    if (w.Sunday == name)
                    {
                        if (w.shift == "morning")
                        {
                            returnHours = returnHours - 4.5;
                        }
                        else if (w.shift == "afternoon")
                        {
                            returnHours = returnHours - 4.5;
                        }
                        else
                        {
                            returnHours = returnHours - 5.5;
                        }
                    }
                }
            }

            return returnHours;
        }

        public void assignShiftAuto(string name, int shiftId, string day, EmployeeAdmin empAd)
        {
            double workhours = empAd.GetCurrentContractHours(name);
            int shiftnmb = 0;

            for(int i = 0; i < schedules.Count; i++)
            {
                if(schedules[i].id == shiftId)
                {
                    shiftnmb = i;
                    i = schedules.Count;
                }
            }

            if(checkFTE(name, workhours, shiftnmb))
            {

                if(!checkConsecutiveShifts(name, day))
                {

                    if(!checkSameShift(name, day, shiftnmb))
                    {

                        switch (day)
                        {
                            case "monday": schedules[shiftnmb].Monday = name; break;
                            case "tuesday": schedules[shiftnmb].Tuesday = name; break;
                            case "wednesday": schedules[shiftnmb].Wednesday = name; break;
                            case "thursday": schedules[shiftnmb].Thursday = name; break;
                            case "friday": schedules[shiftnmb].Friday = name; break;
                            case "saturday": schedules[shiftnmb].Saturday = name; break;
                            case "sunday": schedules[shiftnmb].Sunday = name; break;
                            default:
                                break;
                        }

                    }

                }

            }
        }

        public void GenerateSchedule(List<ShiftPreference> s, EmployeeAdmin empad)
        {
            autoSched.generateSchedule(this, s, empad);
        }
    }
}
