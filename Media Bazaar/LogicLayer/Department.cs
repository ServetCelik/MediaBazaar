using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public enum Department
    {
        [Description("Media")] Media = 0,
        [Description("Home Appliances")] HomeAppliances = 1,
        [Description("Health & Sports")] HealtAndSports = 2,
        [Description("Electronics")] Electronics = 3,

    }
    
}
