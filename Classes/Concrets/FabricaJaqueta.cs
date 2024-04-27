using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSFactoryMethod.Classes
{
    class FabricaJaqueta : FabricaRoupas
    {
        public Roupas CriarRoupa()
        {
            return new Jaqueta();
        }

    }
}
