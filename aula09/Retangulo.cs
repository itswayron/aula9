using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula09
{
    public struct Retangulo(int Altura, int Largura)
    {
        public int getArea() => Altura * Largura;

        public int getPerimetro() => (Largura + Altura) * 2;
    }
}
