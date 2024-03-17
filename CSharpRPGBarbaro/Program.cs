using System;
using static System.Net.Mime.MediaTypeNames;
//version release 0.1.3

namespace CSharpRPGBarbaro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            bool bValorValido = true;

            Console.WriteLine("Bem vindo ao jogo RPG de combate 1 vs 1!");
            Console.WriteLine("Versão Release 0.1.3");
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();

            string sMenuDificuldade;
            int iDificuldadeMult = 2;
            bool bGameOver = false;
            bool bAllowLevelUp = false;
            int iLimiteRevigorar = 2;

            do
            {
                Console.WriteLine("**Menu de Dificuldade**");
                Console.WriteLine("1 - Fácil");
                Console.WriteLine("2 - Normal");
                Console.WriteLine("3 - Difícil");
                Console.Write("Selecione o nível de dificuldade desejado: ");
                sMenuDificuldade = Console.ReadLine();
                //Console.WriteLine($"**Debug** sMenuDificuldade = {sMenuDificuldade}"); // Debug

                if (sMenuDificuldade == "1")
                {
                    //Console.WriteLine("**Debug** Got (sMenuDificuldade == 1) == true"); // Debug
                    Console.WriteLine("Dificuldade 'Fácil' selecionada.");

                    bValorValido = true;
                    //Console.WriteLine($"**Debug** bValorValido = {bValorValido}"); // Debug

                    iLimiteRevigorar = 3;
                    //Console.WriteLine($"**Debug** iLimiteRevigorar = {iLimiteRevigorar}"); // Debug

                    Console.WriteLine();
                }
                else if (sMenuDificuldade == "2")
                {
                    //Console.WriteLine("**Debug** Got (sMenuDificuldade == 2) == true"); // Debug
                    Console.WriteLine("Dificuldade 'Normal' selecionada.");

                    bValorValido = true;
                    //Console.WriteLine($"**Debug** bValorValido = {bValorValido}"); // Debug

                    iLimiteRevigorar = 2;
                    //Console.WriteLine($"**Debug** iLimiteRevigorar = {iLimiteRevigorar}"); // Debug

                    Console.WriteLine();
                }
                else if (sMenuDificuldade == "3")
                {
                    //Console.WriteLine("**Debug** Got (sMenuDificuldade == 3) == true"); // Debug
                    Console.WriteLine("Dificuldade 'Díficil' selecionada.");

                    bValorValido = true;
                    //Console.WriteLine($"**Debug** bValorValido = {bValorValido}"); // Debug

                    iLimiteRevigorar = 1;
                    //Console.WriteLine($"**Debug** iLimiteRevigorar = {iLimiteRevigorar}"); // Debug

                    Console.WriteLine();
                }
                else
                {
                    //Console.WriteLine("**Debug** Got (sMenuDificuldade == 1) == false && (sMenuDificuldade == 2) == false && (sMenuDificuldade == 3) == false"); // Debug
                    Console.WriteLine("Valor inválido, digite um número inteiro de 1 a 3.");

                    bValorValido = false;
                    //Console.WriteLine($"**Debug** bValorValido = {bValorValido}"); // Debug
                    Console.WriteLine();
                }
            } while (bValorValido != true);

            iDificuldadeMult = Convert.ToInt32(sMenuDificuldade);

            // Criação de personagens
            Barbaro Barbaro1 = new Barbaro();
            Console.WriteLine("Digite o nome do Bárbaro 1, ou deixe vazio para gerar nome aleatório:");
            Barbaro1.Nome = Console.ReadLine();
            //Console.WriteLine($"**Debug** Barbaro1.Nome = {Barbaro1.Nome}"); // Debug
            if (String.IsNullOrWhiteSpace(Barbaro1.Nome))
            {
                //Console.WriteLine("**Debug** Got (String.IsNullOrWhiteSpace(Barbaro1.Nome)) == true"); // Debug

                Console.WriteLine("Gerando nome aleatório...");
                Barbaro1.gerarnome();
            }
            Console.WriteLine($"Bárbaro {Barbaro1.Nome} criado.");
            Console.WriteLine();

            string sMenuPrincipal;

            do
            {
                // Mostrar o menu principal
                Console.WriteLine("**Menu Principal**");
                Console.WriteLine("1 - Combate");
                Console.WriteLine("2 - Status");
                Console.WriteLine("3 - Level Up");
                Console.WriteLine("4 - Revigorar");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");

                // Ler a opção do usuário
                sMenuPrincipal = Console.ReadLine();
                //Console.WriteLine($"**Debug** sMenuPrincipal = {sMenuPrincipal}"); // Debug

                Console.WriteLine();

                // Verificar a opção escolhida
                switch (sMenuPrincipal)
                {
                    case "1":
                        Console.WriteLine("Adentrando combate...");
                        Console.ReadLine();

                        // Gera oponente
                        Barbaro Barbaro2 = new Barbaro();
                        do
                        {
                            Barbaro2.gerarnome();
                        } while (Barbaro2.Nome == Barbaro1.Nome);

                        int iRandomNivelOponente = Barbaro1.jogard20(true, iDificuldadeMult);

                        //Console.WriteLine($"**Debug** iRandomNivelOponente = {iRandomNivelOponente}"); // Debug

                        int iNivelOponenteMod = 0;

                        if (iRandomNivelOponente == 20)
                        {
                            //Console.WriteLine("**Debug** Got (iRandomNivelOponente == 20) == true"); // Debug

                            iNivelOponenteMod = -2;
                            Console.WriteLine("Sucesso crítico! Nível do oponente +2.");
                        }
                        else if (iRandomNivelOponente < 20 && iRandomNivelOponente > 14)
                        {
                            //Console.WriteLine("**Debug** Got (iRandomNivelOponente < 20 && iRandomNivelOponente > 14) == true"); // Debug

                            iNivelOponenteMod = -1;
                            Console.WriteLine("Sucesso! Nível do oponente -1.");
                        }
                        else if (iRandomNivelOponente >= 6 && iRandomNivelOponente <= 14)
                        {
                            //Console.WriteLine("**Debug** Got (iRandomNivelOponente >= 6 && iRandomNivelOponente <= 14) == true"); // Debug

                            Console.WriteLine("Jogada neutra, nível do oponente +0.");
                            iNivelOponenteMod = 0;
                        }
                        else if (iRandomNivelOponente < 6 && iRandomNivelOponente > 0)
                        {
                            //Console.WriteLine("**Debug** Got (iRandomNivelOponente < 6 && iRandomNivelOponente > 0) == true"); // Debug

                            iNivelOponenteMod = +1;
                            Console.WriteLine("Fracasso! Nível do oponente +1.");
                        }
                        else if (iRandomNivelOponente == 0)
                        {
                            //Console.WriteLine("**Debug** Got (iRandomNivelOponente == 0) == true"); // Debug

                            iNivelOponenteMod = +2;
                            Console.WriteLine("Fracasso crítico! Nível do oponente +2.");
                        }

                        //Console.WriteLine($"**Debug** iNivelOponenteMod = {iNivelOponenteMod}"); // Debug
                        Barbaro2.Nivel = Barbaro1.Nivel + iNivelOponenteMod;

                        if (Barbaro2.Nivel < 1)
                        {
                            //Console.WriteLine("**Debug** Got (Barbaro2.Nivel < 1) == true"); // Debug
                            Barbaro2.Nivel = 1;
                            Console.WriteLine($"**Debug** Barbaro2.Nivel = {Barbaro2.Nivel}"); // Debug
                        }
                        else if (Barbaro2.Nivel > 1)
                        {
                            //Console.WriteLine("**Debug** Got (Barbaro2.Nivel > 1) == true"); // Debug
                            for (int i = 1; i < Barbaro2.Nivel; i++)
                            {
                                Barbaro2.uparinimigo();
                                Console.WriteLine($"**Debug** Barbaro2.Nivel = {Barbaro2.Nivel}"); // Debug
                            }
                        }
                        else
                        {
                            Console.WriteLine($"**Debug** Barbaro2.Nivel = {Barbaro2.Nivel}"); // Debug
                        }

                        Console.WriteLine();
                        Console.WriteLine($"{Barbaro1.Nome} se depara com {Barbaro2.Nome}, bárbaro nivel {Barbaro2.Nivel}.");
                        Console.ReadLine();

                        // Gera número aleatório para decidir quem vai primeiro, (iTurno == 0) = turno do player, (iTurno == 1) = turno do oponente
                        int iTurno = Barbaro1.jogard2();
                        //Console.WriteLine($"**Debug** iTurno = {iTurno}"); // Debug

                        bool bVitoria = false;
                        bool bDerrota = false;

                        // Primeiro turno
                        if (iTurno == 0)
                        {
                            //Console.WriteLine("**Debug** Got (iTurno == 0) == true"); // Debug

                            Console.WriteLine($"{Barbaro1.Nome} começa.");
                            Console.ReadLine();
                            Barbaro1.atacar(Barbaro2, iDificuldadeMult, true);

                            if (Barbaro2.Vida <= 0)
                            {
                                //Console.WriteLine("**Debug** Got (Barbaro2.Vida <= 0) == true"); // Debug

                                Console.WriteLine($"{Barbaro2.Nome} está morto(a).");
                                bVitoria = true;
                                //Console.WriteLine($"**Debug** bVitoria = {bVitoria}"); // Debug
                            }
                            else
                            {
                                //Console.WriteLine("**Debug** Got (Barbaro2.Vida <= 0) == false"); // Debug

                                iTurno = 1;
                                //Console.WriteLine($"**Debug** iTurno = {iTurno}"); // Debug
                            }
                        }
                        else
                        {
                            //Console.WriteLine("**Debug** Got (iTurno == 0) == false"); // Debug

                            Console.WriteLine($"{Barbaro2.Nome} começa.");
                            Console.ReadLine();

                            Barbaro2.atacar(Barbaro1, iDificuldadeMult, false);

                            if (Barbaro1.Vida <= 0)
                            {
                                //Console.WriteLine("**Debug** Got (Barbaro1.Vida <= 0) == true"); // Debug

                                Console.WriteLine($"{Barbaro1.Nome} está morto(a).");
                                bDerrota = true;
                                //Console.WriteLine($"**Debug** bDerrota = {bDerrota}"); // Debug
                                bGameOver = true;
                            }
                            else
                            {
                                //Console.WriteLine("**Debug** Got (Barbaro1.Vida <= 0) == false"); // Debug

                                iTurno = 0;
                                //Console.WriteLine($"**Debug** iTurno = {iTurno}"); // Debug
                            }
                        }

                        // Loop para demais turnos
                        while (!bVitoria && !bDerrota)
                        {
                            
                            if (iTurno == 0)
                            {
                                //Console.WriteLine("**Debug** Got (iTurno == 0) == true"); // Debug

                                Console.WriteLine($"Turno de {Barbaro1.Nome}.");
                                Console.ReadLine();

                                Console.WriteLine("Menu:");
                                Console.WriteLine("1 - Atacar");
                                Console.WriteLine("2 - Revigorar");
                                Console.WriteLine("3 - Status");
                                Console.Write("Escolha uma opção: ");

                                string sMenuCombate;
                                sMenuCombate = Console.ReadLine();

                                switch (sMenuCombate)
                                {
                                    case "1":

                                        Barbaro1.atacar(Barbaro2, iDificuldadeMult, true);

                                        if (Barbaro2.Vida <= 0)
                                        {
                                            //Console.WriteLine("**Debug** Got (Barbaro2.Vida <= 0) == true"); // Debug

                                            Console.WriteLine($"{Barbaro2.Nome} está morto(a).");
                                            bVitoria = true;
                                            //Console.WriteLine($"**Debug** bVitoria = {bVitoria}"); // Debug
                                        }
                                        else
                                        {
                                            //Console.WriteLine("**Debug** Got (Barbaro2.Vida <= 0) == false"); // Debug

                                            iTurno = 1;
                                            //Console.WriteLine($"**Debug** iTurno = {iTurno}"); // Debug
                                        }
                                        break;

                                    case "2":

                                        string sValorDigitadoRegivorar;
                                        int iValorDigitadoRevigorar;

                                        if (iLimiteRevigorar <= 0)
                                        {
                                            Console.WriteLine($"{Barbaro1.Nome} não possui poções.");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"{Barbaro1.Nome} possui {iLimiteRevigorar} poção(ões).");
                                            do
                                            {
                                                Console.WriteLine("Digite a quatidade de poções a usar, ou 0 para cancelar:");
                                                sValorDigitadoRegivorar = Console.ReadLine();

                                                // Checagem de valor digitado válido
                                                if (!int.TryParse(sValorDigitadoRegivorar, out iValorDigitadoRevigorar))
                                                {
                                                    //Console.WriteLine("**Debug** Got (!int.TryParse(sValorDigitadoRegivorar, out iValorDigitadoRevigorar)) == true"); // Debug

                                                    Console.WriteLine("Valor inválido, digite um número inteiro maior que 0, ou 0 para cancelar.");
                                                    Console.WriteLine();
                                                    bValorValido = false;
                                                    //Console.WriteLine($"**Debug** bValorValido = {bValorValido}"); // Debug
                                                }
                                                else if (iValorDigitadoRevigorar < 0)
                                                {
                                                    //Console.WriteLine("**Debug** Got (iValorDigitadoRevigorar < 0) == true"); // Debug

                                                    Console.WriteLine("Valor inválido, digite um número inteiro maior que 0, ou 0 para cancelar.");
                                                    Console.WriteLine();
                                                    bValorValido = false;
                                                    //Console.WriteLine($"**Debug** bValorValido = {bValorValido}"); // Debug
                                                }

                                                else if (iValorDigitadoRevigorar > iLimiteRevigorar)
                                                {
                                                    //Console.WriteLine("**Debug** Got (iValorDigitadoRevigorar > iLimiteRevigorar) == true"); // Debug

                                                    Console.WriteLine("Você não possui poções suficientes.");
                                                    Console.WriteLine();
                                                    bValorValido = false;
                                                    //Console.WriteLine($"**Debug** bValorValido = {bValorValido}"); // Debug
                                                }
                                                else if (iValorDigitadoRevigorar == 0)
                                                {
                                                    //Console.WriteLine("**Debug** Got (iValorDigitadoRevigorar == 0) == true"); // Debug

                                                    Console.WriteLine("Revigoração abortada.");
                                                    Console.WriteLine();
                                                    bValorValido = true;
                                                    //Console.WriteLine($"**Debug** bValorValido = {bValorValido}"); // Debug
                                                }
                                                else
                                                {
                                                    //Console.WriteLine("**Debug** Got (!int.TryParse(sValorDigitadoRegivorar, out iValorDigitadoRevigorar)) == false"); // Debug

                                                    bValorValido = true;
                                                    //Console.WriteLine($"**Debug** bValorValido = {bValorValido}"); // Debug
                                                }

                                            } while (bValorValido == false);

                                            iValorDigitadoRevigorar = Convert.ToInt32(sValorDigitadoRegivorar);
                                            //Console.WriteLine($"iValorDigitadoRevigorar = {iValorDigitadoRevigorar}"); // Debug

                                            if (iValorDigitadoRevigorar > 0)
                                            {
                                                //Console.WriteLine("**Debug** Got (iValorDigitadoRevigorar > 0) == true"); // Debug
                                                Barbaro1.revigorar(iValorDigitadoRevigorar);
                                                iLimiteRevigorar = iLimiteRevigorar - iValorDigitadoRevigorar;
                                                //Console.WriteLine($"**Debug** iLimiteRevigorar = {iLimiteRevigorar}"); // Debug
                                            }
                                        }
                                        iTurno = 1;
                                        //Console.WriteLine($"**Debug** iTurno = {iTurno}"); // Debug
                                        break;

                                    case "3":

                                        Barbaro1.status();

                                        iTurno = 0;
                                        //Console.WriteLine($"**Debug** iTurno = {iTurno}"); // Debug
                                        break;

                                    default:
                                        Console.WriteLine("Opção inválida. Por favor, escolha novamente.");
                                        break;
                                    
                                }
                            }
                            else
                            {
                                //Console.WriteLine("**Debug** Got (iTurno == 0) == false"); // Debug

                                Console.WriteLine($"Turno de {Barbaro2.Nome}");
                                Console.ReadLine();

                                Barbaro2.atacar(Barbaro1, iDificuldadeMult, false);

                                if (Barbaro1.Vida <= 0)
                                {
                                    //Console.WriteLine("**Debug** Got (Barbaro1.Vida <= 0) == true"); // Debug

                                    Console.WriteLine($"{Barbaro1.Nome} está morto(a).");
                                    bDerrota = true;
                                    //Console.WriteLine($"**Debug** bDerrota = {bDerrota}"); // Debug
                                    bGameOver = true;
                                }
                                else
                                {
                                    //Console.WriteLine("**Debug** Got (Barbaro1.Vida <= 0) == false"); // Debug

                                    iTurno = 0;
                                    //Console.WriteLine($"**Debug** iTurno = {iTurno}"); // Debug
                                }
                            }

                            if (bVitoria || bDerrota)
                            {
                                if (bVitoria)
                                {
                                    Console.WriteLine($"{Barbaro1.Nome} é vitorioso(a).");
                                    bAllowLevelUp = true;
                                    //Console.WriteLine($"**Debug** bAllowLevelUp == {bAllowLevelUp}"); // Debug
                                    Console.WriteLine($"{Barbaro1.Nome} agora pode subir de nível, acesse '3 - Level Up' no Menu Principal.");

                                    iLimiteRevigorar++;
                                    //Console.WriteLine($"**Debug** iLimiteRevigorar == {iLimiteRevigorar}"); // Debug
                                    Console.WriteLine($"{Barbaro1.Nome} adquiriu uma poção.");
                                }
                                else
                                {
                                    Console.WriteLine($"{Barbaro2.Nome} é vitorioso(a).");
                                }

                                if (bDerrota)
                                {
                                    Console.WriteLine($"{Barbaro1.Nome} foi derrotado(a).");
                                }
                                else
                                {
                                    Console.WriteLine($"{Barbaro2.Nome} foi derrotado(a).");
                                }

                                break; // Sai do loop se houver uma vitória ou derrota
                            }

                            Console.WriteLine();
                        };
                        break;

                    case "2":
                        Barbaro1.status();
                        break;

                    case "3":
                        if(bAllowLevelUp)
                        {
                            //Console.WriteLine("**Debug** Got (bAllowLevelUp) == true"); // Debug
                            Barbaro1.upar();
                            bAllowLevelUp = false;
                            //Console.WriteLine($"**Debug** bAllowLevelUp == {bAllowLevelUp}"); // Debug
                        }
                        else
                        {
                            //Console.WriteLine("**Debug** Got (bAllowLevelUp) == false"); // Debug
                            Console.WriteLine($"{Barbaro1.Nome} não pode subir de nível no momento, derrote inimigos para adquirir experiência (1 vitória = 1 nível).");
                        }

                        break;

                    case "4":

                        string sValorDigitadoRegivorarMenu;
                        int iValorDigitadoRevigorarMenu;

                        if (iLimiteRevigorar <= 0)
                        {
                            Console.WriteLine($"{Barbaro1.Nome} não possui poções.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{Barbaro1.Nome} possui {iLimiteRevigorar} poção(ões).");
                            do
                            {
                                Console.WriteLine("Digite a quatidade de poções a usar, ou 0 para cancelar:");
                                sValorDigitadoRegivorarMenu = Console.ReadLine();
                                //Console.WriteLine($"**Debug** sValorDigitadoRegivorarMenu = {sValorDigitadoRegivorarMenu}"); // Debug

                                // Checagem de valor digitado válido
                                if (!int.TryParse(sValorDigitadoRegivorarMenu, out iValorDigitadoRevigorarMenu))
                                {
                                    //Console.WriteLine("**Debug** Got (!int.TryParse(sValorDigitadoRegivorarMenu, out iValorDigitadoRevigorarMenu)) == true"); // Debug

                                    Console.WriteLine("Valor inválido, digite um número inteiro maior que 0, ou 0 para cancelar.");
                                    Console.WriteLine();
                                    bValorValido = false;
                                    //Console.WriteLine($"**Debug** bValorValido = {bValorValido}"); // Debug
                                }
                                else if (iValorDigitadoRevigorarMenu < 0)
                                {
                                    //Console.WriteLine("**Debug** Got (iValorDigitadoRevigorar < 0) == true"); // Debug

                                    Console.WriteLine("Valor inválido, digite um número inteiro maior que 0, ou 0 para cancelar.");
                                    Console.WriteLine();
                                    bValorValido = false;
                                    //Console.WriteLine($"**Debug** bValorValido = {bValorValido}"); // Debug
                                }
                                else if (iValorDigitadoRevigorarMenu > iLimiteRevigorar)
                                {
                                    //Console.WriteLine("**Debug** Got (iValorDigitadoRevigorarMenu > iLimiteRevigorar) == true"); // Debug

                                    Console.WriteLine("Você não possui poções suficientes.");
                                    Console.WriteLine();
                                    bValorValido = false;
                                    //Console.WriteLine($"**Debug** bValorValido = {bValorValido}"); // Debug
                                }
                                else if (iValorDigitadoRevigorarMenu == 0)
                                {
                                    //Console.WriteLine("**Debug** Got (iValorDigitadoRevigorarMenu == 0) == true"); // Debug

                                    Console.WriteLine("Revigoração abortada.");
                                    Console.WriteLine();
                                    bValorValido = true;
                                    //Console.WriteLine($"**Debug** bValorValido = {bValorValido}"); // Debug
                                }
                                else
                                {
                                    //Console.WriteLine("**Debug** Got (!int.TryParse(sValorDigitadoRegivorarMenu, out iValorDigitadoRevigorarMenu)) == false"); // Debug

                                    bValorValido = true;
                                    //Console.WriteLine($"**Debug** bValorValido = {bValorValido}"); // Debug
                                }

                            } while (bValorValido == false);

                            iValorDigitadoRevigorarMenu = Convert.ToInt32(sValorDigitadoRegivorarMenu);
                            //Console.WriteLine($"**Debug** iValorDigitadoRevigorarMenu = {iValorDigitadoRevigorarMenu}"); // Debug

                            if (iValorDigitadoRevigorarMenu > 0)
                            {
                                //Console.WriteLine("**Debug** Got (iValorDigitadoRevigorarMenu > 0) == true"); // Debug
                                Barbaro1.revigorar(iValorDigitadoRevigorarMenu);
                                iLimiteRevigorar = iLimiteRevigorar - iValorDigitadoRevigorarMenu;
                                //Console.WriteLine($"**Debug** iLimiteRevigorar = {iLimiteRevigorar}"); // Debug
                            } 
                        }
                        break;

                    case "5":
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha novamente.");
                        break;

                }

                if (bGameOver)
                {
                    Console.WriteLine("Game Over.");
                    Console.WriteLine("Pressione qualquer tecla para sair.");
                    Console.ReadLine();
                    break;
                    sMenuPrincipal = "5";
                }
                Console.WriteLine();
            } while (sMenuPrincipal != "5");

        }
    }
}
