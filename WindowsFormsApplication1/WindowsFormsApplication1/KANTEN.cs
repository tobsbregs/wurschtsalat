using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1{
    class KANTEN{

         public String[] verbindung = new string[2];
        //Die Variabe Verbindund soll speichern, zu welche Knoten die Kante verbindet. Dabei wird über den Index berücksichtigt, ob die Kante gerichtet (-1) 
        //ungerichtet (1) oder verborgen (0) ist. Die Erste Spalte ist der Index, die Zweite der Knoten A und der Dritte Knoten B. Eine 1 verbindet A mit B in beiden
        //Richtungen. Bei -1 ist nur von A nach B möglich. 0 bzw. -0 ist eine Stillegung der Kante. Die werte bitte als STRING speichern und mit equal testen!!
         public string[] eigenschaften = new string[2];

        public KANTEN (){
            verbindung[0]="1";
            verbindung[1]="012";
            verbindung[2]="902";

	    }
       
         public string[] get_verbindung(){
            return verbindung;
         }


    }
  
}
