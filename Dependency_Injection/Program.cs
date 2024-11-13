
using Dependency_Injection;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Erstellen des Fahrzeugs mit Benzinmotor
        IVerbrennung benzinmotor = new Benzinmotor();
        Fahrzeug fahrzeugMitBenzin = new Fahrzeug(benzinmotor);
        fahrzeugMitBenzin.Fahren();

        // Erstellen des Fahrzeugs mit Dieselmotor
        IVerbrennung dieselmotor = new Dieselmotor();
        Fahrzeug fahrzeugMitDiesel = new Fahrzeug(dieselmotor);
        fahrzeugMitDiesel.Fahren();
    }
}