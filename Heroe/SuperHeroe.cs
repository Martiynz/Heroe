using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroe
{
    public class SuperHeroe
    {
        public string Nombre { get; set; }
        public string IdentidadSecreta { get; set; }
        public string Ciudad {  get; set; }
        public Boolean PuedeVolar { get; set; }

        public void Imprimir() 
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Identidad Secreta: {IdentidadSecreta}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"Puede Volar: {PuedeVolar}");
        }
    }
}
