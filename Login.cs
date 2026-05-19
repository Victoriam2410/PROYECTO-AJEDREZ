using System;
using System.Windows.Forms;

namespace AjedrezJuego
{
    public class FormLogin : Form
    {
        private Label lblTitulo;
        private Label lblUsuario;
        private Label lblContrasena;
        private TextBox txtUsuario;
        private TextBox txtContrasena;


        private const string USUARIO_CORRECTO = "admin";
        private const string CONTRASENA_CORRECTA = "Juego@123";
        public FormLogin()
        {
            this.Text = "JUEGO DE AJEDREZ - Login";
            this.Size = new System.Drawing.Size(400, 320);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.LightYellow;

            lblTitulo = new Label();
            lblTitulo.Text = "===== JUEGO DE AJEDREZ =====";
            lblTitulo.Font = new System.Drawing.Font("Arial", 13, System.Drawing.FontStyle.Bold);
            lblTitulo.Location = new System.Drawing.Point(50, 20);
            lblTitulo.Size = new System.Drawing.Size(300, 30);
            lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        }
    }
}
