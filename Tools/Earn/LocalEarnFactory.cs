using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Earn
{
    public class LocalEarnFactory : EarnFactory
    {
        private decimal _porcentaje;

        public LocalEarnFactory(decimal porcentaje)
        {
            _porcentaje = porcentaje;
        }

        public override IEarn GetEarn()
        {
            return new LocalEarn(_porcentaje);
        }
    }
}
