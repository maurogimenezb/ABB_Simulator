
namespace ABB_Final_LP2
{
    partial class Form1
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
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnInorden = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnPreorden = new System.Windows.Forms.Button();
            this.btnPosorden = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNodos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(45, 48);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(11, 62);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(28, 23);
            this.txtNumero.TabIndex = 1;
            // 
            // btnInorden
            // 
            this.btnInorden.Location = new System.Drawing.Point(18, 201);
            this.btnInorden.Name = "btnInorden";
            this.btnInorden.Size = new System.Drawing.Size(75, 23);
            this.btnInorden.TabIndex = 2;
            this.btnInorden.Text = "InOrden";
            this.btnInorden.UseVisualStyleBackColor = true;
            this.btnInorden.Click += new System.EventHandler(this.btnInorden_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(45, 77);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnPreorden
            // 
            this.btnPreorden.Location = new System.Drawing.Point(18, 230);
            this.btnPreorden.Name = "btnPreorden";
            this.btnPreorden.Size = new System.Drawing.Size(75, 23);
            this.btnPreorden.TabIndex = 4;
            this.btnPreorden.Text = "PreOrden";
            this.btnPreorden.UseVisualStyleBackColor = true;
            this.btnPreorden.Click += new System.EventHandler(this.btnPreorden_Click);
            // 
            // btnPosorden
            // 
            this.btnPosorden.Location = new System.Drawing.Point(18, 259);
            this.btnPosorden.Name = "btnPosorden";
            this.btnPosorden.Size = new System.Drawing.Size(75, 23);
            this.btnPosorden.TabIndex = 5;
            this.btnPosorden.Text = "PostOrden";
            this.btnPosorden.UseVisualStyleBackColor = true;
            this.btnPosorden.Click += new System.EventHandler(this.btnPosorden_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Recorridos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Operaciones";
            // 
            // btnNodos
            // 
            this.btnNodos.Location = new System.Drawing.Point(13, 326);
            this.btnNodos.Name = "btnNodos";
            this.btnNodos.Size = new System.Drawing.Size(86, 23);
            this.btnNodos.TabIndex = 8;
            this.btnNodos.Text = "Cant. Nodos";
            this.btnNodos.UseVisualStyleBackColor = true;
            this.btnNodos.Click += new System.EventHandler(this.btnNodos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Datos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNodos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPosorden);
            this.Controls.Add(this.btnPreorden);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInorden);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnInsertar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnInorden;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnPreorden;
        private System.Windows.Forms.Button btnPosorden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNodos;
        private System.Windows.Forms.Label label3;
    }
}

