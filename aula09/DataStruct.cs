using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula09
{
    internal struct DataStruct
    {
        public int dia;
        public int mes;
        public int ano;
        public DataStruct(string data)
        {
            string[] dados = data.Split('/');
            dia = int.Parse(dados[0]);
            mes = int.Parse(dados[1]);
            ano = int.Parse(dados[2]);
            ValidarData(new int[] { dia, mes });
            Console.WriteLine($"A data é: {dia}/{mes}/{ano}");
        }

        public void ValidarData(int[] data)
        {
            int dia = data[0];
            int mes = data[1];

            if (dia > 32 || dia < 1)
            {
                throw new Exception("A data é invalida: o dia fornecido está inválido.");
            }

            if (mes > 12 || mes < 1)
            {
                throw new Exception("A data é invalida: o mês fornecido está inválido.");
            }
            this.dia = dia;
            this.mes = mes;
        }
    }
}
