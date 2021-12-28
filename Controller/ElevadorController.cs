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
        ElevadorModel _elevador;

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
                    _elevador = new ElevadorModel();
                    _elevador.Inicializar(capacidadeDePessoas, andaresDoPredio);
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

        //Pega o input do usuário
        public void InputUsuario()
        {
            int input = int.Parse(Console.ReadLine());

            if (input < 0 || input > 4)
            {
                throw new Exception("Comando inválido!");
            }

            switch (input)
            {
                case 0:
                    _elevador.Entrar();
                    break;
                case 1:
                    _elevador.Sair();
                    break;
                case 2:
                    _elevador.Subir();
                    break;
                case 3:
                    _elevador.Descer();    
                    break;
                default:
                    break;
            }
        }

        //Coloca na tela o que foi necessário
        public void Print()
        {
            ElevadorView.View(_elevador);            
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

                    if (andares < 1 || andares > 999)
                    {
                        throw new Exception("Total de Andares tem que ser maior que 1 e menor que 999");
                    }

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
                    if (capPessoas < 1 || capPessoas > 999)
                    {
                        throw new Exception("Capacidade tem que ser maior que 1 e menor que 999");
                    }
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

