/**************************************************
 * Übungsnr:        01                                     
 * Programmname:    Währungsrechner                                  
 * Autor:           Michael Bucek                      
 * ------------------------------------------------ 
 * Kurzbeschreibung:      
 * Es wird ein Eurobetrag eingelesen und dann der
 * entsprechende Betrag in Dollar und Schweizer 
 * Franken ausgegeben.
 * 
 * ************************************************
*/

using System;

namespace WaehrungsRechner
{
    class Waehrung
    {
        static void Main(string[] args)
        {
            // Definition der Variablen
            // Wechselkurse vom 25.9.12 als Konstanten definiert
            const double EURODOLLAR = 1.3523;
            const double EUROCHF = 1.2314;
            // Variablen definieren
            int euro;
            double dollar;
            double schweizerFranken;
            string input;
            // Überschrift ausgeben
            Console.WriteLine("Waehrungsrechner von Euro in Dollar und Schweizer Franken");
            
            // Eingabeaufforderung mit Eingabe in gleicher Zeile
            Console.Write("Eingabe des Betrags in Euro: ");
            input = Console.ReadLine();  // Eingabe von Tastatur ist immer Text

            // Verarbeitung
            euro = Convert.ToInt32(input);  // in Ganzahl umwandeln
            dollar = euro * EURODOLLAR;  // Dollars berechnen
            schweizerFranken = euro * EUROCHF; // Fränklis

            // Ausgabe
            Console.WriteLine(euro+"€ sind "+dollar+" Dollar");
            Console.WriteLine("{0} € sind {1} Franken",euro,schweizerFranken);
            Console.Write("Zum Beenden bitte Eingabetaste drücken ...");
            Console.ReadLine();
        }
    }
}
