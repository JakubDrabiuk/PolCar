using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolCar_WinForms
{
    internal class Zadania
    {
        public int ZadId { get; set; }

        public string ZadNaglowek { get; set; }

        public string ZadOpis { get; set; }

        public int ZadPriorytet { get; set; }

        public int? ZadStatus { get; set; }

        public int ZadPracownik { get; set; }
        public DateTime Zad_Data { get; set; }

        
    }
}
