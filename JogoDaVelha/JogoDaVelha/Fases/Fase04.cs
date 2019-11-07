using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JogoDaVelha.JogoDaVelha;

namespace JogoDaVelha.Fases
{
    class Fase04
    {

        public void JogoDaVelha()
        {
            Console.SetCursorPosition(70, 7); Console.WriteLine("AGORA VAMOS JOGAR UM POUCO...");
            Console.SetCursorPosition(70, 8); Console.WriteLine("  UM JOGO DA VELHA SIMPLES   ");
            Console.SetCursorPosition(70, 9); Console.WriteLine("     PROMETO PEGAR LEVE      ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(30, 44); Console.WriteLine(" PARA SE MOVIMENTAR USE AS TECLAS: [W] , [A] , [S] , [D] | PARA JOGAR, MOVA PARA A POSIÇÃO DESEJADA E APERTE [X]");
            Console.SetCursorPosition(30, 46); Console.WriteLine("                               * LEMBRE DE ATIVAR O CAPS LOCK ANTES DE COMEÇAR A JOGAR                          ");
            Console.ForegroundColor = ConsoleColor.Green;



            ModeloJogo jogo = new ModeloJogo();

            jogo.Molde();

            Console.SetCursorPosition(83, 24);

            bool ganhador = false;


            while (ganhador == false)
            {

                bool VezDaIA = false;
                bool VezDoUsuario = false;
                while (VezDoUsuario == false )
                {
                    char tecla = Console.ReadKey(true).KeyChar;

                    if (tecla == 'X') VezDoUsuario = jogo.Jogar();

                     jogo.Movimentar(tecla);
                }
                ganhador = jogo.FimDaRodada();
                while (VezDaIA == false)
                {
                    VezDaIA = jogo.IAJogar();
                }
                ganhador = jogo.FimDaRodada();

            }






        }
    }
}

