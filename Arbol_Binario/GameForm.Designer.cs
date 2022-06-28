
namespace Arbol_Binario
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.TxtDato = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.BtnSuma = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRecorrido = new System.Windows.Forms.Button();
            this.BtnAltura = new System.Windows.Forms.Button();
            this.BtnMenor = new System.Windows.Forms.Button();
            this.BtnMayor = new System.Windows.Forms.Button();
            this.BtnMultiplos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.gboxMarcador = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gboxMarcador.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtDato
            // 
            this.TxtDato.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtDato.Location = new System.Drawing.Point(20, 58);
            this.TxtDato.Name = "TxtDato";
            this.TxtDato.Size = new System.Drawing.Size(34, 31);
            this.TxtDato.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(770, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 139;
            this.btnExit.TabStop = false;
            // 
            // btnMin
            // 
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(736, 2);
            this.btnMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 30);
            this.btnMin.TabIndex = 138;
            this.btnMin.TabStop = false;
            // 
            // BtnSuma
            // 
            this.BtnSuma.BackColor = System.Drawing.Color.Transparent;
            this.BtnSuma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSuma.BackgroundImage")));
            this.BtnSuma.FlatAppearance.BorderSize = 0;
            this.BtnSuma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSuma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSuma.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSuma.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSuma.Location = new System.Drawing.Point(51, 12);
            this.BtnSuma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSuma.Name = "BtnSuma";
            this.BtnSuma.Size = new System.Drawing.Size(100, 30);
            this.BtnSuma.TabIndex = 135;
            this.BtnSuma.Text = "Suma";
            this.BtnSuma.UseVisualStyleBackColor = false;
            this.BtnSuma.Click += new System.EventHandler(this.BtnSuma_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.BtnRecorrido);
            this.panel1.Controls.Add(this.BtnAltura);
            this.panel1.Controls.Add(this.BtnMenor);
            this.panel1.Controls.Add(this.BtnMayor);
            this.panel1.Controls.Add(this.BtnMultiplos);
            this.panel1.Controls.Add(this.BtnSuma);
            this.panel1.Location = new System.Drawing.Point(14, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 54);
            this.panel1.TabIndex = 132;
            // 
            // BtnRecorrido
            // 
            this.BtnRecorrido.BackColor = System.Drawing.Color.Transparent;
            this.BtnRecorrido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRecorrido.BackgroundImage")));
            this.BtnRecorrido.FlatAppearance.BorderSize = 0;
            this.BtnRecorrido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnRecorrido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnRecorrido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecorrido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRecorrido.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnRecorrido.Location = new System.Drawing.Point(580, 12);
            this.BtnRecorrido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRecorrido.Name = "BtnRecorrido";
            this.BtnRecorrido.Size = new System.Drawing.Size(100, 30);
            this.BtnRecorrido.TabIndex = 140;
            this.BtnRecorrido.Text = "Recorrido";
            this.BtnRecorrido.UseVisualStyleBackColor = false;
            this.BtnRecorrido.Click += new System.EventHandler(this.BtnRecorrido_Click);
            // 
            // BtnAltura
            // 
            this.BtnAltura.BackColor = System.Drawing.Color.Transparent;
            this.BtnAltura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAltura.BackgroundImage")));
            this.BtnAltura.FlatAppearance.BorderSize = 0;
            this.BtnAltura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnAltura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAltura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAltura.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAltura.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnAltura.Location = new System.Drawing.Point(475, 12);
            this.BtnAltura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAltura.Name = "BtnAltura";
            this.BtnAltura.Size = new System.Drawing.Size(100, 30);
            this.BtnAltura.TabIndex = 140;
            this.BtnAltura.Text = "Altura";
            this.BtnAltura.UseVisualStyleBackColor = false;
            this.BtnAltura.Click += new System.EventHandler(this.BtnAltura_Click);
            // 
            // BtnMenor
            // 
            this.BtnMenor.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMenor.BackgroundImage")));
            this.BtnMenor.FlatAppearance.BorderSize = 0;
            this.BtnMenor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnMenor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnMenor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMenor.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnMenor.Location = new System.Drawing.Point(369, 12);
            this.BtnMenor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMenor.Name = "BtnMenor";
            this.BtnMenor.Size = new System.Drawing.Size(100, 30);
            this.BtnMenor.TabIndex = 140;
            this.BtnMenor.Text = "Menor";
            this.BtnMenor.UseVisualStyleBackColor = false;
            this.BtnMenor.Click += new System.EventHandler(this.BtnMenor_Click);
            // 
            // BtnMayor
            // 
            this.BtnMayor.BackColor = System.Drawing.Color.Transparent;
            this.BtnMayor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMayor.BackgroundImage")));
            this.BtnMayor.FlatAppearance.BorderSize = 0;
            this.BtnMayor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnMayor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnMayor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMayor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMayor.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnMayor.Location = new System.Drawing.Point(263, 12);
            this.BtnMayor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMayor.Name = "BtnMayor";
            this.BtnMayor.Size = new System.Drawing.Size(100, 30);
            this.BtnMayor.TabIndex = 140;
            this.BtnMayor.Text = "Mayor";
            this.BtnMayor.UseVisualStyleBackColor = false;
            this.BtnMayor.Click += new System.EventHandler(this.BtnMayor_Click);
            // 
            // BtnMultiplos
            // 
            this.BtnMultiplos.BackColor = System.Drawing.Color.Transparent;
            this.BtnMultiplos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMultiplos.BackgroundImage")));
            this.BtnMultiplos.FlatAppearance.BorderSize = 0;
            this.BtnMultiplos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnMultiplos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnMultiplos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMultiplos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMultiplos.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnMultiplos.Location = new System.Drawing.Point(157, 12);
            this.BtnMultiplos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMultiplos.Name = "BtnMultiplos";
            this.BtnMultiplos.Size = new System.Drawing.Size(100, 30);
            this.BtnMultiplos.TabIndex = 140;
            this.BtnMultiplos.Text = "+Multiplos";
            this.BtnMultiplos.UseVisualStyleBackColor = false;
            this.BtnMultiplos.Click += new System.EventHandler(this.BtnMultiplos_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.BtnBuscar);
            this.panel2.Controls.Add(this.BtnEliminar);
            this.panel2.Controls.Add(this.BtnInsertar);
            this.panel2.Controls.Add(this.TxtDato);
            this.panel2.Location = new System.Drawing.Point(14, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 144);
            this.panel2.TabIndex = 141;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.BackgroundImage")));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBuscar.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnBuscar.Location = new System.Drawing.Point(60, 58);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(100, 30);
            this.BtnBuscar.TabIndex = 137;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.BackgroundImage")));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEliminar.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnEliminar.Location = new System.Drawing.Point(60, 101);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(100, 30);
            this.BtnEliminar.TabIndex = 136;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.BackColor = System.Drawing.Color.Transparent;
            this.BtnInsertar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnInsertar.BackgroundImage")));
            this.BtnInsertar.FlatAppearance.BorderSize = 0;
            this.BtnInsertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnInsertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsertar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnInsertar.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnInsertar.Location = new System.Drawing.Point(60, 15);
            this.BtnInsertar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(100, 30);
            this.BtnInsertar.TabIndex = 135;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = false;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // gboxMarcador
            // 
            this.gboxMarcador.BackColor = System.Drawing.Color.Transparent;
            this.gboxMarcador.Controls.Add(this.panel2);
            this.gboxMarcador.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gboxMarcador.ForeColor = System.Drawing.Color.SeaGreen;
            this.gboxMarcador.Location = new System.Drawing.Point(25, 76);
            this.gboxMarcador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxMarcador.Name = "gboxMarcador";
            this.gboxMarcador.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxMarcador.Size = new System.Drawing.Size(205, 187);
            this.gboxMarcador.TabIndex = 142;
            this.gboxMarcador.TabStop = false;
            this.gboxMarcador.Text = "Operaciones con datos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Location = new System.Drawing.Point(-1, -6);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 457);
            this.panel3.TabIndex = 143;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(25, 307);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(763, 102);
            this.groupBox1.TabIndex = 143;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones directas";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(252, 36);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(530, 267);
            this.groupBox2.TabIndex = 144;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arbol Binario";
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMenu.BackgroundImage")));
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMenu.ForeColor = System.Drawing.Color.White;
            this.BtnMenu.Location = new System.Drawing.Point(688, 413);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(100, 30);
            this.BtnMenu.TabIndex = 152;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnAtras
            // 
            this.BtnAtras.BackColor = System.Drawing.Color.Transparent;
            this.BtnAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAtras.BackgroundImage")));
            this.BtnAtras.FlatAppearance.BorderSize = 0;
            this.BtnAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtras.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAtras.ForeColor = System.Drawing.Color.White;
            this.BtnAtras.Location = new System.Drawing.Point(596, 413);
            this.BtnAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(100, 30);
            this.BtnAtras.TabIndex = 153;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = false;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.gboxMarcador);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gboxMarcador.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TxtDato;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.Button BtnSuma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnRecorrido;
        private System.Windows.Forms.Button BtnAltura;
        private System.Windows.Forms.Button BtnMenor;
        private System.Windows.Forms.Button BtnMayor;
        private System.Windows.Forms.Button BtnMultiplos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.GroupBox gboxMarcador;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnAtras;
    }
}

