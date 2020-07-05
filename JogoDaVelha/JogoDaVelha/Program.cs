using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using JogoDaVelha;
using JogoDaVelha.Fases;
using JogoDaVelhaUltra.Fases;

namespace JogoDaVelha
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 30;
            int y = 10;
            String result=null;
            int pontos = 0;

            Desenho TELA = new Desenho();

            Console.WriteLine("DEIXE A TELA GRANDE E APERTE ENTER");
            Console.ReadLine();

            TELA.DesenhoFundo();

            TELA.Loading(x, y);

            while (result != "6")
            {

            result= TELA.Menu(x,y);

            if (result == "1")
            {
                Console.Clear();
                Fase01 fase01 = new Fase01();
                fase01.Fase_01(pontos);
            }
            else
            if (result == "2")
            {
                Console.Clear();
                Fase02 fase02 = new Fase02();
                fase02.Fase_02(pontos);
            }
            else
            if (result == "3")
            {
                Console.Clear();
                Fase03 fase03 = new Fase03();
                fase03.Fase_03(pontos);
            }
            else
            if (result == "4")
            {
                Console.Clear();
                Fase04 fase04 = new Fase04();
                fase04.JogoDaVelha();
            }
            else
            if (result == "5")
            {
                Console.Clear();
                Fase05 fase05 = new Fase05();
                fase05.JogoDaVelhaUltra();

            }
            else
            if (result == "6")
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.Clear();
                Console.WriteLine("FIM");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("ERRO");
            }

            }

        }

    }
}
