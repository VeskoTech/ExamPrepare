using Empare.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empare.Models
{
    class Unit : IUnit
    {
        int IUnit.Damage { get; }
        int IUnit.Health { get; set; }
    }
}
