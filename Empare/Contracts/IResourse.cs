using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empare.Contracts
{
    interface IResource
    {
         string Type { get; set; }
         int Quantity { get; set; }
    }
}
