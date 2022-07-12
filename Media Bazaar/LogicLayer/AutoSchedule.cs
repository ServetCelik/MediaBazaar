using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Media_Bazaar;

namespace LogicLayer
{
    public class AutoSchedule
    {
        public void generateSchedule(scheduleManager scheMan, List<ShiftPreference> preferences, EmployeeAdmin empAd)
        {
            List<weekSchedule> s = scheMan.schedules;       //"s" for simplicity in calling
            List<ShiftPreference> p = preferences;                   //"e" for simplicity in calling

            for (int i = 0; i < s.Count; i++)        //loop 1, make sure every schedule is checked
            {
                //Check for each day if the shift is still empty
                if (s[i].Monday == "")
                {
                    foreach (ShiftPreference sp in p)               //search for employee preferences
                    {
                        if (s[i].shift == "morning")          //Check for assigning morning shift
                        {
                            if (sp.monday.ToString() == "morning")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "monday", empAd);

                            }
                            if (sp.monday.ToString() == "morning_afternoon")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "monday", empAd);

                                for (int aft = 5; aft < 10; aft++)
                                {
                                    if (s[aft].Monday == "")
                                    {
                                        //assign shift, shedule manager does all checks
                                        //if a check fails, it does not assign and the code goes on
                                        scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                            s[aft].id, "monday", empAd);
                                    }
                                }
                            }
                        }

                        if (s[i].shift == "afternoon")          //Check for assigning afternoon shift
                        {
                            if (sp.monday.ToString() == "afternoon")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "monday", empAd);

                            }
                            if (sp.monday.ToString() == "afternoon_evening")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "monday", empAd);

                                for (int aft = 10; aft < 15; aft++)
                                {
                                    if (s[aft].Monday == "")
                                    {
                                        //assign shift, shedule manager does all checks
                                        //if a check fails, it does not assign and the code goes on
                                        scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                            s[aft].id, "monday", empAd);
                                    }
                                }
                            }
                        }

                        if (s[i].shift == "evening")          // check for assigning evening shift
                        {
                            if (sp.monday.ToString() == "evening")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "monday", empAd);

                            }
                        }
                    }

                }


                //Check for each day if the shift is still empty
                if (s[i].Tuesday == "")
                {
                    foreach (ShiftPreference sp in p)               //search for employee preferences
                    {
                        if (s[i].shift == "morning")          //Check for assigning morning shift
                        {
                            if (sp.tuesday.ToString() == "morning")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "tuesday", empAd);

                            }
                            if (sp.tuesday.ToString() == "morning_afternoon")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "tuesday", empAd);

                                for (int aft = 5; aft < 10; aft++)
                                {
                                    if (s[aft].Tuesday == "")
                                    {
                                        //assign shift, shedule manager does all checks
                                        //if a check fails, it does not assign and the code goes on
                                        scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                            s[aft].id, "tuesday", empAd);
                                    }
                                }
                            }
                        }

                        if (s[i].shift == "afternoon")          //Check for assigning afternoon shift
                        {
                            if (sp.tuesday.ToString() == "afternoon")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "tuesday", empAd);

                            }
                            if (sp.tuesday.ToString() == "afternoon_evening")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "tuesday", empAd);

                                for (int aft = 10; aft < 15; aft++)
                                {
                                    if (s[aft].Tuesday == "")
                                    {
                                        //assign shift, shedule manager does all checks
                                        //if a check fails, it does not assign and the code goes on
                                        scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                            s[aft].id, "tuesday", empAd);
                                    }
                                }
                            }
                        }

                        if (s[i].shift == "evening")          // check for assigning evening shift
                        {
                            if (sp.tuesday.ToString() == "evening")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "tuesday", empAd);

                            }
                        }
                    }

                }


                //Check for each day if the shift is still empty
                if (s[i].Wednesday == "")
                {
                    foreach (ShiftPreference sp in p)               //search for employee preferences
                    {
                        if (s[i].shift == "morning")          //Check for assigning morning shift
                        {
                            if (sp.wednesday.ToString() == "morning")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "wednesday", empAd);

                            }
                            if (sp.wednesday.ToString() == "morning_afternoon")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "wednesday", empAd);

                                for (int aft = 5; aft < 10; aft++)
                                {
                                    if (s[aft].Wednesday == "")
                                    {
                                        //assign shift, shedule manager does all checks
                                        //if a check fails, it does not assign and the code goes on
                                        scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                            s[aft].id, "wednesday", empAd);
                                    }
                                }
                            }
                        }

                        if (s[i].shift == "afternoon")          //Check for assigning afternoon shift
                        {
                            if (sp.wednesday.ToString() == "afternoon")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "wednesday", empAd);

                            }
                            if (sp.wednesday.ToString() == "afternoon_evening")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "wednesday", empAd);

                                for (int aft = 10; aft < 15; aft++)
                                {
                                    if (s[aft].Wednesday == "")
                                    {
                                        //assign shift, shedule manager does all checks
                                        //if a check fails, it does not assign and the code goes on
                                        scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                            s[aft].id, "wednesday", empAd);
                                    }
                                }
                            }
                        }

                        if (s[i].shift == "evening")          // check for assigning evening shift
                        {
                            if (sp.wednesday.ToString() == "evening")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "wednesday", empAd);

                            }
                        }
                    }

                }


                //Check for each day if the shift is still empty
                if (s[i].Thursday == "")
                {
                    foreach (ShiftPreference sp in p)               //search for employee preferences
                    {
                        if (s[i].shift == "morning")          //Check for assigning morning shift
                        {
                            if (sp.thursday.ToString() == "morning")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "thursday", empAd);

                            }
                            if (sp.thursday.ToString() == "morning_afternoon")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "thursday", empAd);

                                for (int aft = 5; aft < 10; aft++)
                                {
                                    if (s[aft].Thursday == "")
                                    {
                                        //assign shift, shedule manager does all checks
                                        //if a check fails, it does not assign and the code goes on
                                        scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                            s[aft].id, "thursday", empAd);
                                    }
                                }
                            }
                        }

                        if (s[i].shift == "afternoon")          //Check for assigning afternoon shift
                        {
                            if (sp.thursday.ToString() == "afternoon")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "thursday", empAd);

                            }
                            if (sp.thursday.ToString() == "afternoon_evening")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "thursday", empAd);

                                for (int aft = 10; aft < 15; aft++)
                                {
                                    if (s[aft].Thursday == "")
                                    {
                                        //assign shift, shedule manager does all checks
                                        //if a check fails, it does not assign and the code goes on
                                        scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                            s[aft].id, "thursday", empAd);
                                    }
                                }
                            }
                        }

                        if (s[i].shift == "evening")          // check for assigning evening shift
                        {
                            if (sp.thursday.ToString() == "evening")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "thursday", empAd);

                            }
                        }
                    }

                }


                //Check for each day if the shift is still empty
                if (s[i].Friday == "")
                {
                    foreach (ShiftPreference sp in p)               //search for employee preferences
                    {
                        if (s[i].shift == "morning")          //Check for assigning morning shift
                        {
                            if (sp.friday.ToString() == "morning")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "friday", empAd);

                            }
                            if (sp.friday.ToString() == "morning_afternoon")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "friday", empAd);

                                for (int aft = 5; aft < 10; aft++)
                                {
                                    if (s[aft].Friday == "")
                                    {
                                        //assign shift, shedule manager does all checks
                                        //if a check fails, it does not assign and the code goes on
                                        scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                            s[aft].id, "friday", empAd);
                                    }
                                }
                            }
                        }

                        if (s[i].shift == "afternoon")          //Check for assigning afternoon shift
                        {
                            if (sp.friday.ToString() == "afternoon")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "friday", empAd);

                            }
                            if (sp.friday.ToString() == "afternoon_evening")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "friday", empAd);

                                for (int aft = 10; aft < 15; aft++)
                                {
                                    if (s[aft].Friday == "")
                                    {
                                        //assign shift, shedule manager does all checks
                                        //if a check fails, it does not assign and the code goes on
                                        scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                            s[aft].id, "friday", empAd);
                                    }
                                }
                            }
                        }

                        if (s[i].shift == "evening")          // check for assigning evening shift
                        {
                            if (sp.friday.ToString() == "evening")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "friday", empAd);

                            }
                        }
                    }

                }

                //Check for each day if the shift is still empty
                if (s[i].Saturday == "")
                {
                    foreach (ShiftPreference sp in p)               //search for employee preferences
                    {
                        if (s[i].shift == "morning")          //Check for assigning morning shift
                        {
                            if (sp.saturday.ToString() == "morning")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "saturday", empAd);

                            }
                            if (sp.saturday.ToString() == "morning_afternoon")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "saturday", empAd);

                                for (int aft = 5; aft < 10; aft++)
                                {
                                    if (s[aft].Saturday == "")
                                    {
                                        //assign shift, shedule manager does all checks
                                        //if a check fails, it does not assign and the code goes on
                                        scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                            s[aft].id, "saturday", empAd);
                                    }
                                }
                            }
                        }

                        if (s[i].shift == "afternoon")          //Check for assigning afternoon shift
                        {
                            if (sp.saturday.ToString() == "afternoon")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "saturday", empAd);

                            }
                            if (sp.saturday.ToString() == "afternoon_evening")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "saturday", empAd);

                                for (int aft = 10; aft < 15; aft++)
                                {
                                    if (s[aft].Saturday == "")
                                    {
                                        //assign shift, shedule manager does all checks
                                        //if a check fails, it does not assign and the code goes on
                                        scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                            s[aft].id, "saturday", empAd);
                                    }
                                }
                            }
                        }

                        if (s[i].shift == "evening")          // check for assigning evening shift
                        {
                            if (sp.saturday.ToString() == "evening")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "saturday", empAd);

                            }
                        }
                    }

                }

                //Check for each day if the shift is still empty
                if (s[i].Sunday == "")
                {
                    foreach (ShiftPreference sp in p)               //search for employee preferences
                    {
                        if (s[i].shift == "morning")          //Check for assigning morning shift
                        {
                            if (sp.sunday.ToString() == "morning")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "sunday", empAd);

                            }
                            if (sp.sunday.ToString() == "morning_afternoon")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "sunday", empAd);

                                for (int aft = 5; aft < 10; aft++)
                                {
                                    if (s[aft].Sunday == "")
                                    {
                                        //assign shift, shedule manager does all checks
                                        //if a check fails, it does not assign and the code goes on
                                        scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                            s[aft].id, "sunday", empAd);
                                    }
                                }
                            }
                        }

                        if (s[i].shift == "afternoon")          //Check for assigning afternoon shift
                        {
                            if (sp.sunday.ToString() == "afternoon")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "sunday", empAd);

                            }
                            if (sp.sunday.ToString() == "afternoon_evening")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "sunday", empAd);

                                for (int aft = 10; aft < 15; aft++)
                                {
                                    if (s[aft].Sunday == "")
                                    {
                                        //assign shift, shedule manager does all checks
                                        //if a check fails, it does not assign and the code goes on
                                        scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                            s[aft].id, "sunday", empAd);
                                    }
                                }
                            }
                        }

                        if (s[i].shift == "evening")          // check for assigning evening shift
                        {
                            if (sp.sunday.ToString() == "evening")
                            {
                                //assign shift, shedule manager does all checks
                                //if a check fails, it does not assign and the code goes on
                                scheMan.assignShiftAuto(empAd.getNameByUsername(sp.UserName),
                                    s[i].id, "sunday", empAd);

                            }
                        }
                    }

                }

            }
        }
    }
}
