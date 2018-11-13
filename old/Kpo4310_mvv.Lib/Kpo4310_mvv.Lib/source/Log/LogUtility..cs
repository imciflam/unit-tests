using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 


namespace Kpo4310.mvv.Lib
{
    public static class LogUtility
    {
       
        public static string address = "error.lo";//"" or "e"
        public static void ErrorLog(string message)
         {
            //System.Diagnostics.Debug.Assert(LogUtility.address == "error.log", message);
            File.AppendAllText(address, message);
         }

    }
}
