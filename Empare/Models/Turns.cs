using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empare.Models
{
    public static class Turns
    {
        public static int TurnsCount { get; private set; }

        public static void IncrementTurns()
        {
            TurnsCount++;
        }
    }
}
