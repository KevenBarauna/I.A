using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JogoDaVelha.JogoDaVelha
{
    class ModeloJogo//FASE 04
    {

        int espaco_1 = 0;
        int espaco_2 = 0;
        int espaco_3 = 0;

        int espaco_4 = 0;
        int espaco_5 = 0;
        int espaco_6 = 0;

        int espaco_7 = 0;
        int espaco_8 = 0;
        int espaco_9 = 0;

        int x = 83;
        int y = 24;


        public void Molde()
        {
            int x = 75;
            int y = 20;

            Console.SetCursorPosition(x, y + 0); Console.WriteLine("     |     |     ");
            Console.SetCursorPosition(x, y + 1); Console.WriteLine("     |     |     ");
            Console.SetCursorPosition(x, y + 2); Console.WriteLine("_____|_____|_____");
            Console.SetCursorPosition(x, y + 3); Console.WriteLine("     |     |     ");
            Console.SetCursorPosition(x, y + 4); Console.WriteLine("     |     |     ");
            Console.SetCursorPosition(x, y + 5); Console.WriteLine("_____|_____|_____");
            Console.SetCursorPosition(x, y + 6); Console.WriteLine("     |     |     ");
            Console.SetCursorPosition(x, y + 7); Console.WriteLine("     |     |     ");
            Console.SetCursorPosition(x, y + 8); Console.WriteLine("     |     |     ");
        }


        public void Movimentar(char tecla)
        {

            if (tecla == 'D' && x == 77)
            {
                x = 83;
                Console.Beep();
                Console.SetCursorPosition(x, y);
            }
            else
            if (tecla == 'D' && x == 83)
            {
                x = 89;
                Console.Beep();
                Console.SetCursorPosition(x, y);
            }
            else
            if (tecla == 'D' && x == 89)
            {
                x = 89;
                Console.Beep();
                Console.SetCursorPosition(x, y);
            }
            else


            if (tecla == 'S' && y == 21)
            {
                y = 24;
                Console.Beep();
                Console.SetCursorPosition(x, y);
            }
            else
            if (tecla == 'S' && y == 24)
            {
                y = 27;
                Console.Beep();
                Console.SetCursorPosition(x, y);
            }
            else
            if (tecla == 'S' && y == 27)
            {
                y = 27;
                Console.Beep();
                Console.SetCursorPosition(x, y);
            }
            else

            if (tecla == 'A' && x == 89)
            {
                x = 83;
                Console.Beep();
                Console.SetCursorPosition(x, y);
            }
            else
            if (tecla == 'A' && x == 83)
            {
                x = 77;
                Console.Beep();
                Console.SetCursorPosition(x, y);
            }
            else
            if (tecla == 'A' && x == 77)
            {
                x = 77;
                Console.Beep();
                Console.SetCursorPosition(x, y);
            }
            else

            if (tecla == 'W' && y == 27)
            {
                y = 24;
                Console.Beep();
                Console.SetCursorPosition(x, y);
            }
            else
            if (tecla == 'W' && y == 24)
            {
                y = 21;
                Console.Beep();
                Console.SetCursorPosition(x, y);
            }
            else
            if (tecla == 'W' && y == 21)
            {
                y = 21;
                Console.Beep();
                Console.SetCursorPosition(x, y);
            }

        }

        public bool Jogar()
        {
            bool VezDoUsuario = false;

            if (x == 77 && y == 21 && espaco_1 == 0)
            {
                Console.Beep();
                Console.WriteLine("x");
                Console.SetCursorPosition(x, y);
                espaco_1 = 1;
                VezDoUsuario = true;
            }
            else
            if (x == 83 && y == 21 && espaco_2 == 0)
            {

                Console.Beep();
                Console.WriteLine("x");
                Console.SetCursorPosition(x, y);
                espaco_2 = 1;
                VezDoUsuario = true;
            }
            else
            if (x == 89 && y == 21 && espaco_3 == 0)
            {

                Console.Beep();
                Console.WriteLine("x");
                Console.SetCursorPosition(x, y);
                espaco_3 = 1;
                VezDoUsuario = true;
            }
            else

            if (x == 77 && y == 24 && espaco_4 == 0)
            {

                Console.Beep();
                Console.WriteLine("x");
                Console.SetCursorPosition(x, y);
                espaco_4 = 1;
                VezDoUsuario = true;
            }
            else
            if (x == 83 && y == 24 && espaco_5 == 0)
            {

                Console.Beep();
                Console.WriteLine("x");
                Console.SetCursorPosition(x, y);
                espaco_5 = 1;
                VezDoUsuario = true;
            }
            else
            if (x == 89 && y == 24 && espaco_6 == 0)
            {

                Console.Beep();
                Console.WriteLine("x");
                Console.SetCursorPosition(x, y);
                espaco_6 = 1;
                VezDoUsuario = true;
            }
            else

            if (x == 77 && y == 27 && espaco_7 == 0)
            {

                Console.Beep();
                Console.WriteLine("x");
                Console.SetCursorPosition(x, y);
                espaco_7 = 1;
                VezDoUsuario = true;
            }
            else
            if (x == 83 && y == 27 && espaco_8 == 0)
            {

                Console.Beep();
                Console.WriteLine("x");
                Console.SetCursorPosition(x, y);
                espaco_8 = 1;
                VezDoUsuario = true;
            }
            else
            if (x == 89 && y == 27 && espaco_9 == 0)
            {

                Console.Beep();
                Console.WriteLine("x");
                Console.SetCursorPosition(x, y);
                espaco_9 = 1;
                VezDoUsuario = true;
            }

            return VezDoUsuario;

        }

        public bool IAJogar()
        {
            bool VezDaIA = false;


                Random rdn = new Random();
                int aleatorio;
                aleatorio = rdn.Next(1, 9);

                if (espaco_1 == 0 && aleatorio == 1)
                {
                    Console.SetCursorPosition(77, 21);
                    Console.Beep();
                    Console.WriteLine("O");
                    espaco_1 = 2;
                    VezDaIA = true;
                    Console.SetCursorPosition(83, 24);
                }
                else
                if (espaco_2 == 0 && aleatorio == 2)
                {
                    Console.SetCursorPosition(83, 21);
                    Console.Beep();
                    Console.WriteLine("O");
                    espaco_2 = 2;
                    VezDaIA = true;
                    Console.SetCursorPosition(83, 24);
                }
                else
                if (espaco_3 == 0 && aleatorio == 3)
                {
                    Console.SetCursorPosition(89, 21);
                    Console.Beep();
                    Console.WriteLine("O");
                    espaco_3 = 2;
                    VezDaIA = true;
                    Console.SetCursorPosition(83, 24);
                }
                else

                if (espaco_4 == 0 && aleatorio == 4)
                {
                    Console.SetCursorPosition(77, 24);
                    Console.Beep();
                    Console.WriteLine("O");
                    espaco_4 = 2;
                    VezDaIA = true;
                    Console.SetCursorPosition(83, 24);
                }
                else
                if (espaco_5 == 0 && aleatorio == 5)
                {
                    Console.SetCursorPosition(83, 24);
                    Console.Beep();
                    Console.WriteLine("O");
                    espaco_5 = 2;
                    VezDaIA = true;
                    Console.SetCursorPosition(83, 24);
                }
                else
                if (espaco_6 == 0 && aleatorio == 6)
                {
                    Console.SetCursorPosition(89, 24);
                    Console.Beep();
                    Console.WriteLine("O");
                    espaco_6 = 2;
                    VezDaIA = true;
                    Console.SetCursorPosition(83, 24);
                }
                else

                if (espaco_7 == 0 && aleatorio == 7)
                {
                    Console.SetCursorPosition(77, 27);
                    Console.Beep();
                    Console.WriteLine("O");
                    espaco_7 = 2;
                    VezDaIA = true;
                    Console.SetCursorPosition(83, 24);
                }
                else
                if (espaco_8 == 0 && aleatorio == 8)
                {
                    Console.SetCursorPosition(83, 27);
                    Console.Beep();
                    Console.WriteLine("O");
                    espaco_8 = 2;
                    VezDaIA = true;
                    Console.SetCursorPosition(83, 24);
                }
                else
                if (espaco_9 == 0 && aleatorio == 9)
                {
                    Console.SetCursorPosition(89, 27);
                    Console.Beep();
                    Console.WriteLine("O");
                    espaco_9 = 2;
                    VezDaIA = true;
                    Console.SetCursorPosition(83, 24);
                }

            return VezDaIA;

        }

        public bool FimDaRodada()
        {
            bool ganhador = false;
            //JOGADOR 1
            if (espaco_1 == 1 && espaco_2 == 1 && espaco_3 == 1)
            {
                Thread.Sleep(2000);
                Console.Clear();
                Console.SetCursorPosition(77, 23); Console.WriteLine("Você ganhou!");
                Console.ReadKey(false);
                ganhador = true;
            }

            if (espaco_4 == 1 && espaco_5 == 1 && espaco_6 == 1)
            {
                Thread.Sleep(2000);
                Console.Clear();
                Console.SetCursorPosition(77, 23); Console.WriteLine("Você ganhou!");
                Console.ReadKey(false);
                ganhador = true;
            }

            if (espaco_7 == 1 && espaco_8 == 1 && espaco_9 == 1)
            {
                Thread.Sleep(2000);
                Console.Clear();
                Console.SetCursorPosition(77, 23); Console.WriteLine("Você ganhou!");
                Console.ReadKey(false);
                ganhador = true;
            }

            if (espaco_1 == 1 && espaco_4 == 1 && espaco_7 == 1)
            {
                Console.Clear();
                Console.SetCursorPosition(77, 23); Console.WriteLine("Você ganhou!");
                Console.ReadKey(false);
                ganhador = true;
            }

            if (espaco_2 == 1 && espaco_5 == 1 && espaco_8 == 1)
            {
                Console.Clear();
                Console.SetCursorPosition(77, 23); Console.WriteLine("Você ganhou!");
                Console.ReadKey(false);
                ganhador = true;
            }

            if (espaco_3 == 1 && espaco_6 == 1 && espaco_9 == 1)
            {
                Console.Clear();
                Console.SetCursorPosition(77, 23); Console.WriteLine("Você ganhou!");
                Console.ReadKey(false);
                ganhador = true;
            }

            if (espaco_1 == 1 && espaco_5 == 1 && espaco_9 == 1)
            {
                Console.Clear();
                Console.SetCursorPosition(77, 23); Console.WriteLine("Você ganhou!");
                Console.ReadKey(false);
                ganhador = true;
            }

            if (espaco_3 == 1 && espaco_5 == 1 && espaco_7 == 1)
            {
                Console.Clear();
                Console.SetCursorPosition(77, 23); Console.WriteLine("Você ganhou!");
                Console.ReadKey(false);
                ganhador = true;
            }

            //JOGADOR 2
            if (espaco_1 == 2 && espaco_2 == 2 && espaco_3 == 2)
            {
                Console.Clear();
                Console.SetCursorPosition(77, 23); Console.WriteLine("A IA ganhou!");
                Console.ReadKey(false);
                ganhador = true;
            }

            if (espaco_4 == 2 && espaco_5 == 2 && espaco_6 == 2)
            {
                Console.Clear();
                Console.SetCursorPosition(77, 23); Console.WriteLine("A IA ganhou!");
                Console.ReadKey(false);
                ganhador = true;
            }

            if (espaco_7 == 2 && espaco_8 == 2 && espaco_9 == 2)
            {
                Console.Clear();
                Console.SetCursorPosition(77, 23); Console.WriteLine("A IA ganhou!");
                Console.ReadKey(false);
                ganhador = true;
            }

            if (espaco_1 == 2 && espaco_4 == 2 && espaco_7 == 2)
            {
                Console.Clear();
                Console.SetCursorPosition(77, 23); Console.WriteLine("A IA ganhou!");
                Console.ReadKey(false);
                ganhador = true;
            }

            if (espaco_2 == 2 && espaco_5 == 2 && espaco_8 == 2)
            {
                Console.Clear();
                Console.SetCursorPosition(77, 23); Console.WriteLine("A IA ganhou!");
                Console.ReadKey(false);
                ganhador = true;
            }

            if (espaco_3 == 2 && espaco_6 == 2 && espaco_9 == 2)
            {
                Console.Clear();
                Console.SetCursorPosition(77, 23); Console.WriteLine("A IA ganhou!");
                Console.ReadKey(false);
                ganhador = true;
            }

            if (espaco_1 == 2 && espaco_5 == 2 && espaco_9 == 2)
            {
                Console.Clear();
                Console.SetCursorPosition(77, 23); Console.WriteLine("A IA ganhou!");
                Console.ReadKey(false);
                ganhador = true;
            }

            if (espaco_3 == 2 && espaco_5 == 2 && espaco_7 == 2)
            {
                Console.Clear();
                Console.SetCursorPosition(77, 23); Console.WriteLine("A IA ganhou!");
                Console.ReadKey(false);
                ganhador = true;
            }
            else
            {
                //EMPATE
                if (espaco_1 != 0 && espaco_2 != 0 && espaco_3 != 0 && espaco_4 != 0 && espaco_5 != 0 && espaco_6 != 0 && espaco_7 != 0 && espaco_8 != 0 && espaco_9 != 0)
                {
                    Console.Clear();
                    Console.SetCursorPosition(77, 23); Console.WriteLine("FIM DA RODADA!");
                    Console.SetCursorPosition(77, 23); Console.WriteLine("NINGUÉM GANHO!");
                    Console.ReadKey(false);
                    ganhador = true;
                }
            }

            return ganhador;
        }

        public bool IAUltraJogar()
        {
            bool VezDaIA = false;

            //EMPATAR

            if (espaco_1 == 1 && espaco_3 == 1 && espaco_2 == 0)
            {
                Console.SetCursorPosition(83, 21);
                Console.Beep();
                Console.WriteLine("O");
                espaco_2 = 2;
                VezDaIA = true;
                Console.SetCursorPosition(83, 24);
            }
            else
            if (espaco_4 == 1 && espaco_6 == 1 && espaco_5 == 0)
            {
                Console.SetCursorPosition(83, 24);
                Console.Beep();
                Console.WriteLine("O");
                espaco_5 = 2;
                VezDaIA = true;
                Console.SetCursorPosition(83, 24);
            }
            else
            if (espaco_7 == 1 && espaco_9 == 1 && espaco_8 == 0)
            {
                Console.SetCursorPosition(83, 27);
                Console.Beep();
                Console.WriteLine("O");
                espaco_8 = 2;
                VezDaIA = true;
                Console.SetCursorPosition(83, 24);
            }
            else
            if (espaco_1 == 1 && espaco_9 == 1 && espaco_5 == 0)
            {
                Console.SetCursorPosition(83, 24);
                Console.Beep();
                Console.WriteLine("O");
                espaco_5 = 2;
                VezDaIA = true;
                Console.SetCursorPosition(83, 24);
            }
            else
            if (espaco_3 == 1 && espaco_7 == 1 && espaco_5 == 0)
            {
                Console.SetCursorPosition(83, 24);
                Console.Beep();
                Console.WriteLine("O");
                espaco_5 = 2;
                VezDaIA = true;
                Console.SetCursorPosition(83, 24);
            }
            else

            //MODO 01

            if (espaco_7 == 0)
            {
                Console.SetCursorPosition(77, 27);
                Console.Beep();
                Console.WriteLine("O");
                espaco_7 = 2;
                VezDaIA = true;
                Console.SetCursorPosition(83, 24);
            }
            else if (espaco_5 == 1 && espaco_3 == 0)
            {
                Console.SetCursorPosition(89, 21);
                Console.Beep();
                Console.WriteLine("O");
                espaco_3 = 2;
                VezDaIA = true;
                Console.SetCursorPosition(83, 24);
            }
            else if (espaco_1 == 2 && espaco_3 == 2 && espaco_2 == 0)
            {
                Console.SetCursorPosition(83, 21);
                Console.Beep();
                Console.WriteLine("O");
                espaco_2 = 2;
                VezDaIA = true;
                Console.SetCursorPosition(83, 24);
            }
            else if (espaco_1 == 2 && espaco_7 == 2 && espaco_4 == 0)
            {
                Console.SetCursorPosition(77, 24);
                Console.Beep();
                Console.WriteLine("O");
                espaco_4 = 2;
                VezDaIA = true;
                Console.SetCursorPosition(83, 24);
            }
            else if (espaco_7 == 2 && espaco_9 == 2 && espaco_8 ==0)
            {
                Console.SetCursorPosition(83, 27);
                Console.Beep();
                Console.WriteLine("O");
                espaco_8 = 2;
                VezDaIA = true;
                Console.SetCursorPosition(83, 24);
            }
            else if ((espaco_7 == 2 && espaco_5 == 1) && (espaco_1 == 1 || espaco_3 == 1 || espaco_9 == 1))
            {
                if (espaco_1 == 0)
                {
                    Console.SetCursorPosition(77, 21);
                    Console.Beep();
                    Console.WriteLine("O");
                    espaco_1 = 2;
                    VezDaIA = true;
                    Console.SetCursorPosition(83, 24);
                }
                else
                if (espaco_3 == 0)
                {
                    Console.SetCursorPosition(77, 21);
                    Console.Beep();
                    Console.WriteLine("O");
                    espaco_3 = 2;
                    VezDaIA = true;
                    Console.SetCursorPosition(83, 24);
                }
                else
                if (espaco_9 == 0)
                {
                    Console.SetCursorPosition(89, 27);
                    Console.Beep();
                    Console.WriteLine("O");
                    espaco_3 = 2;
                    VezDaIA = true;
                    Console.SetCursorPosition(83, 24);
                }
            }
            else

            //MODO 2

            if (espaco_7 == 0)
            {
                Console.SetCursorPosition(77, 27);
                Console.Beep();
                Console.WriteLine("O");
                espaco_7 = 2;
                VezDaIA = true;
                Console.SetCursorPosition(83, 24);
            }
            else
            if ((espaco_4 == 1  || espaco_1 == 1) && (espaco_6 == 0))
            {
                Console.SetCursorPosition(89, 24);
                Console.Beep();
                Console.WriteLine("O");
                espaco_6 = 2;
                VezDaIA = true;
                Console.SetCursorPosition(83, 24);
            }
            else
            if (espaco_3 == 0 && espaco_9 == 0 && espaco_8 == 0)
            {
                Console.SetCursorPosition(89, 27);
                Console.Beep();
                Console.WriteLine("O");
                espaco_9 = 2;
                VezDaIA = true;
                Console.SetCursorPosition(83, 24);
            }
            else
            if (espaco_3 == 0)
            {
                Console.SetCursorPosition(89, 21);
                Console.Beep();
                Console.WriteLine("O");
                espaco_3 = 2;
                VezDaIA = true;
                Console.SetCursorPosition(83, 24);
            }
            else
            if (espaco_8 == 0)
            {
                Console.SetCursorPosition(83, 27);
                Console.Beep();
                Console.WriteLine("O");
                espaco_8 = 2;
                VezDaIA = true;
                Console.SetCursorPosition(83, 24);
            }

            //ALEATORIO

            else
            {
                while (VezDaIA == false)
                {
                    VezDaIA = IAJogar();
                }
                
            }
            

                return VezDaIA;

        }



    }
}