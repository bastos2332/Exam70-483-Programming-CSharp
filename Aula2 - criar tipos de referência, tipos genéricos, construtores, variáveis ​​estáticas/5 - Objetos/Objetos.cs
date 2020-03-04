using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70_483
{
    class Objetos : IAulaItem
    {
        public void Executar()
        {
            Jogador.SomarObjeto();
        }
    }

    class Jogador
    {
        //public int Pontuacao { get; set; } = 10;
        public static void SomarObjeto()
        {
            object objetco =-1;

            dynamic dinamico = new int().CompareTo(objetco);
            Console.WriteLine(dinamico);
        }

    }
}
