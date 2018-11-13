using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ConcreteFactory2

namespace Kpo4310.mvv.Lib
{
    internal class ElementaryParticleSplitFileFactory : IElementaryParticlesFactory
    {
        
        public IElementaryParticlesListSaver CreateElementaryParticlesListSaver()
        {
            return new ElementaryParticleSplitFileSaver();
        }

        public IElementaryParticlesListLoader CreateElementaryParticlesListLoader()
        {
            return new ElementaryParticleListSplitFileLoader(Convert.ToString(AppGlobalSettings.DataFile));
        }

    }
}
