using Empare.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empare.Models
{
    public abstract class Building : IBuilding
    {
        private int currTurn = Turns.TurnsCount;
        public string ResourceType { get; set; }
        public Resource Resource { get; set; }
        public Unit Unit { get; set; }

        public Building(string resouceType)
        {
            this.ResourceType = resouceType;
           
        }

        public void ProduceResourse()
        {
            throw new NotImplementedException();
        }

        public void ProduceUnit()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {

        }
    }
}
