using System;
using System.Collections.Generic;
using System.Text;
using BilletLibrary;

namespace StorebaeltLibrary
{
    /// <summary>
    /// Denne klasse indeholder en metode der udregner weekend rabat for biler, lørdag og søndag. Den tjekker derefter om køretøjet har brobizz ved brug af pris() metoden.
    /// </summary>

    public class WeekendRabat
    {

        public static decimal weekendRabat(Køretøj etKøretøj)
        {
            if (etKøretøj.KøretøjType == "Bil" && etKøretøj.Dato.DayOfWeek == DayOfWeek.Saturday && etKøretøj.Dato.DayOfWeek == DayOfWeek.Saturday)
            {
                etKøretøj.Pris = etKøretøj.pris();

                etKøretøj.Pris = etKøretøj.Pris - Decimal.Multiply(etKøretøj.Pris, new decimal(0.20));

                return etKøretøj.Pris;
            }

            etKøretøj.Pris = etKøretøj.pris();

            return etKøretøj.Pris;
        }
    }
}
