using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam70_483
{
    class Controlador
    {
        public void ExecutarAula(IAulaItem aula)
        {
            aula.Executar();
        }
    }
}
