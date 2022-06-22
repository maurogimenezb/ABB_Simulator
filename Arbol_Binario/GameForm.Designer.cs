
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
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TxtDato = new System.Windows.Forms.TextBox();
            this.TxtDato2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TextN = new System.Windows.Forms.TextBox();
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(62, 60);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(75, 23);
            this.BtnInsertar.TabIndex = 0;
            this.BtnInsertar.Text = "button1";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(62, 117);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 1;
            this.BtnEliminar.Text = "button2";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(62, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // TxtDato
            // 
            this.TxtDato.Location = new System.Drawing.Point(163, 61);
            this.TxtDato.Name = "TxtDato";
            this.TxtDato.Size = new System.Drawing.Size(100, 23);
            this.TxtDato.TabIndex = 3;
            // 
            // TxtDato2
            // 
            this.TxtDato2.Location = new System.Drawing.Point(163, 117);
            this.TxtDato2.Name = "TxtDato2";
            this.TxtDato2.Size = new System.Drawing.Size(100, 23);
            this.TxtDato2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(163, 202);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 5;
            // 
            // TextN
            // 
            this.TextN.Location = new System.Drawing.Point(655, 291);
            this.TextN.Name = "TextN";
            this.TextN.Size = new System.Drawing.Size(37, 23);
            this.TextN.TabIndex = 6;
            // 
            // TxtAltura
            // 
            this.TxtAltura.Location = new System.Drawing.Point(655, 230);
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.Size = new System.Drawing.Size(37, 23);
            this.TxtAltura.TabIndex = 7;
            this.TxtAltura.TextChanged += new System.EventHandler(this.TxtAltura_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtAltura);
            this.Controls.Add(this.TextN);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.TxtDato2);
            this.Controls.Add(this.TxtDato);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnInsertar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TxtDato;
        private System.Windows.Forms.TextBox TxtDato2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox TextN;
        private System.Windows.Forms.TextBox TxtAltura;
    }
}

