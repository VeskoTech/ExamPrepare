using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empare.Contracts
{
    interface IBuilding
    {
       string BuildingType { get; set; }
       void ProduceUnit();
       void ProduceResourse();
    }
}
