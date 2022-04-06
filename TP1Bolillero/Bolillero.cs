using System.Collections.Generic;

namespace TP1Bolillero
{
    public class Bolillero
    {
        public List<byte> Adentro { get; set; }
        public List <byte> Afuera {get; set; }
        public IAzar  Azar { get; set; } 
        
    }
}