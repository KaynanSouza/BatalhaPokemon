namespace PokemonSegundoTeste
{
    internal class Jogo
    {
        public void Iniciar()
        {
            Linha linha = new Linha();
            Random rand = new Random();

            Console.WriteLine("***************************************");
            Console.WriteLine("\tBatalha Pokemon");
            Console.WriteLine("***************************************");
            Console.WriteLine("Ola, seja bem vindo ao mundo Pokemon!!");

            List<Models.Pokemon> pokemonsDisponiveis = Models.Pokemon.ObterPokemonsDisponiveis();

            Models.Pokemon pokemonEscolhido = EscolherPokemon(pokemonsDisponiveis);

            Models.Inimigo inimigo = Models.Inimigo.CriarInimigoAleatorio();

            Console.WriteLine($"O seu pokemon escolhido foi o {pokemonEscolhido.Nome}.");
            Console.WriteLine($"O seu adversário é o {inimigo.Nome}.");

            while (pokemonEscolhido.Vida > 0 && inimigo.Vida > 0)
            {
                linha.Pontos();
                Console.WriteLine($"Vida do seu {pokemonEscolhido.Nome}: {pokemonEscolhido.Vida}");
                Console.WriteLine($"Vida do {inimigo.Nome}: {inimigo.Vida}");
                linha.Pontos();

                Console.WriteLine("Escolha o seu movimento:");
                Console.WriteLine("1. Tackle (Dano Base: 35)");
                Console.WriteLine("2. Vine Whip (Dano Base: 45)");

                int movimento;
                if (int.TryParse(Console.ReadLine(), out movimento) && (movimento == 1 || movimento == 2))
                {
                    bool critico = rand.Next(1, 101) <= 10; // 10% de chance de crítico
                    double danoBase = movimento == 1 ? 35 : 45;
                    double dano = Utils.Movimento.CalcularDano(pokemonEscolhido, inimigo, danoBase, critico);
                    inimigo.Vida -= dano;
                    Console.WriteLine(critico ? "Ataque crítico!" : "");
                    Console.WriteLine($"Seu pokemon deu {dano} de dano ao {inimigo.Nome}");
                }
                else
                {
                    Console.WriteLine("Movimento inválido, tente novamente.");
                    continue;
                }

                if (inimigo.Vida <= 0)
                {
                    Console.WriteLine($"Parabéns! Você derrotou o {inimigo.Nome}!");
                    break;
                }

                // Movimento do Inimigo
                int movimentoInimigo = rand.Next(1, 3);
                bool criticoInimigo = rand.Next(1, 101) <= 10; // 10% de chance de crítico
                double danoInimigo = Utils.Movimento.CalcularDano(inimigo, pokemonEscolhido, 30, criticoInimigo);
                pokemonEscolhido.Vida -= danoInimigo;
                Console.WriteLine(criticoInimigo ? "Ataque crítico do inimigo!" : "");
                Console.WriteLine($"{inimigo.Nome} atacou e causou {danoInimigo} de dano ao seu {pokemonEscolhido.Nome}");

                if (pokemonEscolhido.Vida <= 0)
                {
                    Console.WriteLine($"Seu {pokemonEscolhido.Nome} foi derrotado pelo {inimigo.Nome}. Fim de jogo!");
                }
            }

            Console.WriteLine("Obrigado por jogar!!");
        }

        private Models.Pokemon EscolherPokemon(List<Models.Pokemon> pokemonsDisponiveis)
        {
            while (true)
            {
                Console.WriteLine("Escolha seu pokemon para batalhar:");
                for (int i = 0; i < pokemonsDisponiveis.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {pokemonsDisponiveis[i].Nome}");
                }

                int escolha;
                if (int.TryParse(Console.ReadLine(), out escolha) && escolha > 0 && escolha <= pokemonsDisponiveis.Count)
                {
                    return pokemonsDisponiveis[escolha - 1];
                }
                else
                {
                    Console.WriteLine("Escolha inválida, tente novamente.");
                }
            }
        }
    }

    internal class Linha
    {
        public void Pontos()
        {
            Console.WriteLine("***************************************");
        }
    }
}
