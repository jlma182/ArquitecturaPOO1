using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos1
{
    public class Auto:Automovil
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Lanzamiento { get; set; }
        public int Color { get; set; }
        public int Velocidad { get; set; }
        private string CodigoMotor;

        public Auto()
        {
            CodigoMotor = "d15b";
        }

        public void Enciende()
        {
            
        }

        public string Acelera()
        {
            caballosDeFuerza();
            return "corro con motor" + CodigoMotor;
        }

        public void Frena()
        {
            Velocidad = Velocidad - 1;
        }

        public void Choca()
        {
            CodigoMotor = "k20b";
        }

    }
}
