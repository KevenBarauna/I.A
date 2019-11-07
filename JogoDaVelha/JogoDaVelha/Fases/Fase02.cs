using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JogoDaVelha.Fases
{
    class Fase02
    {

        public int Fase_02(int pontos)
        {
            Console.Clear();

            int x = 51;
            int y = 10;
            int resposta;
            Desenho tela = new Desenho();


            Console.SetCursorPosition(x, y + 1); Console.WriteLine(@" /$$$$$$$$                                  /$$$$$$   /$$$$$$");
            Console.SetCursorPosition(x, y + 2); Console.WriteLine(@"| $$_____/                                 /$$$_  $$ /$$__  $$");
            Console.SetCursorPosition(x, y + 3); Console.WriteLine(@"| $$    /$$$$$$   /$$$$$$$  /$$$$$$       | $$$$\ $$|__/  \ $$");
            Console.SetCursorPosition(x, y + 4); Console.WriteLine(@"| $$$$$|____  $$ /$$_____/ /$$__  $$      | $$ $$ $$  /$$$$$$/");
            Console.SetCursorPosition(x, y + 5); Console.WriteLine(@"| $$__/ /$$$$$$$|  $$$$$$ | $$$$$$$$      | $$\ $$$$ /$$____/");
            Console.SetCursorPosition(x, y + 6); Console.WriteLine(@"| $$   /$$__  $$ \____  $$| $$_____/      | $$ \ $$$| $$     ");
            Console.SetCursorPosition(x, y + 7); Console.WriteLine(@"| $$  |  $$$$$$$ /$$$$$$$/|  $$$$$$$      |  $$$$$$/| $$$$$$$$");
            Console.SetCursorPosition(x, y + 8); Console.WriteLine(@"|__/   \_______/|_______/  \_______/       \______/ |________/");


            Console.SetCursorPosition(x+10, y + 12); Console.WriteLine("GOSTARIA DE TENTAR LER SUA MENTE... NÚMERO");
            Console.SetCursorPosition(x + 13, y + 13); Console.WriteLine("PENSE EM QUALQUER NÚMERO ENTRE 1 E 10");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x + 19, y + 14); Console.WriteLine("[ NÚMERO = (1 ... 10) ]");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(x+10, y + 35); Console.WriteLine("* ESSA É UMA PERGUNTA ADIVINHAÇÃO, SÓ APERTE ENTER");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ReadKey(false);

            Console.Clear();

            Console.SetCursorPosition(x, y + 1); Console.WriteLine(@" /$$$$$$$$                                  /$$$$$$   /$$$$$$");
            Console.SetCursorPosition(x, y + 2); Console.WriteLine(@"| $$_____/                                 /$$$_  $$ /$$__  $$");
            Console.SetCursorPosition(x, y + 3); Console.WriteLine(@"| $$    /$$$$$$   /$$$$$$$  /$$$$$$       | $$$$\ $$|__/  \ $$");
            Console.SetCursorPosition(x, y + 4); Console.WriteLine(@"| $$$$$|____  $$ /$$_____/ /$$__  $$      | $$ $$ $$  /$$$$$$/");
            Console.SetCursorPosition(x, y + 5); Console.WriteLine(@"| $$__/ /$$$$$$$|  $$$$$$ | $$$$$$$$      | $$\ $$$$ /$$____/");
            Console.SetCursorPosition(x, y + 6); Console.WriteLine(@"| $$   /$$__  $$ \____  $$| $$_____/      | $$ \ $$$| $$     ");
            Console.SetCursorPosition(x, y + 7); Console.WriteLine(@"| $$  |  $$$$$$$ /$$$$$$$/|  $$$$$$$      |  $$$$$$/| $$$$$$$$");
            Console.SetCursorPosition(x, y + 8); Console.WriteLine(@"|__/   \_______/|_______/  \_______/       \______/ |________/");

            Console.SetCursorPosition(x + 15, y + 12); Console.WriteLine("MULTIPLIQUE ESSE NÚMERO POR 9");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x + 18, y + 13); Console.WriteLine("[ NÚMERO * 9 = NÚMERO) ]");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(x + 10, y + 35); Console.WriteLine("* ESSA É UMA PERGUNTA ADIVINHAÇÃO, SÓ APERTE ENTER");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ReadKey(false);

            Console.Clear();

            Console.SetCursorPosition(x, y + 1); Console.WriteLine(@" /$$$$$$$$                                  /$$$$$$   /$$$$$$");
            Console.SetCursorPosition(x, y + 2); Console.WriteLine(@"| $$_____/                                 /$$$_  $$ /$$__  $$");
            Console.SetCursorPosition(x, y + 3); Console.WriteLine(@"| $$    /$$$$$$   /$$$$$$$  /$$$$$$       | $$$$\ $$|__/  \ $$");
            Console.SetCursorPosition(x, y + 4); Console.WriteLine(@"| $$$$$|____  $$ /$$_____/ /$$__  $$      | $$ $$ $$  /$$$$$$/");
            Console.SetCursorPosition(x, y + 5); Console.WriteLine(@"| $$__/ /$$$$$$$|  $$$$$$ | $$$$$$$$      | $$\ $$$$ /$$____/");
            Console.SetCursorPosition(x, y + 6); Console.WriteLine(@"| $$   /$$__  $$ \____  $$| $$_____/      | $$ \ $$$| $$     ");
            Console.SetCursorPosition(x, y + 7); Console.WriteLine(@"| $$  |  $$$$$$$ /$$$$$$$/|  $$$$$$$      |  $$$$$$/| $$$$$$$$");
            Console.SetCursorPosition(x, y + 8); Console.WriteLine(@"|__/   \_______/|_______/  \_______/       \______/ |________/");

            Console.SetCursorPosition(x + 12, y + 12); Console.WriteLine("O RESULTADO FOI DE UM DIGITO OU DOIS ?");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x + 16, y + 13); Console.WriteLine("[ NÚMERO = 8 -> UM DIGITO) ]");
            Console.SetCursorPosition(x + 16, y + 14); Console.WriteLine("[ NÚMERO = 16 -> DOIS DIGITOS) ]");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(x + 23, y + 16); Console.WriteLine("[1] - UM DIGITO");
            Console.SetCursorPosition(x + 23, y + 17); Console.WriteLine("[2] - DOIS DIGITO");
            Console.SetCursorPosition(x + 29, y + 18); Console.WriteLine("[   ]");
            Console.SetCursorPosition(x + 31, y + 18);

            int resptemp;
            try
            {
                 resptemp = Convert.ToInt32( Console.ReadLine() );
            }catch
            {
                Console.SetCursorPosition(x + 20, y + 20);
                Console.WriteLine("Digite somente números");
                Console.SetCursorPosition(x + 30, y + 22);
                Console.WriteLine("");
                Console.SetCursorPosition(x + 30, y + 22);
                resptemp = Convert.ToInt32(Console.ReadLine());
            }


            if (resptemp == 2)
            {

                Console.Clear();

                Console.SetCursorPosition(x, y + 1); Console.WriteLine(@" /$$$$$$$$                                  /$$$$$$   /$$$$$$");
                Console.SetCursorPosition(x, y + 2); Console.WriteLine(@"| $$_____/                                 /$$$_  $$ /$$__  $$");
                Console.SetCursorPosition(x, y + 3); Console.WriteLine(@"| $$    /$$$$$$   /$$$$$$$  /$$$$$$       | $$$$\ $$|__/  \ $$");
                Console.SetCursorPosition(x, y + 4); Console.WriteLine(@"| $$$$$|____  $$ /$$_____/ /$$__  $$      | $$ $$ $$  /$$$$$$/");
                Console.SetCursorPosition(x, y + 5); Console.WriteLine(@"| $$__/ /$$$$$$$|  $$$$$$ | $$$$$$$$      | $$\ $$$$ /$$____/");
                Console.SetCursorPosition(x, y + 6); Console.WriteLine(@"| $$   /$$__  $$ \____  $$| $$_____/      | $$ \ $$$| $$     ");
                Console.SetCursorPosition(x, y + 7); Console.WriteLine(@"| $$  |  $$$$$$$ /$$$$$$$/|  $$$$$$$      |  $$$$$$/| $$$$$$$$");
                Console.SetCursorPosition(x, y + 8); Console.WriteLine(@"|__/   \_______/|_______/  \_______/       \______/ |________/");

                Console.SetCursorPosition(x + 20, y + 12); Console.WriteLine("SOME UM DIGITO AO OUTRO");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(x + 16, y + 13); Console.WriteLine("[ NÚMERO = 16 -> 1 + 6 -> 7 ) ]");
                Console.SetCursorPosition(x + 16, y + 14); Console.WriteLine("[ NÚMERO = 11 -> 1 + 1 -> 2 ) ]");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(x + 10, y + 35); Console.WriteLine("* ESSA É UMA PERGUNTA ADIVINHAÇÃO, SÓ APERTE ENTER");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ReadKey(false);
            }

            Console.Clear();

            Console.SetCursorPosition(x, y + 1); Console.WriteLine(@" /$$$$$$$$                                  /$$$$$$   /$$$$$$");
            Console.SetCursorPosition(x, y + 2); Console.WriteLine(@"| $$_____/                                 /$$$_  $$ /$$__  $$");
            Console.SetCursorPosition(x, y + 3); Console.WriteLine(@"| $$    /$$$$$$   /$$$$$$$  /$$$$$$       | $$$$\ $$|__/  \ $$");
            Console.SetCursorPosition(x, y + 4); Console.WriteLine(@"| $$$$$|____  $$ /$$_____/ /$$__  $$      | $$ $$ $$  /$$$$$$/");
            Console.SetCursorPosition(x, y + 5); Console.WriteLine(@"| $$__/ /$$$$$$$|  $$$$$$ | $$$$$$$$      | $$\ $$$$ /$$____/");
            Console.SetCursorPosition(x, y + 6); Console.WriteLine(@"| $$   /$$__  $$ \____  $$| $$_____/      | $$ \ $$$| $$     ");
            Console.SetCursorPosition(x, y + 7); Console.WriteLine(@"| $$  |  $$$$$$$ /$$$$$$$/|  $$$$$$$      |  $$$$$$/| $$$$$$$$");
            Console.SetCursorPosition(x, y + 8); Console.WriteLine(@"|__/   \_______/|_______/  \_______/       \______/ |________/");

            Console.SetCursorPosition(x + 30, y + 12); Console.WriteLine("SOME + 4 ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x + 24, y + 13); Console.WriteLine("[ NÚMERO = 8 -> 8 + 4) ]");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(x + 10, y + 35); Console.WriteLine("* ESSA É UMA PERGUNTA ADIVINHAÇÃO, SÓ APERTE ENTER");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ReadKey(false);

            Console.Clear();

            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(x + 25, y + 12); Console.WriteLine("ANALISANDO.");
                Thread.Sleep(200);
                Console.SetCursorPosition(x + 25, y + 12); Console.WriteLine("ANALISANDO..");
                Thread.Sleep(200);
                Console.SetCursorPosition(x + 25, y + 12); Console.WriteLine("ANALISANDO...");
                Thread.Sleep(200);
                Console.Clear();
            }
           

            tela.DesenhoFundo();
            Console.Clear();
            
            Console.SetCursorPosition(x + 26, y + 13); Console.WriteLine("O NÚMERO É 13");
            Console.ReadKey(false);


            tela.DesenhoFundo();
            Console.Clear();

            return pontos;

        }
    }
}
