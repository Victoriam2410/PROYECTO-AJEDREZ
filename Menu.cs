using System;
using System.Windows.Forms;

namespace AjedrezJuego
{
    public class FormMenu : Form
    {
        private Label lblTitulo;
        private Button btnIniciar;
        public FormMenu()
        {
            this.Text = "JUEGO DE AJEDREZ - Menu Principal";
            this.Size = new System.Drawing.Size(380, 380);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.LightCyan;

            lblTitulo = new Label();
            lblTitulo.Text = "     JUEGO DE TABLERO     ";
            lblTitulo.Font = new System.Drawing.Font("Arial", 13, System.Drawing.FontStyle.Bold);
            lblTitulo.Location = new System.Drawing.Point(30, 25);
            lblTitulo.Size = new System.Drawing.Size(310, 30);
            lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            btnIniciar = new Button();
            btnIniciar.Text = "1. Iniciar Partida";
            btnIniciar.Location = new System.Drawing.Point(90, 90);
            btnIniciar.Size = new System.Drawing.Size(190, 45);
            btnIniciar.Font = new System.Drawing.Font("Arial", 11);
            btnIniciar.BackColor = System.Drawing.Color.LimeGreen;
            btnIniciar.ForeColor = System.Drawing.Color.White;
            btnIniciar.Click += new EventHandler(btnIniciar_Click);
        }
    }
}