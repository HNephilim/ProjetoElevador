using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    internal class Elevador
    {
        //Variáveis privadas, inicializadas em 0 por segurança
        int _quantidadeDeAndares = 0;
        public int andarAtual = 0;

        int _capDePessoas = 0;
        public int qtdAtualDePessoas =0;

        //Um construtor privado é necessário para evitar a construção errada do objeto.
        //O unico jeito de inicializar a classe é através do método estático "Incializar"
        private Elevador() { }

        //Quantidade de pessoas dendo do elevador
        

        //Cria um Elevador. Se deve passar o número de pessoas que cabem no elevador e o total de andares no prédio.
        //Se o número passado for inferior a 1 ou superior a 999 (já não faz sentido ser tao grande), joga um exceção.
        static public Elevador Inicializar(int capacidadeDoElevador, int totalDeAndares)
        {
            //Checa o input
            if (capacidadeDoElevador < 1 || capacidadeDoElevador > 999)
            {
                throw new Exception("Capacidade tem que ser maior que 1 e menor que 999");
            }
            if (totalDeAndares < 1 || totalDeAndares > 999)
            {
                throw new Exception("Total de Andares tem que ser maior que 1 e menor que 999");
            }

            //Constroi e retorna;
            Elevador elevador = new Elevador {
                _capDePessoas = capacidadeDoElevador,
                _quantidadeDeAndares = totalDeAndares 
            };

            return elevador;
        }

        //Permite colocar uma pessoa para dentro do elevador
        //Retorna a quantidade de pessoas dentro do elevador após a entrada
        //Se o Elevador estiver cheio, joga uma exceção
        public int Entrar()
        {
            if (qtdAtualDePessoas + 1 > _capDePessoas)
            {
                throw new Exception("Capacidade de pessoas excedita");
            }
            else
            {
                qtdAtualDePessoas += 1;
            }

            return qtdAtualDePessoas;

        }        

        //Retira uma pessoa de dentro do elevador
        //Retorna a quantidade de pessoas dentro do elevador após a saída
        //Se o Elevador estiver vazio, joga uma exceção.
        public int Sair()
        {
            if (qtdAtualDePessoas - 1 < 0)
            {
                throw new Exception("Não há mais pessoas no Elevador");
            }
            else
            {
                qtdAtualDePessoas -= 1;
            }

            return qtdAtualDePessoas;
        }

        //Sobe um andar
        //Se estiver no topo do prédio, joga uma exceção
        //Retorna o andar atual após a movimentação
        public int Subir()
        {
            if (andarAtual == _quantidadeDeAndares)
            {
                throw new Exception("Elevador já está no topo");
            }
            else
            {
                andarAtual += 1;
            }

            return andarAtual;
        }

        //Desce um andar
        //Se estiver no terreo do prédio, joga uma exceção
        //Retorna o andar atual após a movimentação
        public int Descer()
        {
            if (andarAtual == 0)
            {
                throw new Exception("Elevador já está no térreo");
            }
            else
            {
                andarAtual -= 1;
            }

            return andarAtual;
        }


    }
}
