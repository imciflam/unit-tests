using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//real class 2B
//ConcreteProductB2 
namespace Kpo4310.mvv.Lib
{
    public enum LoadStatus
    {
        None = 0,
        Success = 1,
        FileNameIsEmpty = -1,
        FileNotExists = -2,
        GeneralError = -100
    } 
 

     class ElementaryParticleListSplitFileLoader : IElementaryParticlesListLoader
    {
        public ElementaryParticleListSplitFileLoader(string dataSource)
        {
            _dataFileName = dataSource;
        }

        private readonly string _dataFileName = "";
        private List<elementaryParticle> _elementaryParticleList = null;

        private LoadStatus _status = LoadStatus.None;

        public List<elementaryParticle> elementaryParticleList
        {
            get
            {
                return _elementaryParticleList;
            }
        }
        public LoadStatus status
        {
            get
            {
                return _status;
            }

        } 
        public void Execute()
        {
            LoadStatus currentStatus = LoadStatus.None;

            try
            {
                if (!File.Exists("elementaryParticles.txt"))
                {
                    currentStatus = LoadStatus.FileNotExists;
                    throw new FileNotFoundException(@"[elementaryParticles.txt not in the directory]");
                }

                if (_dataFileName == null)
                {
                    currentStatus = LoadStatus.FileNotExists;
                    throw new FileNotFoundException(@"[name is empty]");
                }
                _elementaryParticleList = new List<elementaryParticle>();
                // LoadStatus currentStatus = status;

                StreamReader sr = null;
                using (sr = new StreamReader(_dataFileName))
                {
                    while (!sr.EndOfStream)
                    {
                        //Прочитать очередную строку
                        string str = sr.ReadLine();
                        try
                        {
                            string[] arr = str.Split('|');
                            elementaryParticle elementaryParticle1 = new elementaryParticle()
                            {
                                name = arr[0],
                                group = arr[1],
                                charge = arr[2],
                                weight = float.Parse(arr[3])
                            };
                            _elementaryParticleList.Add(elementaryParticle1);

                        }
                        catch (Exception e)
                        {
                            LogUtility.ErrorLog(e.Message);
                            currentStatus = LoadStatus.GeneralError;
                        }
                    }
                }
                currentStatus = LoadStatus.Success;
            }


            catch (Exception ex)
            {
                LogUtility.ErrorLog(ex.Message + Environment.NewLine);
            } 
        }
    }

}

 