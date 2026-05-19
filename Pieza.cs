namespace AjedrezJuego
{
    public class Pieza
    {
        public string tipo;       
        public int jugador;       
        public int fila;
        public int columna;
        public bool viva;

        public Pieza(string tipoPieza, int numeroJugador, int filaInicial, int columnaInicial)
        {
            tipo = tipoPieza;
            jugador = numeroJugador;
            fila = filaInicial;
            columna = columnaInicial;
            viva = true;
        }

        public int PuntosAlEliminar()
        {
            if (tipo == "REY")
            {
                return 60;  
            }
            if (tipo == "TOR")
            {
                return 10;
            }
            if (tipo == "SOL")
            {
                return 10;
            }
            return 0;
        }
    }
}