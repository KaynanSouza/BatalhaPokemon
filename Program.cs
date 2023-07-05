using PokemonSegundoTeste;
using System.ComponentModel;
using System.Reflection.PortableExecutable;

namespace Pokemon
{
    class Jogo
    {
        static void Main(string[] args)
        {
            JogarNovamente:

            Linha linha = new Linha();
            DadosPokemons pokemon = new DadosPokemons();
            Inimigo inimigo = new Inimigo();
            Movimento mov = new Movimento();
            Random rand = new Random();

            int EscolhaPokemon;
            string repeticao;
            double Dano;
            string resp = "";


            linha.Pontos();
            Console.WriteLine("\tBatalha Pokemon");
            linha.Pontos();
            Console.WriteLine("Ola, seja bem vindo ao mundo Pokemon!!");

            do
            {

            EscolhaDoPokemon:

                linha.Pontos();
                Console.WriteLine("Escolha seu pokemon para batalhar:");
                linha.Pontos();
                Console.Write("\t1.Bulbasaur\n\t2.Charmander\n\t3.Squirtle\n");
                linha.Pontos();

                Console.Write("Escolha:");
                EscolhaPokemon = Convert.ToInt32(Console.ReadLine());

                switch (EscolhaPokemon)
                {
                    case 1:

                        linha.Pontos();

                        Console.WriteLine("\nNome do Pokemon: Bulbasaur");
                        Console.WriteLine("Tipo: Grama");
                        Console.WriteLine("Vida do Pokemon: 90 HP");
                        Console.WriteLine("Força do Pokemon: 49 SP");
                        Console.WriteLine("Defesa do Pokemon: 49 SP");
                        Console.WriteLine("Velocidade do Pokemon: 45 VP");

                        pokemon.Bulbasaur();

                        break;

                    case 2:

                        linha.Pontos();

                        Console.WriteLine("\nNome do Pokemon: Charmander");
                        Console.WriteLine("Tipo: Fogo");
                        Console.WriteLine("Vida do Pokemon: 78 HP");
                        Console.WriteLine("Força do Pokemon: 52 SP");
                        Console.WriteLine("Defesa do Pokemon: 43 SP");
                        Console.WriteLine("Velocidade do Pokemon: 65 VP");

                        pokemon.Charmander();

                        break;

                    case 3:

                        linha.Pontos();

                        Console.WriteLine("\nNome do Pokemon: Squirtle");
                        Console.WriteLine("Tipo: Água");
                        Console.WriteLine("Vida do Pokemon: 88 HP");
                        Console.WriteLine("Força do Pokemon: 48 SP");
                        Console.WriteLine("Defesa do Pokemon: 65 SP");
                        Console.WriteLine("Velocidade do Pokemon: 43 VP");

                        pokemon.Squirtle();

                        break;

                    default:

                        linha.Pontos();

                        Console.WriteLine("Número invalido, Digite novamente!");
                        
                        linha.Pontos();

                        goto EscolhaDoPokemon;

                        break;
                }

                linha.Pontos();

                Console.Write("Deseja continuar com esse Pokemon: ");
                repeticao = Console.ReadLine();

                Console.Clear();

            } while (repeticao.ToLower() != "sim" && repeticao.ToLower() != "s");

            inimigo.EscolhaInimigo();


            linha.Pontos();
            Console.WriteLine("A batalha já vai começar");
            linha.Pontos();
            Console.WriteLine($"O seu pokemon escolhido foi o {pokemon.Nome}.");
            Console.WriteLine($"O seu qdversário é o {inimigo.Nome}.");

            while (pokemon.Vida > 0 && inimigo.Vida > 0)
            {
                linha.Pontos();
                Console.WriteLine($"Vida do seu {pokemon.Nome}: {pokemon.Vida}");
                Console.WriteLine($"Vida do {inimigo.Nome}: {inimigo.Vida}");
                linha.Pontos();

                Console.WriteLine("Escolha o seu movimento.\n");

                if (pokemon.Nome == "Bulbasaur")
                {
                    Console.WriteLine("1.Tackle\t2.Vine Whipe\nDano Base:35\tDano Base:45\n\n3.Growth\t4.vida\n+Ataque,+Defesa\t+Vida");
                    int movimento = int.Parse(Console.ReadLine());

                    switch (movimento)
                    {
                        case 1:

                            linha.Pontos();

                            inimigo.Vida -= mov.Tackle();
                            Dano = mov.Tackle();
                            Console.WriteLine($"Seu pokemon deu {Dano} de dano");

                            linha.Pontos();

                            break;

                        case 2:

                            linha.Pontos();

                            inimigo.Vida -= mov.VineWhipe();
                            Dano = mov.VineWhipe();
                            Console.WriteLine($"Seu pokemon deu {Dano} de dano");

                            linha.Pontos();

                            break;

                        case 3:

                            linha.Pontos();

                            pokemon.Forca += 20;
                            pokemon.Defesa += 20;
                            Console.WriteLine("O seu pokemon aumentou 20 na defesa e na força");

                            linha.Pontos();

                            break;

                        case 4:

                            pokemon.Vida += 25;

                            if (pokemon.Vida > 90)
                            {
                                pokemon.Vida = 90;
                            }

                            break;

                    }

                }
                else if (pokemon.Nome == "Charmander")
                {
                    Console.WriteLine("1.Scratch\t2.Ember\nDano Base:35\tDano Base:45\n\n3.Leer\t4.vida\n+Ataque,+Defesa\t+Vida");
                    int movimento = int.Parse(Console.ReadLine());

                    switch (movimento)
                    {
                        case 1:

                            linha.Pontos();

                            inimigo.Vida -= mov.Scratch();
                            Dano = mov.Scratch();
                            Console.WriteLine($"Seu pokemon deu {Dano} de dano");

                            linha.Pontos();

                            break;

                        case 2:

                            linha.Pontos();

                            inimigo.Vida -= mov.Ember();
                            Dano = mov.Ember();
                            Console.WriteLine($"Seu pokemon deu {Dano} de dano");

                            break;

                        case 3:

                            linha.Pontos();

                            inimigo.Defesa += 20;
                            Console.WriteLine("O inimigo perdeu 20 de defesa.");

                            linha.Pontos();

                            break;

                        case 4:

                            pokemon.Vida += 20;

                            if (pokemon.Vida > 78)
                            {
                                pokemon.Vida = 78;
                            }

                            break;

                    }
                }
                else if (pokemon.Nome == "Squirtle")
                {
                    Console.WriteLine("1.Tackle\t2.Bubble\nDano Base:35\tDano Base:40\n\n3.WaterGun\t4.vida\nDano Base:40\t+Vida");
                    int movimento = int.Parse(Console.ReadLine());

                    switch (movimento)
                    {
                        case 1:

                            linha.Pontos();

                            inimigo.Vida -= mov.Tackle();
                            Dano = mov.Tackle();
                            Console.WriteLine($"Seu pokemon deu {Dano} de dano");

                            linha.Pontos();

                            break;

                        case 2:

                            linha.Pontos();

                            inimigo.Vida -= mov.Bubble();
                            Dano = mov.Bubble();
                            inimigo.Velocidade -= 15;

                            Console.WriteLine($"Seu pokemon deu {Dano} de dano");

                            linha.Pontos();

                            break;

                        case 3:

                            linha.Pontos();

                            inimigo.Vida -= mov.WaterGun();
                            Dano = mov.WaterGun();
                            Console.WriteLine($"Seu pokemon deu {Dano} de dano");

                            linha.Pontos();

                            break;

                        case 4:

                            pokemon.Vida += 23;

                            if (pokemon.Vida > 88)
                            {
                                pokemon.Vida = 88;
                            }

                            break;

                    }
                }

                int numero = rand.Next(1, 3 + 1);

                switch (numero)
                {
                    case 1:

                        pokemon.Vida -= mov.TackleInimigo();
                        Console.WriteLine("O inimigo usou Tackle");

                        break;

                    case 2:

                        if (inimigo.Tipo == "inseto")
                        {
                            pokemon.Vida -= mov.LeechLife();
                            Console.WriteLine("O inimigo usou Leech Life");
                        }
                        else if (inimigo.Tipo == "terra")
                        {
                            pokemon.Vida -= mov.MudSlap();
                            Console.WriteLine("O inimigo usou Mud Slap");
                        }
                        else if (inimigo.Tipo == "pedra")
                        {
                            pokemon.Vida -= mov.RockThrow();
                            Console.WriteLine("O inimigo usou Rock Throw");
                        }
                        else if (inimigo.Tipo == "agua")
                        {
                            pokemon.Vida -= mov.BubbleInimigo();
                            Console.WriteLine("O inimigo usou Bubble");
                        }
                        else if (inimigo.Tipo == "fogo")
                        {
                            pokemon.Vida -= mov.EmberInimigo();
                            Console.WriteLine("O inimigo usou o Ember");
                        }
                        else if (inimigo.Tipo == "grama")
                        {
                            pokemon.Vida -= mov.VineWhipeInimigo();
                            Console.WriteLine("O inimigo usou o Vine Whipe");
                        }
                        else if (inimigo.Tipo == "eletrico")
                        {
                            pokemon.Vida -= mov.ThunderShock();
                            Console.WriteLine("O inimigo usou o Thunder Shock");
                        }
                        else if (pokemon.Tipo == "normal")
                        {
                            pokemon.Vida -= mov.TackleInimigo();
                            Console.WriteLine("O inimigo usou Tackle");
                        }

                        break;

                    case 3:

                        if (pokemon.Tipo == "inseto")
                        {
                            pokemon.Vida -= mov.StringShot();
                            pokemon.Velocidade -= 15;
                            Console.WriteLine("O inimigo usou String Shot");
                            Console.WriteLine("O inimigo causou -15 de velocidade");

                        }
                        else if (pokemon.Tipo == "terra")
                        {
                            pokemon.Vida -= mov.Earthquake();
                            Console.WriteLine("O inimigo usou Earthquake");

                        }
                        else if (pokemon.Tipo == "pedra")
                        {
                            pokemon.Vida -= mov.RockSlide();
                            Console.WriteLine("O inimigo usou Rock Slide");

                        }
                        else if (inimigo.Tipo == "agua")
                        {
                            pokemon.Vida -= mov.WaterGun();
                            Console.WriteLine("O inimigo usou Water Gun");
                        }
                        else if (inimigo.Tipo == "fogo")
                        {
                            pokemon.Vida -= mov.Flamethrower();
                            Console.WriteLine("O inimigo usou o Flamethrower");

                        }
                        else if (pokemon.Tipo == "grama")
                        {
                            pokemon.Vida -= mov.RazorLeaf();
                            Console.WriteLine("O inimigo usou Razor Leaf");
                        }
                        else if (inimigo.Tipo == "eletrico")
                        {
                            pokemon.Vida -= mov.Thunderbolt();
                            Console.WriteLine("O inimigo usou o Thunderbolt");
                        }
                        else if (pokemon.Tipo == "normal")
                        {
                            pokemon.Vida -= mov.TackleInimigo();
                            Console.WriteLine("O inimigo usou Tackle");
                        }

                        break;
                }

                linha.Pontos();

                Console.WriteLine("Aperte qualquer para continuar.");
                string ponto = Console.ReadLine();

                linha.Pontos();

                Console.Clear();
            }

            linha.Pontos();
            Console.WriteLine("A sua batalha terminou, deseja jogar novamente? ");
            resp = Console.ReadLine();
            linha.Pontos();

            if (resp.ToLower() == "sim" || resp.ToLower() == "s")
            {
                goto JogarNovamente;
            }
            else
            {
                Console.WriteLine("Obrigado por jogar!!");
            }
        }
    }
}