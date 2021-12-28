using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    internal class ElevadorModel
    {
        //Variáveis privadas, inicializadas em 0 por segurança
        int _quantidadeDeAndares = 0;
        public int andarAtual = 0;

        int _capDePessoas = 0;
        public int qtdAtualDePessoas =0;

        //Cria um Elevador. Se deve passar o número de pessoas que cabem no elevador e o total de andares no prédio.
        //Se o número passado for inferior a 1 ou superior a 999 (já não faz sentido ser tao grande), joga um exceção.
        public ElevadorModel() { }

        public void Inicializar(int capacidadeDoElevador, int totalDeAndares)
        {
            //Constroi e retorna;        
            _capDePessoas = capacidadeDoElevador;
            _quantidadeDeAndares = totalDeAndares;
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
