namespace AjedrezJuego
{
    public class Tablero
    {
        // crear matriz con cnombre casilla (herbert no te vayas a confundir con las variables xd )
        public Pieza[,] casillas;

        public Tablero(Jugador jugador1, Jugador jugador2)
        {
            casillas = new Pieza[8, 8];


            int f;
            int c;
            for (f = 0; f < 8; f = f + 1)
            {
                for (c = 0; c < 8; c = c + 1)
                {
                    casillas[f, c] = null;
                }
            }

            // Jugador 1
            ColocarPiezasJugador(jugador1, 7, 6);

            // Jugador 2 
            ColocarPiezasJugador(jugador2, 0, 1);
        }

        //pa colocar las piezas depedne que seelecciona el user
        public void ColocarPiezasJugador(Jugador jugador, int filaTrasera, int filaSoldados)
        {
            int n = jugador.numero;

            casillas[filaSoldados, 2] = new Pieza("SOL", n, filaSoldados, 2);
            casillas[filaSoldados, 3] = new Pieza("SOL", n, filaSoldados, 3);
            casillas[filaSoldados, 4] = new Pieza("SOL", n, filaSoldados, 4);
            casillas[filaSoldados, 5] = new Pieza("SOL", n, filaSoldados, 5);

            casillas[filaTrasera, 4] = new Pieza("REY", n, filaTrasera, 4);

            if (jugador.posicionInicial == "ataque")
            {
                casillas[filaSoldados, 0] = new Pieza("TOR", n, filaSoldados, 0);
                casillas[filaSoldados, 7] = new Pieza("TOR", n, filaSoldados, 7);
            }
            else if (jugador.posicionInicial == "defensa")
            {
                casillas[filaTrasera, 3] = new Pieza("TOR", n, filaTrasera, 3);
                casillas[filaTrasera, 5] = new Pieza("TOR", n, filaTrasera, 5);
            }
            else
            {
                casillas[filaTrasera, 0] = new Pieza("TOR", n, filaTrasera, 0);
                casillas[filaTrasera, 7] = new Pieza("TOR", n, filaTrasera, 7);
            }
        }
    }
}