using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Earn
{
    /// <summary>
    /// Product
    /// </summary>
    public interface IEarn
    {
        public decimal Earn(decimal amount);
    }
}
