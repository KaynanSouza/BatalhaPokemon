namespace PokemonSegundoTeste.Models
{
    internal class Inimigo
    {
        public string Nome { get; private set; }
        public string Tipo { get; private set; }
        public double Vida { get; set; }
        public double Velocidade { get; private set; }
        public double Defesa { get; private set; }
        public double Forca { get; private set; }

        private static readonly List<Inimigo> inimigosDisponiveis = new List<Inimigo>
        {
            new Inimigo("Sanshrew", "terra", 200, 40, 85, 75),
            new Inimigo("Vilpix", "fogo", 200, 65, 40, 41),
            new Inimigo("Jigglypuff", "normal", 115, 20, 20, 45),
            new Inimigo("Bulbasaur", "grama", 200, 45, 49, 45),
            new Inimigo("Charmander", "fogo", 200, 60, 43, 52),
            new Inimigo("Squirtle", "agua", 200, 43, 65, 48),
            new Inimigo("Caterpie", "inseto", 200, 20, 55, 20),
            new Inimigo("Metapod", "inseto", 200, 55, 30, 20),
            new Inimigo("Weedle", "inseto", 200, 35, 30, 35),
            new Inimigo("Kakuna", "inseto", 200, 35, 50, 25),
            new Inimigo("Pidgey", "normal", 200, 56, 40, 45),
            new Inimigo("Rattata", "normal", 200, 72, 35, 56),
            new Inimigo("Pikachu", "eletrico", 200, 90, 40, 55),
            new Inimigo("Oddish", "grama", 200, 30, 55, 50),
            new Inimigo("Seel", "agua", 200, 45, 55, 45),
            new Inimigo("Geodude", "pedra", 200, 20, 100, 80),
            new Inimigo("Ponyta", "fogo", 200, 90, 55, 85),
            new Inimigo("Slowpoke", "agua", 200, 15, 65, 65),
            new Inimigo("Voltorb", "eletrico", 200, 100, 50, 30),
            new Inimigo("Lapras", "agua", 130, 60, 80, 85),
            new Inimigo("Mankey", "lutador", 180, 70, 35, 80),
            new Inimigo("Growlithe", "fogo", 200, 60, 45, 70),
            new Inimigo("Poliwag", "agua", 160, 90, 40, 50),
            new Inimigo("Abra", "psiquico", 150, 105, 20, 40),
            new Inimigo("Machop", "lutador", 210, 45, 50, 85),
            new Inimigo("Bellsprout", "grama", 190, 50, 35, 75),
            new Inimigo("Tentacool", "agua", 200, 70, 60, 50),
            new Inimigo("Magnemite", "eletrico", 170, 45, 95, 60),
            new Inimigo("Doduo", "normal", 180, 110, 45, 85),
            new Inimigo("Grimer", "veneno", 220, 25, 80, 65),
            new Inimigo("Shellder", "agua", 150, 40, 100, 65)
        };

        private Inimigo(string nome, string tipo, double vida, double velocidade, double defesa, double forca)
        {
            Nome = nome;
            Tipo = tipo;
            Vida = vida;
            Velocidade = velocidade;
            Defesa = defesa;
            Forca = forca;
        }

        public static Inimigo CriarInimigoAleatorio()
        {
            Random rand = new Random();
            int index = rand.Next(inimigosDisponiveis.Count);
            return inimigosDisponiveis[index];
        }
    }
}
