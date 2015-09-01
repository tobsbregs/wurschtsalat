using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WindowsFormsApplication1
{
    class CONTROLER
    //Das Herzstück des ..hm wir brauchen eigentlich noch einen guten namen ;)
    {
        //DEFINITIONEN: Alle Laufzeitvariablen wie aktuelle ID, Lizenzierung, Status...
        public String[] laufzeitdata = new string[8];

        public CONTROLER()
        {
            //BEI START DES PROGRAMMS MUSS KONSTRUKTOR AUFGERUFEN WERDEN
            //MODULE LADEN UND DATEN LADEN
            //DATEN.load
            //MODULE[].load
            //Später werden hier dann die daten vom letzten Programmaufruf geladen, jetzt aber erstmal initialwerte
        



        }

        public double Zufall(int min, int max)
        {
            //Erzeugt eine Zufallszahl im zahlenbereich zwischen min und max. Wenn length -1 ist, ist die länge eben so lang wie es zufällig rauskommt.
            //-1 heißt, dass die Zufallszahl genau diese Anzahl an Stellen haben muss (z.b für IDs)
            Random zufall = new Random();
            Byte[] bytes1 = new Byte[1];
            double Zahl = 0;
      

            double abstand = max - min;

            for (int i = 1; i < 10000; i++)
            {
                
                zufall.NextBytes(bytes1);
                Zahl = bytes1[0];

               
             
                Zahl = Zahl * (abstand / 256);
                Zahl = Zahl + min;

            }

            return Zahl;
            
        }

        public int GetID() { SETTINGS.Default.ID += 1; SETTINGS.Default.Save(); return SETTINGS.Default.ID; }
    }
}
          
