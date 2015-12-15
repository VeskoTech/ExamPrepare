using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empare.Contracts
{
    interface IUnit
    {
         int Health { get; set; }
         int Damage { get; }
    }
}
