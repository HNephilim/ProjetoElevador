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
        static public void View(Elevador elevador)
        {
            Console.WriteLine(@"
            ===============
            |             |
            |             |
            |             |");

           //Onde a logica realmente acontece, o resto e decorativo
            if (elevador.andarAtual < 10)
            {
                Console.WriteLine($"            |      {elevador.andarAtual}      |");
            }
            else if (elevador.andarAtual < 100)
            {
                Console.WriteLine($"            |     {elevador.andarAtual}      |");
            }
            else
            {
                Console.WriteLine($"            |     {elevador.andarAtual}     |");
            }


            Console.WriteLine(
          @"            |             |
            |             |
            |             |
            ==============");
        }

        //Coloca o Menu Na tela
        static public void Menu()
        {

        }
    }
}
