using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JogoDaVelha.JogoDaVelha;

namespace JogoDaVelhaUltra.Fases
{
    class Fase05
    {

        public void JogoDaVelhaUltra()
        {
            Console.SetCursorPosition(70, 7); Console.WriteLine("    VAMOS TENTAR NOVAMENTE   ");
            Console.SetCursorPosition(70, 8); Console.WriteLine("   DUVIDO VOCÊ GANHAR AGORA  ");

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

                while (VezDaIA == false)
                {
                    VezDaIA = jogo.IAUltraJogar();
                }
                ganhador = jogo.FimDaRodada();


                while (VezDoUsuario == false)
                {
                    char tecla = Console.ReadKey(true).KeyChar;

                    if (tecla == 'X') VezDoUsuario = jogo.Jogar();

                    jogo.Movimentar(tecla);
                }
                ganhador = jogo.FimDaRodada();


            }






        }
    }
}

