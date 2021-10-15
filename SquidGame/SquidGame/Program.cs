using System;

namespace SquidGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var decisao = "";
            string[] rota = { "Viveu", "Morreu" };

            Random random = new Random();
            int number = random.Next(001, 999);
            int index = random.Next(rota.Length);
            

            //Nome
            Console.WriteLine("Olá jogador n°" + number + ". Nós vamos jogar o jogo da ponte mortal. Escolha a rota que deseja seguir e veremos o seu destino. Precione ENTER para iniciar o jogo.");
            Console.ReadLine();
            Console.Clear();

            var sair = false;

            for (int i = 1; i <= 5; i++) {
                Console.WriteLine("");
                Console.WriteLine("Escolha um dos três caminhos para seguir, digitando 1, 2 OU 3!");
                Console.WriteLine("Etapa " + i + " de 5");
                Console.WriteLine("Rota 1");
                Console.WriteLine("Rota 2");
                Console.WriteLine("Rota 3");
                Console.Write("\r\nSelecione a rota: ");
            

                decisao = Console.ReadLine();
                switch (decisao.ToUpper())
                {
                    case "1":
                        Console.WriteLine("Você " + rota[index]);
                        if (index == 1) { sair = true; }
                        break;

                    case "2":
                        Console.WriteLine("Você " + rota[index]);
                        if (index == 1) { sair = true; }
                        break;

                    case "3":
                        Console.WriteLine("Você " + rota[index]);
                        if (index == 1) { sair = true; }
                        break;
                }
                Console.WriteLine("");
                if (sair)
                {
                    break;
                }
            }
        }
    }
}
