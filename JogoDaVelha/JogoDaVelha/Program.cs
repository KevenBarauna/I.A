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

            Console.WriteLine("DEIXE A TELA GRANDE PFVR");
            Console.ReadLine();

            int x = 30;
            int y = 10;
            String result;
            int pontos = 0;

            Desenho TELA = new Desenho();

            TELA.DesenhoFundo();

            TELA.Loading(x,y);

            result= TELA.Menu(x,y);

            if (result == "1")
            {
                Console.WriteLine("Você digitou 1");
            }
            else
            if (result == "2")
            {
                Console.WriteLine("Você digitou 2");
            }
            else
            if (result == "3")
            {
                Console.WriteLine("Você digitou 3");
            }
            else
            if (result == "4")
            {
                Console.WriteLine("Você digitou 4");
            }
            else
            if (result == "5")
            {
                Fase01 fase01 = new Fase01();
                Fase02 fase02 = new Fase02();
                Fase03 fase03 = new Fase03();
                Fase04 fase04 = new Fase04();
                Fase05 fase05 = new Fase05();
                


                fase01.Fase_01(pontos);
                fase02.Fase_02(pontos);
                fase03.Fase_03(pontos);
                fase04.JogoDaVelha();
                fase05.JogoDaVelhaUltra();

            }
            else
            {
                Console.WriteLine("ERRO");
            }

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.Clear();
            Console.WriteLine("FIM");
            Console.ReadLine();

        }

    }
}
