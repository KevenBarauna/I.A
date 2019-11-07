using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace JogoDaVelha.Fases
{
    class Fase01
    {

        public int Fase_01(int pontos)
        {
            Console.Clear();

            int x = 51;
            int y = 10;
            int resposta;
            Desenho tela = new Desenho();


            Console.SetCursorPosition(x, y+1);   Console.WriteLine("$$$$$$$$\\                                  $$$$$$\\    $$\\ ");
            Console.SetCursorPosition(x, y+2);   Console.WriteLine("$$  _____|                                $$$ __$$\\ $$$$ |  ");
            Console.SetCursorPosition(x, y+3);   Console.WriteLine("$$ |   $$$$$$\\   $$$$$$$\\  $$$$$$\\        $$$$\\ $$ |\\_$$ | ");
            Console.SetCursorPosition(x, y + 4); Console.WriteLine("$$$$$\\ \\____$$\\ $$  _____|$$  __$$\\       $$\\$$\\$$ |  $$ |  ");
            Console.SetCursorPosition(x, y + 5); Console.WriteLine("$$  __|$$$$$$$ |\\$$$$$$\\  $$$$$$$$ |      $$ \\$$$$ |  $$ | ");
            Console.SetCursorPosition(x, y + 6); Console.WriteLine("$$ |  $$  __$$ | \\____$$\\ $$   ____|      $$ |\\$$$ |  $$ |  ");
            Console.SetCursorPosition(x, y + 7); Console.WriteLine("$$ |  \\$$$$$$$ |$$$$$$$  |\\$$$$$$$\\       \\$$$$$$  /$$$$$$\\ ");
            Console.SetCursorPosition(x, y + 8); Console.WriteLine("\\__|   \\_______|\\_______/  \\_______|       \\______/ \\______|");

            
            Console.SetCursorPosition(x-13, y + 12); Console.WriteLine("VOCÊ ESTÁ PARTICIPANDO DE UMA CORRIDA E ULTRAPASSA O SEGUNDO COLOCADO EM QUE POSIÇÃO VOCÊ FICA?");
          

            Console.SetCursorPosition(x-5, y + 35); Console.WriteLine("* ESSA É UMA PERGUNTA LOGICA, RESPONDA SOMENTE COM NÚMEROS. -> 1 , 2 , 3 , 4 , 5 ...");


            Console.WriteLine("\n");
            Console.SetCursorPosition(x+30, y + 22);
            try
            {
                resposta = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(x + 20, y + 20);
                Console.WriteLine("Digite somente números");
                Console.SetCursorPosition(x + 30, y + 22);
                Console.WriteLine("");
                Console.SetCursorPosition(x + 30, y + 22);
                resposta = Convert.ToInt32(Console.ReadLine());
            }

            tela.DesenhoFundo();
            Console.Clear();

            if (resposta == 2)
            {
                tela.Parabens();
                return pontos = pontos + 1;
            }
            else
            {
                tela.Errou();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(40, y + 35); Console.WriteLine("*RESPOSTA: Se você ultrapassa o segundo colocado, assume o lugar dele, ficando em segundo!");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ReadKey();
                return pontos;
            }

        }
    }
}
