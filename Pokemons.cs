
using System.Security.Cryptography.X509Certificates;
using PokemonSegundoTeste;

namespace PokemonSegundoTeste
{
    internal class DadosPokemons
    {
        public double Vida, Velocidade, Defesa, Forca;
        public string Nome, Tipo;

        public void Bulbasaur()
        {
            Nome = "Bulbasaur";
            Tipo = "grama";
            Vida = 90;
            Forca = 49;
            Defesa = 49;
            Velocidade = 45;
        }

        public void Charmander()
        {
            Nome = "Charmander";
            Tipo = "fogo";
            Vida = 78;
            Forca = 52;
            Defesa = 43;
            Velocidade = 65;
        }

        public void Squirtle()
        {
            Nome = "Squirtle";
            Tipo = "agua";
            Vida = 88;
            Forca = 48;
            Defesa = 65;
            Velocidade = 43;
        }

        
    }
}
