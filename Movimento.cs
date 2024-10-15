using PokemonSegundoTeste.Models;

namespace PokemonSegundoTeste.Utils
{
    internal class Movimento
    {
        public static double CalcularDano(Pokemon atacante, Inimigo defensor, double danoBase, bool critico)
        {
            Random rand = new Random();
            int chanceAcerto = rand.Next(1, 11);

            if (chanceAcerto <= 8 || critico)
            {
                double multiplicadorTipo = ObterMultiplicadorTipo(atacante.Tipo, defensor.Tipo);
                double dano = (danoBase - (defensor.Defesa / 10) + (atacante.Forca / 100)) * multiplicadorTipo;
                return Math.Max(0, Math.Floor(dano));
            }
            return 0;
        }

        public static double CalcularDano(Inimigo atacante, Pokemon defensor, double danoBase, bool critico)
        {
            Random rand = new Random();
            int chanceAcerto = rand.Next(1, 11);

            if (chanceAcerto <= 8 || critico)
            {
                double multiplicadorTipo = ObterMultiplicadorTipo(atacante.Tipo, defensor.Tipo);
                double dano = (danoBase - (defensor.Defesa / 10) + (atacante.Forca / 100)) * multiplicadorTipo;
                return Math.Max(0, Math.Floor(dano));
            }
            return 0;
        }

        public static double ObterMultiplicadorTipo(string tipoAtacante, string tipoDefensor)
        {
            if ((tipoAtacante == "grama" && tipoDefensor == "agua") ||
                (tipoAtacante == "agua" && tipoDefensor == "fogo") ||
                (tipoAtacante == "fogo" && tipoDefensor == "grama"))
            {
                return 2.0; // Dano super efetivo
            }
            if ((tipoAtacante == "grama" && tipoDefensor == "fogo") ||
                (tipoAtacante == "agua" && tipoDefensor == "grama") ||
                (tipoAtacante == "fogo" && tipoDefensor == "agua"))
            {
                return 0.5; // Dano pouco efetivo
            }
            return 1.0; // Dano normal
        }
    }
}
