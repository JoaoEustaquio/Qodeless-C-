using System;

namespace SquidGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensagem;
            int numero = 111;
            string rota = "Rota";

            //Nome
            Console.WriteLine(mensagem = "Olá jogador n°" + numero + ", precione ENTER para iniciar o jogo");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(mensagem = "Escolha um dos três caminhos para seguir, digitando 1, 2 OU 3!");
            Console.WriteLine(rota + "1");
            Console.WriteLine(rota + "2");
            Console.WriteLine(rota + "3");
            Console.ReadLine();

            //if (rota = 1)
            //{
            //    Console.WriteLine("Você passou, escolha seu próximo caminho.");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("Você morreu! Precione R para REINICIAR o jogo.");
            //    Console.ReadLine();
            //}

            //Console.Clear();
        }
    }
}
