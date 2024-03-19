using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//version release 0.1.5

namespace CSharpRPGBarbaro
{
    internal class Barbaro
    {
        // Atributos
        public string Nome = "Desconhecido";
        public int Vida = 34;
        public int Energia = 10;
        public int MaxVida = 34;
        public int MaxEnergia = 10;
        public int Nivel = 1;
        public int Vitalidade = 23;
        public int Forca = 25;
        public int Destreza = 15;
        public int Inteligencia = 7;

        public string[] NomesBarbaros = new string[] {
            "Grorok, o Destemido", "Hilda, a Fúria", "Thorgar, o Destruidor", "Ragnar, o Sanguinário", "Ulfrik, o Devorador",
            "Brunhilda, a Indomável", "Gromm, o Imortal", "Valka, a Tempestade", "Bjorn, o Brutal", "Freyja, a Selvagem",
            "Hrolf, o Desgarrador", "Sif, a Valente", "Varg, o Desperto", "Astrid, a Voraz", "Rurik, o Inquebrável",
            "Sigrun, a Feroz", "Gunnar, o Inflexível", "Thyra, a Implacável", "Thane, o Trovão", "Helga, a Intransigente",
            "Ingmar, o Incessante", "Brynhild, a Enfurecida", "Olaf, o Irredutível", "Freyr, o Inabalável",
            "Hilda, a Guerreira", "Balder, o Destruidor", "Sigrid, a Indômita", "Ulf, o Impiedoso", "Eirik, o Despiedado",
            "Astrid, a Destruidora", "Ragnar, o Colosso", "Sven, o Selvagem", "Brynhildr, a Berserker", "Gudrun, a Voragem",
            "Thorstein, o Inquebrável", "Ingrid, a Cruel", "Valgard, o Valente", "Ylva, a Valquíria", "Bjorn, o Sanguinolento",
            "Helga, a Arrasadora", "Rurik, o Implacável", "Sif, a Temerária", "Hrolf, o Inabalado", "Thyra, a Devastadora",
            "Gorm, o Gigante", "Asa, a Chicoteadora", "Ulfrik, o Devastador", "Hilde, a Esfomeada", "Vigdis, a Voraz",
            "Leif, o Intrépido", "Hrothgar, o Destruidor", "Astrid, a Tormenta", "Gunnar, o Sanguinário", "Bjorn, o Devastador",
            "Freya, a Furiosa", "Rurik, o Destemido", "Valgard, o Implacável", "Sven, o Terrível", "Helga, a Frenética",
            "Ingvar, o Indomado", "Hilda, a Espectral", "Gorm, o Monstruoso", "Erik, o Errante", "Grim, o Inflexível",
            "Birger, o Bárbaro", "Ulf, o Infame", "Olaf, o Cruel", "Einar, o Caçador", "Thora, a Voraz", "Astrid, a Destemida",
            "Ragnor, o Colossal", "Harald, o Violento", "Freyr, o Feroz", "Bjorn, o Imortal", "Halvard, o Destruidor",
            "Grimar, o Implacável", "Astrid, a Desoladora", "Viggo, o Voraz", "Hilda, a Mácula", "Leif, o Libertador",
            "Ragnar, o Desbravador", "Skadi, a Tempestade", "Olrik, o Voraz", "Gunnlod, a Devoradora", "Stig, o Poderoso",
            "Vidar, o Inquebrável", "Sigrun, a Desbravadora", "Varg, o Voraz", "Thorin, o Tornado", "Eirik, o Colosso",
            "Freja, a Destemida", "Hjalmar, o Incansável", "Gudrun, a Fúria", "Hrothgar, o Infame", "Ingrid, a Assombração",
            "Astrid, a Destruidora", "Ulfar, o Implacável", "Sigurd, o Sanguinolento", "Torvald, o Trovão", "Gunnar, o Inflexível"
        };

        // Métodos

        public int jogard20(bool bPlayerJogando, int iDificuldadeMult)
        {
            //Console.WriteLine($"**Debug** iDificuldadeMult == {iDificuldadeMult}"); // Debug
            //Console.WriteLine($"**Debug** bPlayerJogando == {bPlayerJogando}"); // Debug

            Console.WriteLine("Jogando D20...");
            Console.ReadLine();

            Random randomD20 = new Random();

            float fJogadaD20;
            int iJogadaD20;

            if (bPlayerJogando == true)
            {
                //Console.WriteLine("**Debug** Got bPlayerJogando == true"); // Debug
                if (iDificuldadeMult == 1)
                {
                    //Console.WriteLine("**Debug** Got (iDificuldadeMult == 1) == true"); // Debug

                    fJogadaD20 = (float)(Convert.ToSingle(randomD20.Next(1, 21)) * 1.25);
                    //Console.WriteLine($"**Debug** fJogadaD20 = {fJogadaD20}"); // Debug

                    iJogadaD20 = Convert.ToInt32(Math.Round(fJogadaD20));
                    //Console.WriteLine($"**Debug** iJogadaD20 = {iJogadaD20}"); // Debug
                }
                else if (iDificuldadeMult == 3)
                {
                    //Console.WriteLine("**Debug** Got (iDificuldadeMult == 3) == true"); // Debug

                    fJogadaD20 = (float)(Convert.ToSingle(randomD20.Next(1, 21)) * 0.75);
                    //Console.WriteLine($"**Debug** fJogadaD20 = {fJogadaD20}"); // Debug

                    iJogadaD20 = Convert.ToInt32(Math.Round(fJogadaD20));
                    //Console.WriteLine($"**Debug** iJogadaD20 = {iJogadaD20}"); // Debug
                }
                else
                {
                    //Console.WriteLine("**Debug** Got (iDificuldadeMult == 1) == false && (iDificuldadeMult == 3) == false"); // Debug

                    iJogadaD20 = randomD20.Next(1, 21);
                    //Console.WriteLine($"**Debug** iJogadaD20 = {iJogadaD20}"); // Debug
                }

            }
            else
            {
                //Console.WriteLine("**Debug** Got bPlayerJogando == false"); // Debug
                if (iDificuldadeMult == 1)
                {
                    //Console.WriteLine("**Debug** Got (iDificuldadeMult == 1) == true"); // Debug

                    fJogadaD20 = (float)(Convert.ToSingle(randomD20.Next(1, 21)) * 0.75);
                    //Console.WriteLine($"**Debug** fJogadaD20 = {fJogadaD20}"); // Debug

                    iJogadaD20 = Convert.ToInt32(Math.Round(fJogadaD20));
                    //Console.WriteLine($"**Debug** iJogadaD20 = {iJogadaD20}"); // Debug
                }
                else if (iDificuldadeMult == 3)
                {
                    //Console.WriteLine("**Debug** Got (iDificuldadeMult == 3) == true"); // Debug

                    fJogadaD20 = (float)(Convert.ToSingle(randomD20.Next(1, 21)) * 1.25);
                    //Console.WriteLine($"**Debug** fJogadaD20 = {fJogadaD20}"); // Debug

                    iJogadaD20 = Convert.ToInt32(Math.Round(fJogadaD20));
                    //Console.WriteLine($"**Debug** iJogadaD20 = {iJogadaD20}"); // Debug
                }
                else
                {
                    //Console.WriteLine("**Debug** Got (iDificuldadeMult == 1) == false && (iDificuldadeMult == 3) == false"); // Debug

                    iJogadaD20 = randomD20.Next(1, 21);
                    //Console.WriteLine($"**Debug** iJogadaD20 = {iJogadaD20}"); // Debug
                }
            }

            Console.WriteLine($"{Nome} jogou {iJogadaD20}.");
            Console.ReadLine();

            return iJogadaD20;
        }

        public int jogard2()
        {
            Console.WriteLine("Jogando D2...");
            Console.ReadLine();

            Random randomD2 = new Random();
            int iJogadaD2 = (randomD2.Next(0, 2));
            //Console.WriteLine($"**Debug** iJogadaD2 = {iJogadaD2}"); // Debug

            Console.WriteLine($"{Nome} jogou {iJogadaD2}.");
            Console.ReadLine();

            return iJogadaD2;
        }

        public void statuscombate()
        {
            Console.WriteLine($"{Nome}");
            Console.WriteLine($"Vida: {Vida}/{MaxVida}");
            Console.WriteLine($"Energia: {Energia}/{MaxEnergia}");
            Console.WriteLine();
        }

        public void status()
        {
            Console.WriteLine("**Atributos**");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Nível: {Nivel}");
            Console.WriteLine($"Vida: {Vida}/{MaxVida}");
            Console.WriteLine($"Energia: {Energia}/{MaxEnergia}");
            Console.WriteLine($"Vitalidade: {Vitalidade}");
            Console.WriteLine($"Força: {Forca}");
            Console.WriteLine($"Destreza: {Destreza}");
            Console.WriteLine($"Inteligência: {Inteligencia}");
        }

        public void upar()
        {
            Nivel++;
            Forca = Forca + 5;
            Vitalidade = Vitalidade + 3;
            Energia = Energia + 2; // Seria "MaxEnergia = Energia + 2;" ???
            Inteligencia = Inteligencia + 1;
            Destreza = Destreza + 2;
            MaxVida = Vitalidade * 3 / 2;
            // Talvez "Vida = MaxVida;" e "Energia = MaxEnergia;" ???
            Console.WriteLine($"{Nome} ascendeu para o nível {Nivel}.");
            Console.WriteLine($"Vida: {Vida}/{MaxVida}");
            Console.WriteLine($"Energia: {Energia}/{MaxEnergia}");
            Console.WriteLine($"Vitalidade: {Vitalidade}");
            Console.WriteLine($"Força: {Forca}");
            Console.WriteLine($"Destreza: {Destreza}");
            Console.WriteLine($"Inteligência: {Inteligencia}");
        }

        public void uparinimigo()
        {
            Forca = Forca + 5;
            Vitalidade = Vitalidade + 3;
            Energia = Energia + 2; // Seria "MaxEnergia = Energia + 2;" ???
            Inteligencia = Inteligencia + 1;
            Destreza = Destreza + 2;
            MaxVida = Vitalidade * 3 / 2;
            Vida = MaxVida;
            // "Energia = MaxEnergia;" ???
            //Console.WriteLine($"**Debug** {Nome} ascendeu para o nível {Nivel}.");
            //Console.WriteLine($"**Debug** Vida: {Vida}/{MaxVida}");
            //Console.WriteLine($"**Debug** Energia: {Energia}/{MaxEnergia}");
            //Console.WriteLine($"**Debug** Vitalidade: {Vitalidade}");
            //Console.WriteLine($"**Debug** Força: {Forca}");
            //Console.WriteLine($"**Debug** Destreza: {Destreza}");
            //Console.WriteLine($"**Debug** Inteligência: {Inteligencia}");
        }

        public void revigorar(int valor)
        {
            //Console.WriteLine($"**Debug** valor = {valor}"); // Debug

            Console.WriteLine();
            Console.WriteLine($"Vida: {Vida}/{MaxVida}");
            Console.WriteLine($"Energia: {Energia}/{MaxEnergia}");
            Console.WriteLine();

            int iVidaARevigorar = (valor * 2 * Vida) / 3;
            //Console.WriteLine($"**Debug** iVidaARevigorar = {iVidaARevigorar}"); // Debug

            if ((Vida + iVidaARevigorar) > MaxVida)
            {
                //Console.WriteLine($"**Debug** Got (Vida + iVidaARevigorar) > MaxVida) == true"); // Debug
                Vida = MaxVida;
                //Console.WriteLine($"**Debug** Vida = {Vida}"); // Debug
            }
            else
            {
                //Console.WriteLine($"**Debug** Got (Vida + iVidaARevigorar) > MaxVida) == false"); // Debug
                Vida = Vida + iVidaARevigorar;
                //Console.WriteLine($"**Debug** Vida = {Vida}"); // Debug
            }

            int iEnergiaARevigorar = (valor * 2 * Energia) / 3;
            //Console.WriteLine($"**Debug** iEnergiaARevigorar = {iEnergiaARevigorar}"); // Debug

            if ((Energia + iEnergiaARevigorar) > MaxEnergia)
            {
                //Console.WriteLine($"**Debug** Got ((Energia + iEnergiaARevigorar) > MaxEnergia) == true"); // Debug
                Energia = MaxEnergia;
                //Console.WriteLine($"**Debug** Energia = {Energia}"); // Debug
            }
            else
            {
                //Console.WriteLine($"**Debug** Got ((Energia + iEnergiaARevigorar) > MaxEnergia) == false"); // Debug
                Energia = Energia + iEnergiaARevigorar;
                //Console.WriteLine($"**Debug** Energia = {Energia}"); // Debug
            }

            Console.WriteLine($"{Nome} revigorado(a).");

            Console.WriteLine();
            Console.WriteLine($"Vida: {Vida}/{MaxVida}");
            Console.WriteLine($"Energia: {Energia}/{MaxEnergia}");
        }

        public void atacar(Barbaro BarbaroAlvo, int iDificuldadeMult, bool bPlayerJogando)
        {
            //Console.WriteLine($"**Debug** BarbaroAlvo = {BarbaroAlvo}"); // Debug
            //Console.WriteLine($"**Debug** iDificuldadeMult = {iDificuldadeMult}"); // Debug
            //Console.WriteLine($"**Debug** bPlayerJogando = {bPlayerJogando}"); // Debug

            int iJogadaD20 = jogard20(bPlayerJogando, iDificuldadeMult);

            //Console.WriteLine($"**Debug** iJogadaD20 = {iJogadaD20}"); // Debug

            float fRandomAttackMult = Convert.ToSingle(iJogadaD20) / 20;
            Console.WriteLine($"Multiplicador de ataque de {Nome} = {fRandomAttackMult}");

            if (fRandomAttackMult > 0)
            {
                //Console.WriteLine("**Debug** Got (fRandomAttackMult > 0) == true"); // Debug
                if (Energia >= 2)
                {
                    //Console.WriteLine("**Debug** Got (Energia >= 2) == true"); // Debug

                    float fAtaque = (Forca / 2 + Destreza / 3 + Inteligencia / 5) * fRandomAttackMult;
                    int iAtaque = Convert.ToInt32(fAtaque);
                    BarbaroAlvo.Vida = BarbaroAlvo.Vida - iAtaque;
                    Energia = Energia - 2;
                    Console.WriteLine($"{Nome} ataca {BarbaroAlvo.Nome}, causando {iAtaque} pts de dano.");
                }
                else
                {
                    //Console.WriteLine("**Debug** Got (Energia >= 2) == false"); // Debug

                    Console.WriteLine($"{Nome} tenta atacar {BarbaroAlvo.Nome}, mas não possui energia suficiente.");
                }
            }
            else
            {
                //Console.WriteLine("**Debug** Got (fRandomAttackMult > 0) == false"); // Debug

                Console.WriteLine($"{Nome} tenta atacar {BarbaroAlvo.Nome}, mas erra colossalmente.");
            }
        }

        public void gerarnome()
        {
            Random randomName = new Random();
            Nome = NomesBarbaros[randomName.Next(NomesBarbaros.Length)];
        } 
    }
}