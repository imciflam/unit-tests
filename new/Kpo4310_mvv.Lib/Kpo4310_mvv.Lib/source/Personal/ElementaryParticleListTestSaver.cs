using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ConcreteProductA1

namespace Kpo4310.mvv.Lib
{
     public class ElementaryParticleListTestSaver : IElementaryParticlesListSaver
    {
        public int Save()
        {
            return 0;
        }
        public void chargeChecker()
        {
            FileStream fstream = new FileStream(@"C:\Users\Vitalia\Desktop\4\charge.txt", FileMode.OpenOrCreate);
            ElementaryParticleListTestLoader x = new ElementaryParticleListTestLoader();
            x.Execute();
            foreach (var elementaryParticle in x.elementaryParticleList)
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(elementaryParticle.charge + Environment.NewLine);
                fstream.Write(array, 0, array.Length);
            }
        }
    }
}
