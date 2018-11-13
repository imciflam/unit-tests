using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//ConcreteProductA2

namespace Kpo4310.mvv.Lib
{
    public class ElementaryParticleSplitFileSaver : IElementaryParticlesListSaver
    {

      FileStream fstream = new FileStream(@"C:\Users\Vitalia\Desktop\4\file.txt", FileMode.OpenOrCreate);
        public int Save()
        {

            ElementaryParticleListSplitFileLoader x = new ElementaryParticleListSplitFileLoader(Convert.ToString(AppGlobalSettings.DataFile));
            x.Execute();
            try
            {
                {
                   foreach (var elementaryParticle in x.elementaryParticleList)
                    {
                        byte[] array = System.Text.Encoding.Default.GetBytes(elementaryParticle.name + "|" + elementaryParticle.group + "|" + elementaryParticle.charge + "|" + elementaryParticle.weight + Environment.NewLine);
                        fstream.Write(array, 0, array.Length);
                    }
                }

            }
            finally
            {
                if (fstream != null)
                {
                    fstream.Close();
                }
            }
            
            return 0;
        }
        public void chargeChecker(byte[] array)
        {

        }
    }
}
