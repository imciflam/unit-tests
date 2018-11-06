using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//interface IAbstractFactory 
//split and test
namespace Kpo4310.mvv.Lib
{
    public interface IElementaryParticlesFactory
    {
        IElementaryParticlesListLoader CreateElementaryParticlesListLoader();
        IElementaryParticlesListSaver CreateElementaryParticlesListSaver();
    }
}
