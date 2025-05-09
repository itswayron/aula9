using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula09
{
    internal struct Cor
    {
        int Red;
        int Green;
        int Blue;
        public Cor(int Red, int Green, int Blue)
        {
            if (Red < 0 || Red > 255 || Green < 0 || Green > 255 || Blue < 0 || Blue > 255)
            {
                throw new ArgumentException("Valores fornecidos inválidos: os valores de RGB devem estar entre 0 e 255.");
            }
            this.Red = Red;
            this.Green = Green;
            this.Blue = Blue;
        }
        public string toHex() => $"#{Red:X2}{Green:X2}{Blue:X2}";
    }
}
