using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontoverwaltung
{
    internal class Konto
    {
        // wenn nichts davor steht => private
        private double kontostand = 0;

        public double GetKontostand()
        {
            return kontostand;
        }
    }
}
