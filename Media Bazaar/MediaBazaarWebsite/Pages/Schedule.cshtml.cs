using LogicLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace MediaBazaarWebsite.Pages
{
    [Authorize]
    public class ScheduleModel : PageModel
    {
        //public List<SelectListItem> DepartmentsList { set; get; }
        //public List<SelectListItem> WeeksList { set; get; }
        //public List<SelectListItem> YearsList { set; get; }

        private int weeksToLookBack = 3;
        private int yearsToLookAhead = 2;
        private int yearsToLookBack = 2;

        [BindProperty]
        public string Year { get; set; }
        //[BindProperty]
        //public string Department { get; set; }

        //[BindProperty]
        //public string Week { get; set; }



        [BindProperty]
        public List<SelectListItem> DepartmentsList { get; set; }
        [BindProperty]
        public List<SelectListItem> WeeksList { get; set; }
        [BindProperty]
        public List<SelectListItem> YearsList { get; set; }

        public static scheduleManager ScheduleManager = new scheduleManager();

        [BindProperty]
        public weekSchedule WeekSchedule { get; set; }
      
        public List<weekSchedule> weekSchedulesList = ScheduleManager.schedules;



        public void OnGet()
        {
           PopulateSelectLists();
        }
       
        public void OnPostSeeSchedule()
        {
            PopulateSelectLists();
            //scheduleManager.loadShiftDB(Convert.ToInt32(Week), Convert.ToInt32(Year), Department);
            ScheduleManager.loadShiftDB(Convert.ToInt32(WeekSchedule.Date), Convert.ToInt32(Year), WeekSchedule.Department);
        }

        public void PopulateSelectLists()
        {
            DepartmentsList = new List<SelectListItem>();
            DepartmentsList.Add(new SelectListItem { Value = "0", Text = "" });

              foreach (Department department in Enum.GetValues(typeof(Department)))
              {
                DepartmentsList.Add(new SelectListItem { Value = department.GetEnumDescription(), Text = department.GetEnumDescription() });
              }
            

            WeeksList = new List<SelectListItem>();
            WeeksList.Add(new SelectListItem { Value = "0", Text = "" });
            int week = System.Globalization.ISOWeek.GetWeekOfYear(DateTime.Now);
            int loopweek = week - weeksToLookBack;

            for (int i = 1; i <= 52; i++)
            {
                WeeksList.Add(new SelectListItem { Value = i.ToString(), Text = i.ToString() });
            }
            YearsList = new List<SelectListItem>();
            YearsList.Add(new SelectListItem { Value = "0", Text = "" });

            int loopYear = DateTime.Now.Year - yearsToLookBack;
            for (int i = loopYear; i <= DateTime.Now.Year + yearsToLookAhead; i++)
            {
                YearsList.Add(new SelectListItem { Value = i.ToString(), Text = i.ToString() });

            }

            //foreach (Department department in Enum.GetValues(typeof(Department)))
            //{
            //    DepartmentsList.Add(new SelectListItem { Value = department.GetEnumDescription(), Text = department.GetEnumDescription() });
            //}

        }

        //public void AAA()
        //{
        //    int week = Convert.ToInt32(cbScheduleWeek.Text);

        //    scheduleManager.loadShiftDB(week, Convert.ToInt32(cbScheduleMYear.Text), cbScheduleDep.Text);

        //    dgvScheduleM.Rows.Clear();

        //    List<weekSchedule> w = scheduleManager.schedules;
        //    for (int i = 0; i < w.Count(); i++)
        //    {
        //        if (i == 0 || i == 5 || i == 10) { } else { w[i].shift = ""; }
        //        dgvSchedule.Rows.Add(w[i].shift, w[i].Monday, w[i].Tuesday, w[i].Wednesday, w[i].Thursday, w[i].Friday, w[i].Saturday, w[i].Sunday);
        //    }
        //}
       
     

}
}
