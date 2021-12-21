using ProjetoElevador.Controller;
using ProjetoElevador.Model;
using System;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElevadorController elevadorController = new ElevadorController();

            while (true)
            {
                Console.Clear();

                try
                {
                    elevadorController.Print();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Aperte uma tecla para continuar");
                }
            }


        }
    }
}
