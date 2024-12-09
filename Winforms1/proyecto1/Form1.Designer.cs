namespace proyecto1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label lblDatosPersonales;
        private System.Windows.Forms.CheckBox ckbBoludo;
        private System.Windows.Forms.RadioButton rdbJuego1;
        private System.Windows.Forms.RadioButton rdbJuego2;
        private System.Windows.Forms.RadioButton rdbJuego3;
        private System.Windows.Forms.GroupBox grbJuegos;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.NumericUpDown numBoludometro;
        private System.Windows.Forms.Label lblPreguntaBoluda;
        private System.Windows.Forms.ComboBox cmbColorFav;
        private System.Windows.Forms.Label lblColorFavorito;
    }
}

