using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public class Fahrzeug
    {
        private readonly IVerbrennung verbrennung;

        // Konstruktorinjektion: Das Verbrennungsverhalten wird über den Konstruktor bereitgestellt
        public Fahrzeug(IVerbrennung verbrennung)
        {
            this.verbrennung = verbrennung;
        }

        public void Fahren()
        {
            Console.WriteLine("Fahrzeug fährt...");
            verbrennung.Verbrennen();  // Aufruf des Verbrennungsverhaltens
        }
    }

}
