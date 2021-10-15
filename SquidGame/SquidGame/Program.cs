using System;

namespace SquidGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(001, 999);

            string rota = "";

            //Nome
            Console.WriteLine("Olá jogador n°" + number + ". Nós vamos jogar o jogo da ponte mortal. Escolha a rota que deseja seguir e veremos o seu destino. Precione ENTER para iniciar o jogo.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Escolha um dos três caminhos para seguir, digitando 1, 2 OU 3!");
            Console.WriteLine("Rota 1");
            Console.WriteLine("Rota 2");
            Console.WriteLine("Rota 3");
            Console.Write("Selecione a rota: ");

            rota = Console.ReadLine();
            Console.Clear();
            switch (rota.ToUpper())
            {
                case "1":
                    
                    break;

                case "2":
                    
                    break;

                case "3":
                    
                    break;

                case "4":

                    break;
            }

        }
    }
}
