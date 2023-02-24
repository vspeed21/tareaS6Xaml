using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioMVVMS2.NewFolder2
{
    public class Expresion
    {
        public double numero1 { get; set; }
        public double numero2 { get; set; }

        
        public string suma() { 
            return $"La suma de ambos numeros es {numero1 + numero2}"; 
        }

        public string resta()
        {
            return $"La resta de ambos numeros es {numero1 - numero2}";
        }

        public string multiplicacion()
        {
            return $"La multiplicacion de ambos numeros es {numero1 * numero2}";
        }

        public string division()
        {
            return $"La division de ambos numeros es {numero1 / numero2}";
        }

    }
}
