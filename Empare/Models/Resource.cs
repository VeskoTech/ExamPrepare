using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empare.Contracts;

namespace Empare.Models
{
    public abstract class Resource : IResource
    {
        public int Quantity { get; set; }
        public string Type { get; set; }
    }
}
