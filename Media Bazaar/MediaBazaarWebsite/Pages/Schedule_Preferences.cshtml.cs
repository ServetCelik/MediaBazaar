using LogicLayer;
using Media_Bazaar;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWebsite.Pages
{
    public class Schedule_PreferencesModel : PageModel
    {
        [BindProperty]
        public bool s1 { get; set; }
        [BindProperty]
        public bool s2 { get; set; }
        [BindProperty]
        public bool s3 { get; set; }
        [BindProperty]
        public bool s4 { get; set; }
        [BindProperty]
        public bool s5 { get; set; }
        [BindProperty]
        public bool s6 { get; set; }
        [BindProperty]
        public bool s7 { get; set; }
        [BindProperty]
        public bool s8 { get; set; }
        [BindProperty]
        public bool s9 { get; set; }
        [BindProperty]
        public bool s10 { get; set; }
        [BindProperty]
        public bool s11 { get; set; }
        [BindProperty]
        public bool s12 { get; set; }
        [BindProperty]
        public bool s13 { get; set; }
        [BindProperty]
        public bool s14 { get; set; }
        [BindProperty]
        public bool s15 { get; set; }
        [BindProperty]
        public bool s16 { get; set; }
        [BindProperty]
        public bool s17 { get; set; }
        [BindProperty]
        public bool s18 { get; set; }
        [BindProperty]
        public bool s19 { get; set; }
        [BindProperty]
        public bool s20 { get; set; }
        [BindProperty]
        public bool s21 { get; set; }

        bool[,] shiftArray = new bool[7, 3];

        ShiftPreference shiftPreference;


        public void OnGet()
        {

        }

        public void OnPost()
        {
            shiftArray[0, 0] = s1;
            shiftArray[1, 0] = s2;
            shiftArray[2, 0] = s3;
            shiftArray[3, 0] = s4;
            shiftArray[4, 0] = s5;
            shiftArray[5, 0] = s6;
            shiftArray[6, 0] = s7;
            shiftArray[0, 1] = s8;
            shiftArray[1, 1] = s9;
            shiftArray[2, 1] = s10;
            shiftArray[3, 1] = s11;
            shiftArray[4, 1] = s12;
            shiftArray[5, 1] = s13;
            shiftArray[6, 1] = s14;
            shiftArray[0, 2] = s15;
            shiftArray[1, 2] = s16;
            shiftArray[2, 2] = s17;
            shiftArray[3, 2] = s18;
            shiftArray[4, 2] = s19;
            shiftArray[5, 2] = s20;
            shiftArray[6, 2] = s21;

            string name = User.Identity.Name;

            EmployeeAdmin employeeAdmin = new EmployeeAdmin();
            var list = employeeAdmin.GetAllPreferences();

            shiftPreference = new ShiftPreference(name, shiftArray);
            if (list.Exists(x=>x.UserName==name))
            {
                var pref = list.Find(x => x.UserName == name);
                pref.ShiftArray = shiftPreference.ShiftArray;
                pref.UpdateShiftInDB();
            }
            else
            {
                shiftPreference.AddShiftsToDB();
            }
            
        }
    }
}
