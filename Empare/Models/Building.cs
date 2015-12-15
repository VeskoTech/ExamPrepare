using Empare.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empare.Models
{
    public class Building : IBuilding
    {
        public string BuildingType { get; set; }
       
        public void ProduceResourse()
        {
            throw new NotImplementedException();
        }

        public void ProduceUnit()
        {
            throw new NotImplementedException();
        }
    }
}
