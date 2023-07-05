using System;
using System.Diagnostics.Metrics;
using PokemonSegundoTeste;

namespace PokemonSegundoTeste
{
    internal class Movimento
    {
        DadosPokemons pokemon = new DadosPokemons();
        Inimigo inimigo = new Inimigo();

        public double Dano = 0.0;

        public double Tackle()//tipo normal
        {
            Random rand = new Random();

            int numero = rand.Next(1, 10 + 1);

            if (pokemon.Velocidade < inimigo.Velocidade)
            {
                if (numero <= 8)
                {
                    Dano = 35 - (inimigo.Defesa / 10);
                    Dano += pokemon.Forca / 100;
                    Math.Floor(Dano);
                }
                else
                {
                    Dano = 0;
                }
            }
            else
            {
                if (numero <= 9)
                {
                    Dano = 35 - (inimigo.Defesa / 10);
                    Dano += pokemon.Forca / 100;
                    Math.Floor(Dano);
                }
                else
                {
                    Dano = 0;
                }
            }
            return Dano;
        }

        public double TackleInimigo()//tipo normal
        {
            Random rand = new Random();

            int numero = rand.Next(1, 10 + 1);

            if (inimigo.Velocidade < pokemon.Velocidade)
            {
                if (numero <= 8)
                {
                    Dano = 20 - (pokemon.Defesa / 10);
                    Dano += inimigo.Forca / 100;
                    Math.Floor(Dano);
                }
                else
                {
                    Dano = 0;
                }
            }
            else
            {
                if (numero <= 9)
                {
                    Dano = 20 - (pokemon.Defesa / 10);
                    Dano += inimigo.Forca / 100;
                    Math.Floor(Dano);
                }
                else
                {
                    Dano = 0;
                }
            }
            return Dano;
        }

        public double VineWhipe()//tipo grama
        {
            Random rand = new Random();

            int numero = rand.Next(1, 10 + 1);

            if (pokemon.Velocidade < inimigo.Velocidade)
            {
                if (numero <= 9)
                {

                    Dano = 45 - inimigo.Defesa / 10;
                    Dano += pokemon.Forca / 100;
                    Math.Floor(Dano);

                }
                else
                {
                    Dano = 0;
                }
            }
            else
            {

                Dano = 45 - inimigo.Defesa / 10;
                Dano += pokemon.Forca / 100;
                Math.Floor(Dano);

            }

            if (inimigo.Tipo == "agua" && inimigo.Tipo == "terra" && inimigo.Tipo == "pedra")
            {
                Dano += 2;
            }
            else if (inimigo.Tipo == "fogo" && inimigo.Tipo == "voador" && inimigo.Tipo == "inseto" && inimigo.Tipo == "veneno" && inimigo.Tipo == "gelo")
            {
                Dano /= 2;
            }

            return Dano;
        }

        public double Scratch()//tipo normal
        {

            Random rand = new Random();

            int numero = rand.Next(1, 10 + 1);

            if (pokemon.Velocidade < inimigo.Velocidade)
            {
                if (numero <= 9)
                {

                    Dano = 40 - inimigo.Defesa / 10;
                    Dano += pokemon.Forca / 100;
                    Math.Floor(Dano);

                    Console.WriteLine("Seu pokeom acertou o movimento");
                }
                else
                {
                    Console.WriteLine("Seu pokemom errou o movimento");
                    Dano = 0;
                }
            }
            else
            {

                Dano = 40 - inimigo.Defesa / 10;
                Dano += pokemon.Forca / 100;
                Math.Floor(Dano);

                Console.WriteLine("Seu pokeom acertou o movimento");
            }

            return Dano;
        }

        public double Ember()//tipo fogo
        {
            Random rand = new Random();

            int numero = rand.Next(1, 10 + 1);

            if (pokemon.Velocidade < inimigo.Velocidade)
            {

                if (numero <= 9)
                {

                    Dano = 40 - inimigo.Defesa / 10;
                    Dano += pokemon.Forca / 100;
                    Math.Floor(Dano);

                    Console.WriteLine("Seu pokeom acertou o movimento");

                    if (numero <= 3)
                    {
                        Console.WriteLine("O inimigo sofreu dano de fogo, causou mais 5 de dano.");
                        Dano += 5;
                    }
                }
                else
                {
                    Console.WriteLine("Seu pokemom errou o movimento");
                    Dano = 0;
                }
            }
            else
            {

                Dano = 40 - inimigo.Defesa / 10;
                Dano += pokemon.Forca / 100;
                Math.Floor(Dano);

                Console.WriteLine("Seu pokeom acertou o movimento");

                if (numero <= 3)//Dano adicional por queimadura
                {
                    Console.WriteLine("O inimigo sofreu dano de fogo, causou mais 5 de dano.");
                    Dano += 5;
                }
            }

            if (inimigo.Tipo == "grama" && inimigo.Tipo == "gelo" && inimigo.Tipo == "inseto")
            {
                Dano += 2;
            }
            else if (inimigo.Tipo == "agua" && inimigo.Tipo == "terra" && inimigo.Tipo == "inseto")
            {
                Dano /= 2;
            }

            return Dano;
        }

        public double Bubble()//tipo agua
        {
            Random rand = new Random();

            int numero = rand.Next(1, 10 + 1);

            if (pokemon.Velocidade < inimigo.Velocidade)
            {

                if (numero <= 9)
                {

                    Dano = 40 - inimigo.Defesa / 10;
                    Dano += pokemon.Forca / 100;
                    Math.Floor(Dano);

                }
                else
                {
                    Dano = 0;
                }
            }
            else
            {

                Dano = 40 - inimigo.Defesa / 10;
                Dano += pokemon.Forca / 100;
                Math.Floor(Dano);


                if (numero <= 3)//O inimigo perde velocidade 
                {
                    inimigo.Velocidade -= 15;
                }
            }

            if (inimigo.Tipo == "fogo" && inimigo.Tipo == "terra")
            {
                Dano += 2;
            }
            else if (inimigo.Tipo == "eletrico" && inimigo.Tipo == "grama")
            {
                Dano /= 2;
            }

            return Dano;
        }

        public double WaterGun()//tipo agua
        {
            Random rand = new Random();

            int numero = rand.Next(1, 10 + 1);

            if (pokemon.Velocidade < inimigo.Velocidade)
            {

                if (numero <= 9)
                {

                    Dano = 40 - inimigo.Defesa / 10;
                    Dano += pokemon.Forca / 100;
                    Math.Floor(Dano);

                }
                else
                {
                    Dano = 0;
                }
            }
            else
            {

                Dano = 40 - inimigo.Defesa / 10;
                Dano += pokemon.Forca / 100;
                Math.Floor(Dano);

            }

            if (inimigo.Tipo == "fogo" && inimigo.Tipo == "terra")
            {
                Dano += 2;
            }
            else if (inimigo.Tipo == "eletrico" && inimigo.Tipo == "grama")
            {
                Dano /= 2;
            }

            return Dano;
        }

        public double LeechLife()//tipo inseto
        {
            Random rand = new Random();

            int numero = rand.Next(1, 10 + 1);

            if (pokemon.Velocidade < inimigo.Velocidade)
            {

                if (numero <= 9)
                {

                    Dano = 15 - pokemon.Defesa / 10;
                    Dano += inimigo.Forca / 100;
                    Math.Floor(Dano);

                }
                else
                {
                    Dano = 0;
                }
            }
            else
            {

                Dano = 15 - pokemon.Defesa / 10;
                Dano += inimigo.Forca / 100;
                Math.Floor(Dano);

            }

            if (pokemon.Tipo == "grama")
            {
                Dano += 2;
            }
            else if (pokemon.Tipo == "fogo")
            {
                Dano /= 2;
            }

            return Dano;
        }

        public double StringShot()//tipo inseto
        {
            Random rand = new Random();

            int numero = rand.Next(1, 10 + 1);

            if (inimigo.Velocidade < pokemon.Velocidade)
            {

                if (numero <= 9)
                {

                    Dano = 20 - pokemon.Defesa / 10;
                    Dano += inimigo.Forca / 100;
                    Math.Floor(Dano);

                }
                else
                {
                    Dano = 0;
                }
            }
            else
            {

                Dano = 20 - pokemon.Defesa / 10;
                Dano += inimigo.Forca / 100;
                Math.Floor(Dano);

            }

            if (pokemon.Tipo == "grama")
            {
                Dano += 2;
            }
            else if (pokemon.Tipo == "fogo")
            {
                Dano /= 2;
            }
            //Seu pokemon perde vida e 15 de velocidade
            return Dano;
        }

        public double MudSlap()//tipo terra
        {
            Random rand = new Random();

            int numero = rand.Next(1, 10 + 1);

            if (inimigo.Velocidade < pokemon.Velocidade)
            {

                if (numero <= 9)
                {

                    Dano = 15 - pokemon.Defesa / 10;
                    Dano += inimigo.Forca / 100;
                    Math.Floor(Dano);

                }
                else
                {
                    Dano = 0;
                }
            }
            else
            {

                Dano = 15 - pokemon.Defesa / 10;
                Dano += inimigo.Forca / 100;
                Math.Floor(Dano);

            }

            if (pokemon.Tipo == "fogo")
            {
                Dano += 2;
            }
            else if (pokemon.Tipo == "grama" && pokemon.Tipo == "agua")
            {
                Dano /= 2;
            }
            //Seu pokemon perde vida e 15 de velocidade
            return Dano;
        }

        public double Earthquake()//tipo terra
        {
            Random rand = new Random();

            int numero = rand.Next(1, 10 + 1);

            if (inimigo.Velocidade < pokemon.Velocidade)
            {

                if (numero <= 9)
                {

                    Dano = 20 - pokemon.Defesa / 10;
                    Dano += inimigo.Forca / 100;
                    Math.Floor(Dano);

                }
                else
                {
                    Dano = 0;
                }
            }
            else
            {

                Dano = 20 - pokemon.Defesa / 10;
                Dano += inimigo.Forca / 100;
                Math.Floor(Dano);

            }

            if (pokemon.Tipo == "fogo")
            {
                Dano += 2;
            }
            else if (pokemon.Tipo == "grama" && pokemon.Tipo == "agua")
            {
                Dano /= 2;
            }
            //Seu pokemon perde vida e 15 de velocidade
            return Dano;
        }

        public double RockThrow()//tipo pedra
        {
            Random rand = new Random();

            int numero = rand.Next(1, 10 + 1);

            if (inimigo.Velocidade < pokemon.Velocidade)
            {

                if (numero <= 9)
                {

                    Dano = 15 - pokemon.Defesa / 10;
                    Dano += inimigo.Forca / 100;
                    Math.Floor(Dano);

                }
                else
                {
                    Dano = 0;
                }
            }
            else
            {

                Dano = 15 - pokemon.Defesa / 10;
                Dano += inimigo.Forca / 100;
                Math.Floor(Dano);

            }

            if (pokemon.Tipo == "fogo")
            {
                Dano += 2;
            }
            else if (pokemon.Tipo == "grama" && pokemon.Tipo == "agua")
            {
                Dano /= 2;
            }
            //Seu pokemon perde vida e 15 de velocidade
            return Dano;
        }

        public double RockSlide()//tipo pedra
        {
            Random rand = new Random();

            int numero = rand.Next(1, 10 + 1);

            if (inimigo.Velocidade < pokemon.Velocidade)
            {

                if (numero <= 9)
                {

                    Dano = 20 - pokemon.Defesa / 10;
                    Dano += inimigo.Forca / 100;
                    Math.Floor(Dano);

                }
                else
                {
                    Dano = 0;
                }
            }
            else
            {

                Dano = 20 - pokemon.Defesa / 10;
                Dano += inimigo.Forca / 100;
                Math.Floor(Dano);

            }

            if (pokemon.Tipo == "fogo")
            {
                Dano += 2;
            }
            else if (pokemon.Tipo == "grama" && pokemon.Tipo == "agua")
            {
                Dano /= 2;
            }
            //Seu pokemon perde vida e 15 de velocidade
            return Dano;
        }

        public double BubbleInimigo()//tipo agua
        {
            Random rand = new Random();

            int numero = rand.Next(1, 10 + 1);

            if (pokemon.Velocidade < inimigo.Velocidade)
            {

                if (numero <= 9)
                {

                    Dano = 15 - pokemon.Defesa / 10;
                    Dano += inimigo.Forca / 100;
                    Math.Floor(Dano);

                }
                else
                {
                    Dano = 0;
                }
            }
            else
            {

                Dano = 15 - pokemon.Defesa / 10;
                Dano += inimigo.Forca / 100;
                Math.Floor(Dano);


                if (numero <= 3)//O inimigo perde velocidade 
                {
                    pokemon.Velocidade -= 15;
                }
            }

            if (pokemon.Tipo == "fogo")
            {
                Dano += 2;
            }
            else if (pokemon.Tipo == "grama")
            {
                Dano /= 2;
            }

            return Dano;
        }

        public double WaterGunInimigo()//tipo agua
        {
            Random rand = new Random();

            int numero = rand.Next(1, 10 + 1);

            if (pokemon.Velocidade < inimigo.Velocidade)
            {

                if (numero <= 9)
                {

                    Dano = 20 - pokemon.Defesa / 10;
                    Dano += inimigo.Forca / 100;
                    Math.Floor(Dano);

                }
                else
                {
                    Dano = 0;
                }
            }
            else
            {

                Dano = 20 - pokemon.Defesa / 10;
                Dano += inimigo.Forca / 100;
                Math.Floor(Dano);

            }

            if (pokemon.Tipo == "fogo")
            {
                Dano += 2;
            }
            else if (pokemon.Tipo == "grama")
            {
                Dano /= 2;
            }

            return Dano;
        }

        public double EmberInimigo()//tipo fogo
        {
            Random rand = new Random();

            int numero = rand.Next(1, 10 + 1);

            if (inimigo.Velocidade < pokemon.Velocidade)
            {

                if (numero <= 9)
                {

                    Dano = 15 - pokemon.Defesa / 10;
                    Dano += inimigo.Forca / 100;
                    Math.Floor(Dano);

                    Console.WriteLine("Seu pokeom acertou o movimento");

                    if (numero <= 3)
                    {
                        Console.WriteLine("O inimigo sofreu dano de fogo, causou mais 5 de dano.");
                        Dano += 5;
                    }
                }
                else
                {
                    Console.WriteLine("Seu pokemom errou o movimento");
                    Dano = 0;
                }
            }
            else
            {

                Dano = 15 - pokemon.Defesa / 10;
                Dano += inimigo.Forca / 100;
                Math.Floor(Dano);

                Console.WriteLine("Seu pokeom acertou o movimento");

                if (numero <= 3)//Dano adicional por queimadura
                {
                    Console.WriteLine("O inimigo sofreu dano de fogo, causou mais 5 de dano.");
                    Dano += 5;
                }
            }

            if (pokemon.Tipo == "grama")
            {
                Dano += 2;
            }
            else if (pokemon.Tipo == "agua")
            {
                Dano /= 2;
            }

            return Dano;
        }

        public double Flamethrower()//tipo fogo
        {
            Random rand = new Random();

            int numero = rand.Next(1, 10 + 1);

            if (inimigo.Velocidade < pokemon.Velocidade)
            {

                if (numero <= 9)
                {

                    Dano = 20 - pokemon.Defesa / 10;
                    Dano += inimigo.Forca / 100;
                    Math.Floor(Dano);

                    Console.WriteLine("Seu pokeom acertou o movimento");

                    if (numero <= 3)
                    {
                        Console.WriteLine("O inimigo sofreu dano de fogo, causou mais 5 de dano.");
                        Dano += 5;
                    }
                }
                else
                {
                    Console.WriteLine("Seu pokemom errou o movimento");
                    Dano = 0;
                }
            }
            else
            {

                Dano = 20 - pokemon.Defesa / 10;
                Dano += inimigo.Forca / 100;
                Math.Floor(Dano);

                Console.WriteLine("Seu pokeom acertou o movimento");

                if (numero <= 3)//Dano adicional por queimadura
                {
                    Console.WriteLine("O inimigo sofreu dano de fogo, causou mais 5 de dano.");
                    Dano += 5;
                }
            }

            if (pokemon.Tipo == "grama")
            {
                Dano += 2;
            }
            else if (pokemon.Tipo == "agua")
            {
                Dano /= 2;
            }

            return Dano;
        }

        public double VineWhipeInimigo()//tipo grama
        {
            Random rand = new Random();

            int numero = rand.Next(1, 10 + 1);

            if (inimigo.Velocidade < pokemon.Velocidade)
            {
                if (numero <= 9)
                {

                    Dano = 15 - pokemon.Defesa / 10;
                    Dano += inimigo.Forca / 100;
                    Math.Floor(Dano);

                }
                else
                {
                    Dano = 0;
                }
            }
            else
            {

                Dano = 15 - pokemon.Defesa / 10;
                Dano += inimigo.Forca / 100;
                Math.Floor(Dano);

            }

            if (pokemon.Tipo == "agua")
            {
                Dano += 2;
            }
            else if (pokemon.Tipo == "fogo")
            {
                Dano /= 2;
            }

            return Dano;
        }

        public double RazorLeaf()//tipo grama
        {
            Random rand = new Random();

            int numero = rand.Next(1, 10 + 1);

            if (inimigo.Velocidade < pokemon.Velocidade)
            {
                if (numero <= 9)
                {

                    Dano = 20 - pokemon.Defesa / 10;
                    Dano += inimigo.Forca / 100;
                    Math.Floor(Dano);

                }
                else
                {
                    Dano = 0;
                }
            }
            else
            {

                Dano = 20 - pokemon.Defesa / 10;
                Dano += inimigo.Forca / 100;
                Math.Floor(Dano);

            }

            if (pokemon.Tipo == "agua")
            {
                Dano += 2;
            }
            else if (pokemon.Tipo == "fogo")
            {
                Dano /= 2;
            }

            return Dano;
        }

        public double Thunderbolt()//tipo grama
        {
            Random rand = new Random();

            int numero = rand.Next(1, 10 + 1);

            if (inimigo.Velocidade < pokemon.Velocidade)
            {
                if (numero <= 9)
                {

                    Dano = 15 - pokemon.Defesa / 10;
                    Dano += inimigo.Forca / 100;
                    Math.Floor(Dano);

                }
                else
                {
                    Dano = 0;
                }
            }
            else
            {

                Dano = 15 - pokemon.Defesa / 10;
                Dano += inimigo.Forca / 100;
                Math.Floor(Dano);

            }

            if (pokemon.Tipo == "agua")
            {
                Dano += 2;
            }
            else if (pokemon.Tipo == "grama")
            {
                Dano /= 2;
            }

            return Dano;
        }

        public double ThunderShock()//tipo grama
        {
            Random rand = new Random();

            int numero = rand.Next(1, 10 + 1);

            if (inimigo.Velocidade < pokemon.Velocidade)
            {
                if (numero <= 9)
                {

                    Dano = 20 - pokemon.Defesa / 10;
                    Dano += inimigo.Forca / 100;
                    Math.Floor(Dano);

                }
                else
                {
                    Dano = 0;
                }
            }
            else
            {

                Dano = 20 - pokemon.Defesa / 10;
                Dano += inimigo.Forca / 100;
                Math.Floor(Dano);

            }

            if (pokemon.Tipo == "agua")
            {
                Dano += 2;
            }
            else if (pokemon.Tipo == "grama")
            {
                Dano /= 2;
            }

            return Dano;
        }


    }
}
