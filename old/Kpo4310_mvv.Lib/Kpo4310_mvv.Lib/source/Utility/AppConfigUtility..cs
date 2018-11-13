using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Kpo4310.mvv.Utility
{
    public static class AppConfigUtility
    {
       
        public static string AppSettings(string name)
        {

            string searchResult = ConfigurationManager.AppSettings[name];
            if (searchResult != null)
            {
                return searchResult;
            }
            else return "0";
        }
    }
}
