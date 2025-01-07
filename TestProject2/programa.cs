namespace Test2
{
    public class Juego
    {
        private Random rand = new Random();

        private int[,] puntosDiana =
        {
            { 0, 0, 0, 1, 1, 1, 0, 0, 0 },
            { 0, 0, 2, 2, 2, 2, 2, 0, 0 },
            { 0, 2, 5, 5, 5, 5, 5, 2, 0 },
            { 1, 2, 5, 10, 10, 10, 5, 2, 1 },
            { 1, 2, 5, 10, 10, 10, 5, 2, 1 },
            { 1, 2, 5, 10, 10, 10, 5, 2, 1 },
            { 0, 2, 5, 5, 5, 5, 5, 2, 0 },
            { 0, 0, 2, 2, 2, 2, 2, 0, 0 },
            { 0, 0, 0, 1, 1, 1, 0, 0, 0 }
        };

        public int CalcularPuntos(int x, int y)
        {
            int posX = x + 4;
            int posY = y + 4;

            if (posX >= 0 && posX < 9 && posY >= 0 && posY < 9)
            {
                return puntosDiana[posX, posY];
            }

            return 0;
        }

        public int Tirar(int jugador)
        {
            int x = rand.Next(-4, 5);
            int y = rand.Next(-4, 5);
            int puntos = CalcularPuntos(x, y);
            Console.WriteLine($"Jugador {jugador} tira a ({x},{y}) - {puntos} puntos");
            return puntos;
        }

        public string JugarPartida()
        {
            int puntosJugador1 = 0;
            int puntosJugador2 = 0;

            while (puntosJugador1 < 50 && puntosJugador2 < 50)
            {
                puntosJugador1 += Tirar(1);
                puntosJugador2 += Tirar(2);

                Console.WriteLine($"Jugador 1: {puntosJugador1} puntos, Jugador 2: {puntosJugador2} puntos");
            }

            if (puntosJugador1 > puntosJugador2)
            {
                return $"Ha ganado el jugador 1 {puntosJugador1} a {puntosJugador2}";
            }
            else if (puntosJugador2 > puntosJugador1)
            {
                return $"Ha ganado el jugador 2 {puntosJugador2} a {puntosJugador1}";
            }
            else
            {
                return $"Empate: Jugador 1 {puntosJugador1} puntos, Jugador 2 {puntosJugador2} puntos";
            }
        }
    }

    public class Program
    {
        public static void Main2()
        {
            Juego juego = new Juego();
            string resultado = juego.JugarPartida();
            Console.WriteLine(resultado);
        }
    }
}

