using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Earn
{
    public class ForeingEarn : IEarn
    {
        private decimal _porcentaje;
        private decimal _extra;

        public ForeingEarn(decimal porcentaje, decimal extra)
        {
            _porcentaje = porcentaje;
            _extra = extra;
        }

        public decimal Earn(decimal amount)
        {
            return (_porcentaje * amount) + _extra;
        }
    }
}
