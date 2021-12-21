using ProjetoElevador.Model;
using ProjetoElevador.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Controller
{
    internal class ElevadorController
    {
        //Objeto Elevador controlado por essa COntroller.
        //View apenas contem metodos estaticos.
        Elevador _elevador;

        //Constroi o Contoller pegando as informações do usuário e cria também o objeto do elevador.
        public ElevadorController()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao Criador e Gerenciador de Elevador Condor");

            while(true)
            {
                int capacidadeDePessoas = SetupCapacidaDePessoas();
                int andaresDoPredio = SetupAndaresDoPredio();

                try
                {
                    _elevador = Elevador.Inicializar(capacidadeDePessoas, andaresDoPredio);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                    Console.ReadLine();
                    continue;
                }
                break;
                
            }
            

        }

        //Coloca na tela o que foi necessário
        public void Print()
        {
            ElevadorView.View(_elevador);
            Console.ReadLine();
        }


        //Funções estaticas privadas para organização de código
        static int SetupAndaresDoPredio()
        {
            int andares = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Insira a quantidade de andares no prédio");
                try
                {
                    andares = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Por favor insira um número");
                    
                    Console.ReadLine();
                    continue;
                }
                break;
            }

            return andares;
        }

        static int SetupCapacidaDePessoas()
        {
            int capPessoas = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Insira a quantidade de pessoas que caberam no seu elevador");
                try
                {
                    capPessoas = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Por favor insira um número");
                    Console.ReadLine();

                    continue;
                }
                break;
            }

            return capPessoas;
        }
    }
}

