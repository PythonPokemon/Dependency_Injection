using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    // Schnittstelle für Verbrennungsverhalten
    public interface IVerbrennung
    {
        void Verbrennen();
    }

    // Implementierung für Benzinmotor
    public class Benzinmotor : IVerbrennung
    {
        public void Verbrennen()
        {
            Console.WriteLine("Benzin wird verbrannt.");
        }
    }

    // Implementierung für Dieselmotor
    public class Dieselmotor : IVerbrennung
    {
        public void Verbrennen()
        {
            Console.WriteLine("Diesel wird verbrannt.");
        }
    }
}
