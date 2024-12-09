using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnResultados = new System.Windows.Forms.Button();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.lblDatosPersonales = new System.Windows.Forms.Label();
            this.ckbBoludo = new System.Windows.Forms.CheckBox();
            this.rdbJuego1 = new System.Windows.Forms.RadioButton();
            this.rdbJuego2 = new System.Windows.Forms.RadioButton();
            this.rdbJuego3 = new System.Windows.Forms.RadioButton();
            this.grbJuegos = new System.Windows.Forms.GroupBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.numBoludometro = new System.Windows.Forms.NumericUpDown();
            this.lblPreguntaBoluda = new System.Windows.Forms.Label();
            this.cmbColorFav = new System.Windows.Forms.ComboBox();
            this.lblColorFavorito = new System.Windows.Forms.Label();
            this.grbJuegos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoludometro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResultados
            // 
            this.btnResultados.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResultados.Location = new System.Drawing.Point(133, 419);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(368, 53);
            this.btnResultados.TabIndex = 6;
            this.btnResultados.Text = "resultados";
            this.btnResultados.UseVisualStyleBackColor = true;
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(162, 56);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(75, 19);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "nombre:";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbNombre.Location = new System.Drawing.Point(262, 56);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(239, 22);
            this.txtbNombre.TabIndex = 0;
            // 
            // lblDatosPersonales
            // 
            this.lblDatosPersonales.AutoSize = true;
            this.lblDatosPersonales.Font = new System.Drawing.Font("Yu Mincho Demibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosPersonales.Location = new System.Drawing.Point(212, 9);
            this.lblDatosPersonales.Name = "lblDatosPersonales";
            this.lblDatosPersonales.Size = new System.Drawing.Size(271, 30);
            this.lblDatosPersonales.TabIndex = 4;
            this.lblDatosPersonales.Text = "DATOS PERSONALES";
            // 
            // ckbBoludo
            // 
            this.ckbBoludo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbBoludo.AutoSize = true;
            this.ckbBoludo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ckbBoludo.Location = new System.Drawing.Point(201, 102);
            this.ckbBoludo.Name = "ckbBoludo";
            this.ckbBoludo.Size = new System.Drawing.Size(102, 20);
            this.ckbBoludo.TabIndex = 1;
            this.ckbBoludo.Text = "Sos boludo?";
            this.ckbBoludo.UseVisualStyleBackColor = true;
            // 
            // rdbJuego1
            // 
            this.rdbJuego1.AutoSize = true;
            this.rdbJuego1.Location = new System.Drawing.Point(6, 28);
            this.rdbJuego1.Name = "rdbJuego1";
            this.rdbJuego1.Size = new System.Drawing.Size(118, 20);
            this.rdbJuego1.TabIndex = 6;
            this.rdbJuego1.TabStop = true;
            this.rdbJuego1.Text = "genshin impact";
            this.rdbJuego1.UseVisualStyleBackColor = true;
            // 
            // rdbJuego2
            // 
            this.rdbJuego2.AutoSize = true;
            this.rdbJuego2.Location = new System.Drawing.Point(130, 28);
            this.rdbJuego2.Name = "rdbJuego2";
            this.rdbJuego2.Size = new System.Drawing.Size(72, 20);
            this.rdbJuego2.TabIndex = 7;
            this.rdbJuego2.TabStop = true;
            this.rdbJuego2.Text = "Roblos";
            this.rdbJuego2.UseVisualStyleBackColor = true;
            // 
            // rdbJuego3
            // 
            this.rdbJuego3.AutoSize = true;
            this.rdbJuego3.Location = new System.Drawing.Point(208, 28);
            this.rdbJuego3.Name = "rdbJuego3";
            this.rdbJuego3.Size = new System.Drawing.Size(82, 20);
            this.rdbJuego3.TabIndex = 8;
            this.rdbJuego3.TabStop = true;
            this.rdbJuego3.Text = "Minecraft";
            this.rdbJuego3.UseVisualStyleBackColor = true;
            // 
            // grbJuegos
            // 
            this.grbJuegos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grbJuegos.Controls.Add(this.rdbJuego1);
            this.grbJuegos.Controls.Add(this.rdbJuego3);
            this.grbJuegos.Controls.Add(this.rdbJuego2);
            this.grbJuegos.Location = new System.Drawing.Point(100, 158);
            this.grbJuegos.Name = "grbJuegos";
            this.grbJuegos.Size = new System.Drawing.Size(340, 54);
            this.grbJuegos.TabIndex = 2;
            this.grbJuegos.TabStop = false;
            this.grbJuegos.Text = "Que juego te gusta?";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(248, 256);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(253, 22);
            this.dtpFechaNacimiento.TabIndex = 3;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(51, 256);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(178, 19);
            this.lblFechaNacimiento.TabIndex = 10;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // numBoludometro
            // 
            this.numBoludometro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBoludometro.BackColor = System.Drawing.SystemColors.Menu;
            this.numBoludometro.Location = new System.Drawing.Point(262, 294);
            this.numBoludometro.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numBoludometro.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBoludometro.Name = "numBoludometro";
            this.numBoludometro.Size = new System.Drawing.Size(239, 22);
            this.numBoludometro.TabIndex = 4;
            this.numBoludometro.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPreguntaBoluda
            // 
            this.lblPreguntaBoluda.AutoSize = true;
            this.lblPreguntaBoluda.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreguntaBoluda.Location = new System.Drawing.Point(51, 315);
            this.lblPreguntaBoluda.Name = "lblPreguntaBoluda";
            this.lblPreguntaBoluda.Size = new System.Drawing.Size(170, 19);
            this.lblPreguntaBoluda.TabIndex = 12;
            this.lblPreguntaBoluda.Text = "que tan boludo sos?";
            // 
            // cmbColorFav
            // 
            this.cmbColorFav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbColorFav.FormattingEnabled = true;
            this.cmbColorFav.Location = new System.Drawing.Point(262, 343);
            this.cmbColorFav.Name = "cmbColorFav";
            this.cmbColorFav.Size = new System.Drawing.Size(239, 24);
            this.cmbColorFav.TabIndex = 5;
            // 
            // lblColorFavorito
            // 
            this.lblColorFavorito.AutoSize = true;
            this.lblColorFavorito.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorFavorito.Location = new System.Drawing.Point(29, 348);
            this.lblColorFavorito.Name = "lblColorFavorito";
            this.lblColorFavorito.Size = new System.Drawing.Size(208, 19);
            this.lblColorFavorito.TabIndex = 14;
            this.lblColorFavorito.Text = "Cual es tu color favorito?";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(596, 575);
            this.Controls.Add(this.lblColorFavorito);
            this.Controls.Add(this.cmbColorFav);
            this.Controls.Add(this.lblPreguntaBoluda);
            this.Controls.Add(this.numBoludometro);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.grbJuegos);
            this.Controls.Add(this.ckbBoludo);
            this.Controls.Add(this.lblDatosPersonales);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.btnResultados);
            this.MaximumSize = new System.Drawing.Size(1123, 622);
            this.MinimumSize = new System.Drawing.Size(614, 622);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbJuegos.ResumeLayout(false);
            this.grbJuegos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoludometro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
           string ColorFav = cmbColorFav.SelectedItem.ToString();
           string Nombre = txtbNombre.Text;
           DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            string juego;
            if (rdbJuego1.Checked)
                juego = "Genshin Impact";
            else if (rdbJuego2.Checked)
                juego = "Roblox";
            else
                juego = "Minecraft";
            //operador ternario (if en una sola linea de codigo)
            string boludo = ckbBoludo.Checked == true ? "sos boludo" : "estas mintiendo, si sos boludo";
            string colorfav = cmbColorFav.SelectedItem.ToString();
            string boludometro = numBoludometro.Value.ToString();

            string mensaje = "tu nombre es: " + Nombre + " juega " + juego + ", su fecha de nacimiento es: " + fechaNacimiento + " se dio un " + boludometro + " de 10 en el boludometro y su color favorito es el " + colorfav + ", " + boludo;

            MessageBox.Show(mensaje);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbColorFav.Items.Add("rojo");
            cmbColorFav.Items.Add("morado");
            cmbColorFav.Items.Add("verde");
            cmbColorFav.Items.Add("rosa");
            cmbColorFav.Items.Add("negro");
        }
    }
}
