using Xunit;

namespace Test2
{
    public class JuegoTests
    {
        private Juego juego;

        public JuegoTests()
        {
            juego = new Juego();
        }

        [Fact]
        public void CaixaNegra()
        {
            string resultado = juego.JugarPartida();
            Assert.Contains("Ha ganado el jugador", resultado);
        }
        
        [Fact]
        public void BoundaryTesting()
        {
            int puntos = juego.CalcularPuntos(0, 0);
            Assert.InRange(puntos, 0, 10);
        }

        [Fact]
        public void ProvesDeCamins()
        {
            int puntosJugador1 = juego.Tirar(1);
            int puntosJugador2 = juego.Tirar(2);

            Assert.True(puntosJugador1 >= 0 && puntosJugador1 <= 10);
            Assert.True(puntosJugador2 >= 0 && puntosJugador2 <= 10);
        }

        [Fact]
        public void ProvesDeBucles()
        {
            string resultado = juego.JugarPartida();
            Assert.Contains("Ha ganado el jugador", resultado);
        }
    }
}




