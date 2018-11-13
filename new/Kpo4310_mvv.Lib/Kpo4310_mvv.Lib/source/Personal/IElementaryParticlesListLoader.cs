using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//interface B,
//IAbstractProductB

namespace Kpo4310.mvv.Lib
{

    public interface IElementaryParticlesListLoader
    {
       
        List<elementaryParticle> elementaryParticleList
        {
            get;
        }
        LoadStatus status
        {
            get;
        }

         void Execute(); 
    }
}
