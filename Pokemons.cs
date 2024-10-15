namespace PokemonSegundoTeste.Models
{
    internal class Pokemon
    {
        public string Nome { get; private set; }
        public string Tipo { get; private set; }
        public double Vida { get; set; }
        public double Velocidade { get; private set; }
        public double Defesa { get; private set; }
        public double Forca { get; private set; }

        public Pokemon(string nome, string tipo, double vida, double velocidade, double defesa, double forca)
        {
            Nome = nome;
            Tipo = tipo;
            Vida = vida;
            Velocidade = velocidade;
            Defesa = defesa;
            Forca = forca;
        }

        public static List<Pokemon> ObterPokemonsDisponiveis()
        {
            return new List<Pokemon>
            {
                new Pokemon("Bulbasaur", "grama", 90, 45, 49, 49),
                new Pokemon("Charmander", "fogo", 78, 65, 43, 52),
                new Pokemon("Squirtle", "agua", 88, 43, 65, 48),
                new Pokemon("Pikachu", "eletrico", 100, 90, 40, 55),
                new Pokemon("Eevee", "normal", 95, 55, 50, 50),
                new Pokemon("Jigglypuff", "normal", 115, 20, 20, 45),
                new Pokemon("Growlithe", "fogo", 110, 60, 45, 70),
                new Pokemon("Poliwag", "agua", 100, 90, 40, 50),
                new Pokemon("Abra", "psiquico", 80, 105, 20, 40),
                new Pokemon("Machop", "lutador", 120, 45, 50, 85)
            };
        }
    }
}
