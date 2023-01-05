using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Earn
{
    public class ForeingEarnFactory : EarnFactory
    {
        private decimal _porcentaje;
        private decimal _extra;
        public ForeingEarnFactory(decimal porcentaje, decimal extra)
        {
            _porcentaje = porcentaje;
            _extra = extra;
        }

        public override IEarn GetEarn()
        {
            return new ForeingEarn(_porcentaje, _extra);
        }
    }
}
