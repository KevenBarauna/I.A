using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Fases
{
    class Fase03
    {

        public int Fase_03(int pontos)
        {
            Console.Clear();

            int x = 51;
            int y = 10;
            int resposta;
            Desenho tela = new Desenho();


            Console.SetCursorPosition(x, y + 1); Console.WriteLine(@" /$$$$$$$$                                  /$$$$$$   /$$$$$$ ");
            Console.SetCursorPosition(x, y + 2); Console.WriteLine(@"| $$_____/                                 /$$$_  $$ /$$__  $$");
            Console.SetCursorPosition(x, y + 3); Console.WriteLine(@"| $$    /$$$$$$   /$$$$$$$  /$$$$$$       | $$$$\ $$|__/  \ $$");
            Console.SetCursorPosition(x, y + 4); Console.WriteLine(@"| $$$$$|____  $$ /$$_____/ /$$__  $$      | $$ $$ $$   /$$$$$/");
            Console.SetCursorPosition(x, y + 5); Console.WriteLine(@"| $$__/ /$$$$$$$|  $$$$$$ | $$$$$$$$      | $$\ $$$$  |___  $$");
            Console.SetCursorPosition(x, y + 6); Console.WriteLine(@"| $$   /$$__  $$ \____  $$| $$_____/      | $$ \ $$$ /$$  \ $$");
            Console.SetCursorPosition(x, y + 7); Console.WriteLine(@"| $$  |  $$$$$$$ /$$$$$$$/|  $$$$$$$      |  $$$$$$/|  $$$$$$/");
            Console.SetCursorPosition(x, y + 8); Console.WriteLine(@"|__/   \_______/|_______/  \_______/       \______/  \______/ ");


            Console.SetCursorPosition(x - 13, y + 12); Console.WriteLine("No caminho de casa até o mercado, uma senhora conta 10 árvores a sua direita. Após as compras, ela ");
            Console.SetCursorPosition(x - 13, y + 13); Console.WriteLine("   volta para casa e conta 10 árvores a sua esquerda. Quantas árvores ela viu no total nesse dia?  ");


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(x + 10, y + 35); Console.WriteLine("* ESSA É UMA PERGUNTA DE NÚMEROS, SÓ DIGITE NÚMEROS");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.SetCursorPosition(x + 29, y + 18);  Console.WriteLine("[    ]");
            Console.SetCursorPosition(x + 31, y + 18); String resptemp = Console.ReadLine();
            tela.DesenhoFundo();
            Console.Clear();

            if (resptemp == "10")
            {
                tela.Parabens();
                return pontos = pontos + 1;
            }
            else
            {
                tela.Errou();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(4, y + 35); Console.WriteLine("* RESPOSTA: 10. São as mesmas dez árvores vistas de diferentes perspectivas. Na ida, as árvores estavam à direita da mulher, mas na volta, quando ela estava");
                Console.SetCursorPosition(4, y + 36); Console.WriteLine("                                             no sentido contrário da rua, as plantas podiam ser vistas à esquerda.                                           ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ReadKey();
                Console.Clear();
                return pontos;
            }

        }
    }
}
