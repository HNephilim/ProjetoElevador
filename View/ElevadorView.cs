using ProjetoElevador.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.View
{
    internal class ElevadorView
    {
                
        //Desenha o Elevador na tela
        static public void View(ElevadorModel elevador)
        {
            Console.WriteLine($"O elevador está no {elevador.andarAtual} andar e tem {elevador.qtdAtualDePessoas} pessoas");
            PrintMenu();
        }

        //Coloca o Menu Na tela
        static public void PrintMenu()
        {
            Console.WriteLine(@"
    0 - Entrar 1 pessoa         2 - Subir 1 andar
    1 - Sair 1 pessoa           3 - Descer 1 andar");
        }
    }
}
