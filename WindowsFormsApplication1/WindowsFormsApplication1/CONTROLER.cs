using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Math


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
            laufzeitdata[0]="1";



        }

        public string Zufall(int min, int max,  int length = -1){
            //Erzeugt eine Zufallszahl im zahlenbereich zwischen min und max. Wenn length -1 ist, ist die länge eben so lang wie es zufällig rauskommt.
            //-1 heißt, dass die Zufallszahl genau diese Anzahl an Stellen haben muss (z.b für IDs)
            return laufzeitdata[0];

            



        }
        
       
        public int get_newId(){laufzeitdata[0].toInt32()); laufzeitdata[0]+=1;
            laufzeitdata[0].      
                Last.

            
        
        }


        


    }
}
