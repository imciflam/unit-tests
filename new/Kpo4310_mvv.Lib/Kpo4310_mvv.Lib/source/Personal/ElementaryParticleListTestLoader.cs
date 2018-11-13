using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//real class 1B
//ConcreteProductB1 
namespace Kpo4310.mvv.Lib 
{
     public class ElementaryParticleListTestLoader : IElementaryParticlesListLoader
    {
        public ElementaryParticleListTestLoader()
        {
            //_dataFileName = dataSource;
            this._elementaryParticleList = new List<elementaryParticle>();

        }

       // private readonly string _dataFileName = "";
        private List<elementaryParticle> _elementaryParticleList = null;

        public List<elementaryParticle> elementaryParticleList
        {
            get { return _elementaryParticleList; } 
        }



        public void Execute()
        {
            try
            {
                //Фигурная скобка для ограничения области видимости переменной elementaryParticle
                {
                    elementaryParticle elementaryParticle1 = new elementaryParticle()
                    //данная констуркция позволяет инициализировать объект при его создании
                    {
                        name = "Нейт",
                        group = "Н",
                        charge = "0",
                        weight = 940
                    };
                    _elementaryParticleList.Add(elementaryParticle1);
                }

                {
                    elementaryParticle elementaryParticle = new elementaryParticle()
                    {
                        name = "Ка-пс",
                        group = "М",
                        charge = "1",
                        weight = 494
                    };
                    _elementaryParticleList.Add(elementaryParticle);
                }
                {
                    elementaryParticle elementaryParticle = new elementaryParticle()
                    {
                        name = "Электрон",
                        group = "Л",
                        charge = "+1",
                        weight = 0.511f
                    };
                    _elementaryParticleList.Add(elementaryParticle);
                }
            }
            catch (NotImplementedException ex)
            {
                DateTime localDate = DateTime.Now;
                //MessageBox.Show("Ошибка №1: " + ex.Message);
                LogUtility.ErrorLog(localDate.ToString() + ex.Message + Environment.NewLine);

            }
        }
            

        public LoadStatus status
        {
            get;
        }

         
    }
}
