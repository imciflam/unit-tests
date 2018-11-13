using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kpo4310.mvv.Utility;

namespace Kpo4310.mvv.Lib
{
    public static class AppGlobalSettings
    {
         
        static private string _nameFile;
        static public string nameFile
        {
            get
            {
                return _nameFile;
            }
            set
            {
                _nameFile = value;
            }
        }
        static private string _log;
        static public string Log
        {
            get
            {
                return _log;
            }
            set
            {
                 _log = value;
            }
        }

        static private string _dataFile;
        static public string DataFile
        {
            get
            {
                return _dataFile;
            }
            set
            {
                _dataFile = value;
            }
        }


        private static IElementaryParticlesFactory _factory;
        public static IElementaryParticlesFactory factory
        {
            get { return _factory; }
        }
         
        public static void Initialize()
        { 
            AppGlobalSettings.Log = AppConfigUtility.AppSettings("logPath");
            AppGlobalSettings.DataFile = AppConfigUtility.AppSettings("dataFileName");
            if (AppConfigUtility.AppSettings("factory") == "test")
            {
                _factory = new ElementaryParticlesTestFactory();
            }
            else if (AppConfigUtility.AppSettings("factory") == "split")
            {
                _factory = new ElementaryParticleSplitFileFactory();
            }
        }
    }
}
  
