using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//ConcreteProductA2

namespace Kpo4310.mvv.Lib
{
     class ElementaryParticleSplitFileSaver : IElementaryParticlesListSaver
    {

      FileStream fstream = new FileStream(@"C:\Users\Vitalia\Desktop\4\file.txt", FileMode.OpenOrCreate);
        public int Save()
        {

            ElementaryParticleListSplitFileLoader x = new ElementaryParticleListSplitFileLoader(Convert.ToString(AppGlobalSettings.DataFile));
            x.Execute();
            //x.elementaryParticleList.CopyTo(array);
            // using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Vitalia\source\repos\Kpo4310_mvv 3rd lab\file.txt"))
            // foreach (var elementaryParticle in x.elementaryParticleList)
            // {
            //      file.WriteLine(elementaryParticle.name + "|" + elementaryParticle.group + "|" + elementaryParticle.charge + "|" + elementaryParticle.weight + Environment.NewLine);
            //     
            //  } 
            try
            {
                {
                   foreach (var elementaryParticle in x.elementaryParticleList)
                    {
                        //file.WriteLine(elementaryParticle.name + "|" + elementaryParticle.group + "|" + elementaryParticle.charge + "|" + elementaryParticle.weight + Environment.NewLine);
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
    }
}
