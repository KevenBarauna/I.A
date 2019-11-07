using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Threading;

namespace JogoDaVelha
{
    public class Desenho
    {
        public void Loading(int x, int y)
        {

            Console.SetCursorPosition(x, y); Console.WriteLine(":######:::::'###::::'########::'########::'########::'######::::::'###::::'##::: ##:'########:::'#######::");
            Console.SetCursorPosition(x, y+1); Console.WriteLine("##... ##:::'## ##::: ##.... ##: ##.... ##: ##.....::'##... ##::::'## ##::: ###:: ##: ##.... ##:'##.... ##:");
            Console.SetCursorPosition(x, y+2); Console.WriteLine("##:::..:::'##:. ##:: ##:::: ##: ##:::: ##: ##::::::: ##:::..::::'##:. ##:: ####: ##: ##:::: ##: ##:::: ##:");
            Console.SetCursorPosition(x, y+3); Console.WriteLine("##:::::::'##:::. ##: ########:: ########:: ######::: ##::'####:'##:::. ##: ## ## ##: ##:::: ##: ##:::: ##:");
            Console.SetCursorPosition(x, y+4); Console.WriteLine("##::::::: #########: ##.. ##::: ##.. ##::: ##...:::: ##::: ##:: #########: ##. ####: ##:::: ##: ##:::: ##:");
            Console.SetCursorPosition(x, y+5); Console.WriteLine("##::: ##: ##.... ##: ##::. ##:: ##::. ##:: ##::::::: ##::: ##:: ##.... ##: ##:. ###: ##:::: ##: ##:::: ##:");
            Console.SetCursorPosition(x, y+6); Console.WriteLine(" ######:: ##:::: ##: ##:::. ##: ##:::. ##: ########:. ######::: ##:::: ##: ##::. ##: ########::. #######::");
            Console.SetCursorPosition(x, y+7); Console.WriteLine(":......:::..:::::..::..:::::..::..:::::..::........:::......::::..:::::..::..::::..::........::::.......:::");

            for (int i = 0; i < 8; i++)
            {
                Console.SetCursorPosition(x + 50, y + 11); Console.WriteLine("\\");
                Thread.Sleep(200);
                Console.SetCursorPosition(x + 50, y + 11); Console.WriteLine("|");
                Thread.Sleep(200);
                Console.SetCursorPosition(x + 50, y + 11); Console.WriteLine("/");
                Thread.Sleep(200);
            }
        }

        public String Menu(int x, int y)
        {
            String result =null;
            Console.Clear();
            Console.Beep();

            Console.SetCursorPosition(x + 40, y);   Console.WriteLine(":::::::::::           :::     ");
            Console.SetCursorPosition(x + 40, y+1); Console.WriteLine("    :+:             :+: :+:   ");
            Console.SetCursorPosition(x + 40, y+2); Console.WriteLine("    +:+            +:+   +:+  ");
            Console.SetCursorPosition(x + 40, y+3); Console.WriteLine("    +#+           +#++:++#++: ");
            Console.SetCursorPosition(x + 40, y+4); Console.WriteLine("    +#+           +#+     +#+ ");
            Console.SetCursorPosition(x + 40, y+5); Console.WriteLine("    #+#      #+#  #+#     #+# ");
            Console.SetCursorPosition(x + 40, y+6); Console.WriteLine("###########  ###  ###     ### ");

            Console.SetCursorPosition(x + 40, y + 9);  Console.WriteLine(" [1] - CRIAR NOVO USUÁRIO ");
            Console.SetCursorPosition(x + 40, y + 10); Console.WriteLine(" [2] - EXIBIR PERFIL  ");
            Console.SetCursorPosition(x + 40, y + 11); Console.WriteLine(" [3] - ENTRAR ");
            Console.SetCursorPosition(x + 40, y + 12); Console.WriteLine(" [4] - SOBRE ");
            Console.SetCursorPosition(x + 40, y + 13); Console.WriteLine(" [6] - SAIR ");
            Console.SetCursorPosition(x + 40, y + 14); Console.WriteLine("\n");
            Console.SetCursorPosition(x + 40, y + 15); Console.WriteLine("[   ]");

            Console.SetCursorPosition(x + 42, y + 15); result=Console.ReadLine();

            return result;
        }

        public void DesenhoFundo()
        {
            Console.Clear();
            for (int i = 0; i < 14; i++)//14
            {

            Console.WriteLine("Ngakhale ambiri aife timagwirizanitsa mawu oti owerenga ndi wachifwamba, uku sikukutanthauza koyenera. Aliyense amene amagwira ntchito molimbika pamalo albhfgdhvgv");
            Console.WriteLine("ionse opanga makompyuta ndi kupeza zinthu zopitilira zomwe anali atangoganiza angayesedwe kuti ndi wobera.fh wfh foishhfh efhf hfeihf lfjdoj fioeu fjnnghnpamalo vl");
            Console.WriteLine("fhdohfjdjv  jgi ghggh hgihg jgig   hg hggj~g ihhghoih f wifh wfh foishhfh efhf hfeihf alfjdoj fioe:::: ohf f uifh sf sfighv ~hehviugg hhfhwge; çhvehge ughnnh:Njira");
            Console.WriteLine("Wina amakhala wobera mwa kupeza china chake chapadera pamakina aliwonse omwe kale samawoneka kuti ndi otheka - sikuti kuphwanya chitetezo. Njira yatsopanorsoplmano");
            Console.WriteLine("f,kj.nmum jgi ghggh hgihg jgig hg hggj~g ihhghoih f wifh wfh foishhfh e        alfjdoj fioeu fj sohf f uifh sf sfighv ~hehviugg; çhvehg enf75yt4g.hf ugmhngnjgjuh::");
            Console.WriteLine("Ngakhale ambiri aife timagwirizanitsa mawu oti owerenga ndi wachifwamba, uku sikukutanthauza koyenera. Aliyense amene amagwira ntchito molimbika pamaljvhfguukuo al");
            Console.WriteLine("ionse opanga makompyuta ndi kupeza zinthu zopitilira zomwe anali atangoganiza angayesedwe kuti ndi wobera.fh wfh foishhfh efhf hfeihf lfjdoj fioeu fjnnbfjuiççç´ghn");
            Console.WriteLine("fhdohfjdjv  jgi ghggh hgihg jgig   hg hggj~g ihhghoih f wifh wfh foishhfh efhf hfeihf alfjdoj fioe:::: ohf f uifh sf sfighv ~hehviugg hhfhwge; çhvehge ug:687980446");
            Console.WriteLine("Wina amakhala wobera mwa kupeza china chake chapadera pamakina aliwonse omwe kale samawoneka kuti ndi otheka - sikuti kuphwanya chitetezo. Njira yatsopanoryj 7i764");
            Console.WriteLine(" ihhghoih f wifh wfh foishhfh efhf hfeihf alfjdoj fioeu fj sohf f uifh sf sfighv ~hehviugg hhfhwge; çhvebfb:::: g uvs ifhdohfjdjv  jgi ghggh hgihg jgig   hfh3830´2");
            Console.WriteLine("fhdohfjdjv  jgi ghggh hgihg jgig   hg hggj~g ihhghoih f wifh wfh foishhfh efhf hfeihf alfjdoj fioe:::: ohf f uifh sf sfighv ~hehviugg hhfhwge; çhvehg e ugymuymumuk");
            Console.WriteLine("Ngakhale ambiri aife timagwirizanitsa mawu oti owerenga ndi wachifwamba, uku sikukutanthauza koyenera. Aliyense amene amagwira ntchito molimbika pamalo alohbbh  u ");
            Console.WriteLine("ionse opanga makompyuta ndi kupeza zinthu zopitilira zomwe anali atangoganiza angayesedwe kuti ndi wobera.fh wfh foishhfh efhf hfeihf lfjdoj fioeu fjnnghnkkjgr ggr");
            Console.WriteLine("fhdohfjdjv  jgi ghggh hgihg jgig   hg hggj~g ihhghoih f wifh wfh foishhfh efhf hfeihf alfjdoj fioe:::: ohf f uifh sf sfighv ~hehviugg hhfhwge; çhvehge ug:jr joe pf");
            Console.WriteLine("Wina amakhala wobera mwa kupeza china chake chapadera pamakina aliwonse omwe kale samawoneka kuti ndi otheka - sikuti kuphwanya chitetezo. Njira yatsopanogit c eok");
            Console.WriteLine("f,kj.nmum jgi ghggh hgihg jgig hg hggj~g ihhghoih f wifh wfh foishhfh e        alfjdoj fioeu fj sohf f uifh sf sfighv ~hehviugg; çhvehg enf75yt4g.hf ugh::hvrv vkkc");
            Console.WriteLine("Ngakhale ambiri aife timagwirizanitsa mawu oti owerenga ndi wachifwamba, uku sikukutanthauza koyenera. Aliyense amene amagwira ntchito molimbika pamalo al cnes scn");
            Console.WriteLine("hbnse opanga makompyuta ndi kupeza zinthu zopitilira zomwe anali atangoganiza angayesedwe kuti ndi wobera.fh wfh foishhfh efhf hfeihf lfjdoj fioeu fjnnghn jsd vpds");
            Console.WriteLine("fhbfdb jvfvfvfv.vfdohfjdjv  jgi ghggh hgihg jgig   hg hggj~g ihhghoih f wifh wfh foishhfh efhf hfeihf alfjdoj fioe:::: ohf f uifh sf sfighv ~hehviugg hhfhwhehgeug:");
            Console.WriteLine("hti dpe,f pkkoe Wina amakhala wobera mwa kupeza china chake chapadera pamakina aliwonse omwe kale samawoneka kuti ndi otheka - sikuti kuphwanya chitetezo.Njtsopano");
            Console.WriteLine(" ihhghoih f joc,ep gkr vkor wifh wfh foishhfh efhf hfeihf alfjdoj fioeu fj sohf f uifh sf sfighv ~hehviugg hhfhwge; çhvebfb:::: g uvs ifhdohfjdjv  jgi ghggh jgig  ");
            Console.WriteLine("Ai fje hu go jucfhdohfjdjv  jgi ghggh hgihg jgig   hg hggj~g ihhghoih f wifh wfh foishhfh efhf hfeihf alfjdoj fioe:::: ohf f uifh sf sfighv ~hehviugg hhfhwgehg eug");
            Console.WriteLine("Ngakhale ambiri aife timagwirizanitsa mawu oti owerenga ndi wachifwamba, uku sikukutanthauza koyenera. Aliyense amene amagwira ntchito molimbika pamalo al");
            Console.WriteLine("ionse opanga makompyuta ndi kupeza zinthu zopitilira zomwe anali atangoganiza angayesedwe kuti ndi wobera.fh wfh foishhfh efhf hfeihf lfjdoj fioeu fjnnghn");
            Console.WriteLine("fhdohfjdjv  jgi ghggh hgihg jgig   hg hggj~g ihhghoih f wifh wfh foishhfh efhf hfeihf alfjdoj fioe:::: ohf f uifh sf sfighv ~hehviugg hhfhwge; çhvehge ug:");
            Console.WriteLine("Wina amakhala wobera mwa kupeza china chake chapadera pamakina aliwonse omwe kale samawoneka kuti ndi otheka - sikuti kuphwanya chitetezo. Njira yatsopano");
            Console.WriteLine("f,kj.nmum jgi ghggh hgihg jgig hg hggj~g ihhghoih f wifh wfh foishhfh e        alfjdoj fioeu fj sohf f uifh sf sfighv ~hehviugg; çhvehg enf75yt4g.hf ugh::");
            Console.WriteLine("Ngakhale ambiri aife timagwirizanitsa mawu oti owerenga ndi wachifwamba, uku sikukutanthauza koyenera. Aliyense amene amagwira ntchito molimbika pamalo al");
            Console.WriteLine("ionse opanga makompyuta ndi kupeza zinthu zopitilira zomwe anali atangoganiza angayesedwe kuti ndi wobera.fh wfh foishhfh efhf hfeihf lfjdoj fioeu fjnnghn");
            Console.WriteLine("fhdohfjdjv  jgi ghggh hgihg jgig   hg hggj~g ihhghoih f wifh wfh foishhfh efhf hfeihf alfjdoj fioe:::: ohf f uifh sf sfighv ~hehviugg hhfhwge; çhvehge ug:");
            Console.WriteLine("Ngakhale ambiri aife timagwirizanitsa mawu oti owerenga ndi wachifwamba, uku sikukutanthauza koyenera. Aliyense amene amagwira ntchito molimbika pamalo albhfgdhvgv");
            Console.WriteLine("ionse opanga makompyuta ndi kupeza zinthu zopitilira zomwe anali atangoganiza angayesedwe kuti ndi wobera.fh wfh foishhfh efhf hfeihf lfjdoj fioeu fjnnghnpamalo vl");
            Console.WriteLine("fhdohfjdjv  jgi ghggh hgihg jgig   hg hggj~g ihhghoih f wifh wfh foishhfh efhf hfeihf alfjdoj fioe:::: ohf f uifh sf sfighv ~hehviugg hhfhwge; çhvehge ughnnh:Njira");
            Console.WriteLine("Wina amakhala wobera mwa kupeza china chake chapadera pamakina aliwonse omwe kale samawoneka kuti ndi otheka - sikuti kuphwanya chitetezo. Njira yatsopanorsoplmano");
            Console.WriteLine("f,kj.nmum jgi ghggh hgihg jgig hg hggj~g ihhghoih f wifh wfh foishhfh e        alfjdoj fioeu fj sohf f uifh sf sfighv ~hehviugg; çhvehg enf75yt4g.hf ugmhngnjgjuh::");
            Console.WriteLine("Ngakhale ambiri aife timagwirizanitsa mawu oti owerenga ndi wachifwamba, uku sikukutanthauza koyenera. Aliyense amene amagwira ntchito molimbika pamaljvhfguukuo al");
            Console.WriteLine("ionse opanga makompyuta ndi kupeza zinthu zopitilira zomwe anali atangoganiza angayesedwe kuti ndi wobera.fh wfh foishhfh efhf hfeihf lfjdoj fioeu fjnnbfjuiççç´ghn");
            Console.WriteLine("fhdohfjdjv  jgi ghggh hgihg jgig   hg hggj~g ihhghoih f wifh wfh foishhfh efhf hfeihf alfjdoj fioe:::: ohf f uifh sf sfighv ~hehviugg hhfhwge; çhvehge ug:687980446");
            Console.WriteLine("Wina amakhala wobera mwa kupeza china chake chapadera pamakina aliwonse omwe kale samawoneka kuti ndi otheka - sikuti kuphwanya chitetezo. Njira yatsopanoryj 7i764");
            Console.WriteLine(" ihhghoih f wifh wfh foishhfh efhf hfeihf alfjdoj fioeu fj sohf f uifh sf sfighv ~hehviugg hhfhwge; çhvebfb:::: g uvs ifhdohfjdjv  jgi ghggh hgihg jgig   hfh3830´2");
            Console.WriteLine("fhdohfjdjv  jgi ghggh hgihg jgig   hg hggj~g ihhghoih f wifh wfh foishhfh efhf hfeihf alfjdoj fioe:::: ohf f uifh sf sfighv ~hehviugg hhfhwge; çhvehg e ugymuymumuk");
            Console.WriteLine("Ngakhale ambiri aife timagwirizanitsa mawu oti owerenga ndi wachifwamba, uku sikukutanthauza koyenera. Aliyense amene amagwira ntchito molimbika pamalo alohbbh  u ");
            Console.WriteLine("ionse opanga makompyuta ndi kupeza zinthu zopitilira zomwe anali atangoganiza angayesedwe kuti ndi wobera.fh wfh foishhfh efhf hfeihf lfjdoj fioeu fjnnghnkkjgr ggr");
            Console.WriteLine("fhdohfjdjv  jgi ghggh hgihg jgig   hg hggj~g ihhghoih f wifh wfh foishhfh efhf hfeihf alfjdoj fioe:::: ohf f uifh sf sfighv ~hehviugg hhfhwge; çhvehge ug:jr joe pf");
            Console.WriteLine("Wina amakhala wobera mwa kupeza china chake chapadera pamakina aliwonse omwe kale samawoneka kuti ndi otheka - sikuti kuphwanya chitetezo. Njira yatsopanogit c eok");
            Console.WriteLine("f,kj.nmum jgi ghggh hgihg jgig hg hggj~g ihhghoih f wifh wfh foishhfh e        alfjdoj fioeu fj sohf f uifh sf sfighv ~hehviugg; çhvehg enf75yt4g.hf ugh::hvrv vkkc");
            Console.WriteLine("Ngakhale ambiri aife timagwirizanitsa mawu oti owerenga ndi wachifwamba, uku sikukutanthauza koyenera. Aliyense amene amagwira ntchito molimbika pamalo al cnes scn");
            Console.WriteLine("hbnse opanga makompyuta ndi kupeza zinthu zopitilira zomwe anali atangoganiza angayesedwe kuti ndi wobera.fh wfh foishhfh efhf hfeihf lfjdoj fioeu fjnnghn jsd vpds");
            Console.WriteLine("fhbfdb jvfvfvfv.vfdohfjdjv  jgi ghggh hgihg jgig   hg hggj~g ihhghoih f wifh wfh foishhfh efhf hfeihf alfjdoj fioe:::: ohf f uifh sf sfighv ~hehviugg hhfhwhehgeug:");
            Console.WriteLine("hti dpe,f pkkoe Wina amakhala wobera mwa kupeza china chake chapadera pamakina aliwonse omwe kale samawoneka kuti ndi otheka - sikuti kuphwanya chitetezo.Njtsopano");
            Console.WriteLine(" ihhghoih f joc,ep gkr vkor wifh wfh foishhfh efhf hfeihf alfjdoj fioeu fj sohf f uifh sf sfighv ~hehviugg hhfhwge; çhvebfb:::: g uvs ifhdohfjdjv  jgi ghggh jgig  ");
            Console.WriteLine("Ai fje hu go jucfhdohfjdjv  jgi ghggh hgihg jgig   hg hggj~g ihhghoih f wifh wfh foishhfh efhf hfeihf alfjdoj fioe:::: ohf f uifh sf sfighv ~hehviugg hhfhwgehg eug");
            Console.WriteLine("f,kj.nmum jgi ghggh hgihg jgig hg hggj~g ihhghoih f wifh wfh foishhfh e        alfjdoj fioeu fj sohf f uifh sf sfighv ~hehviugg; çhvehg enf75yt4g.hf ugh::");
            Console.WriteLine("Ngakhale ambiri aife timagwirizanitsa mawu oti owerenga ndi wachifwamba, uku sikukutanthauza koyenera. Aliyense amene amagwira ntchito molimbika pamalo al");

            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Clear();


        }

        public void Parabens()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            int x = 60;
            int y = 20;

            Console.SetCursorPosition(x, y + 1); Console.WriteLine(" _____                _       __           _ ");
            Console.SetCursorPosition(x, y + 2); Console.WriteLine("|  __ \\              | |     /_/          | |");
            Console.SetCursorPosition(x, y + 3); Console.WriteLine("| |__) |_ _ _ __ __ _| |__   ___ _ __  ___| |");
            Console.SetCursorPosition(x, y + 4); Console.WriteLine("|  ___/ _` | '__/ _` | '_ \\ / _ \\ '_ \\/ __| |");
            Console.SetCursorPosition(x, y + 5); Console.WriteLine("| |  | (_| | | | (_| | |_) |  __/ | | \\__ \\_|");
            Console.SetCursorPosition(x, y + 6); Console.WriteLine("| _|   \\__,_|_|  \\__,_|_.__/ \\___|_| |_|___(_)");

            Thread.Sleep(999);
            Console.Clear();
        }

        public void Errou()
        {
            Console.ForegroundColor = ConsoleColor.Red;

                int x = 70;
                int y = 20;

                Console.SetCursorPosition(x, y + 1); Console.WriteLine(@"  ______                      _");
                Console.SetCursorPosition(x, y + 2); Console.WriteLine(@" |  ____|                    | |");
                Console.SetCursorPosition(x, y + 3); Console.WriteLine(@" | |__   _ __ _ __ ___  _   _| |");
                Console.SetCursorPosition(x, y + 4); Console.WriteLine(@" |  __| | '__| '__/ _ \| | | | |");
                Console.SetCursorPosition(x, y + 5); Console.WriteLine(@" | |____| |  | | | (_) | |_| |_|");
                Console.SetCursorPosition(x, y + 6); Console.WriteLine(@" |______|_|  |_|  \___/ \__,_(_)");


            
                Thread.Sleep(999);
                Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
        }

        public void JogoDaVelha()
        {
            int x=75;
            int y= 20;

            Console.SetCursorPosition(x, y+0); Console.WriteLine("     |     |     ");
            Console.SetCursorPosition(x, y+1); Console.WriteLine("     |     |     ");
            Console.SetCursorPosition(x, y+2); Console.WriteLine("_____|_____|_____");
            Console.SetCursorPosition(x, y+3); Console.WriteLine("     |     |     ");
            Console.SetCursorPosition(x, y+4); Console.WriteLine("     |     |     ");
            Console.SetCursorPosition(x, y+5); Console.WriteLine("_____|_____|_____");
            Console.SetCursorPosition(x, y+6); Console.WriteLine("     |     |     ");
            Console.SetCursorPosition(x, y+7); Console.WriteLine("     |     |     ");
            Console.SetCursorPosition(x, y+8); Console.WriteLine("     |     |     ");
        }

    }
}
