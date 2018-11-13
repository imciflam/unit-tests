using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ConcreteFactory1 

namespace Kpo4310.mvv.Lib
{
    internal class ElementaryParticlesTestFactory : IElementaryParticlesFactory
    {
        public  IElementaryParticlesListSaver CreateElementaryParticlesListSaver()
        {
            return new ElementaryParticleListTestSaver();
        }

        public  IElementaryParticlesListLoader CreateElementaryParticlesListLoader()
        {
            return new ElementaryParticleListTestLoader();
        }
    }
}
