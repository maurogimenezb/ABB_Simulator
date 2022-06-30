
namespace Arbol_Binario
{
    partial class RecoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoForm));
            this.GBSuma = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblPreorden = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblInorden = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblPosorden = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.GBSuma.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBSuma
            // 
            this.GBSuma.BackColor = System.Drawing.Color.Transparent;
            this.GBSuma.Controls.Add(this.label4);
            this.GBSuma.Controls.Add(this.LblPreorden);
            this.GBSuma.Controls.Add(this.label2);
            this.GBSuma.Controls.Add(this.LblInorden);
            this.GBSuma.Controls.Add(this.label1);
            this.GBSuma.Controls.Add(this.LblPosorden);
            this.GBSuma.Controls.Add(this.BtnOk);
            this.GBSuma.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GBSuma.ForeColor = System.Drawing.Color.SeaGreen;
            this.GBSuma.Location = new System.Drawing.Point(4, 3);
            this.GBSuma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBSuma.Name = "GBSuma";
            this.GBSuma.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBSuma.Size = new System.Drawing.Size(393, 174);
            this.GBSuma.TabIndex = 157;
            this.GBSuma.TabStop = false;
            this.GBSuma.Text = "Recorrido";
            this.GBSuma.Enter += new System.EventHandler(this.GBSuma_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 23);
            this.label4.TabIndex = 158;
            this.label4.Text = "Recorrido en PreOrden:";
            // 
            // LblPreorden
            // 
            this.LblPreorden.AutoSize = true;
            this.LblPreorden.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPreorden.Location = new System.Drawing.Point(8, 145);
            this.LblPreorden.Name = "LblPreorden";
            this.LblPreorden.Size = new System.Drawing.Size(24, 25);
            this.LblPreorden.TabIndex = 157;
            this.LblPreorden.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 23);
            this.label2.TabIndex = 156;
            this.label2.Text = "Recorrido en InOrden:";
            // 
            // LblInorden
            // 
            this.LblInorden.AutoSize = true;
            this.LblInorden.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblInorden.Location = new System.Drawing.Point(8, 97);
            this.LblInorden.Name = "LblInorden";
            this.LblInorden.Size = new System.Drawing.Size(24, 25);
            this.LblInorden.TabIndex = 155;
            this.LblInorden.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 23);
            this.label1.TabIndex = 154;
            this.label1.Text = "Recorrido en PosOrden:";
            // 
            // LblPosorden
            // 
            this.LblPosorden.AutoSize = true;
            this.LblPosorden.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPosorden.Location = new System.Drawing.Point(8, 49);
            this.LblPosorden.Name = "LblPosorden";
            this.LblPosorden.Size = new System.Drawing.Size(24, 25);
            this.LblPosorden.TabIndex = 153;
            this.LblPosorden.Text = "0";
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.Transparent;
            this.BtnOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnOk.BackgroundImage")));
            this.BtnOk.FlatAppearance.BorderSize = 0;
            this.BtnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.Location = new System.Drawing.Point(287, 137);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(100, 30);
            this.BtnOk.TabIndex = 152;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // RecoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 180);
            this.Controls.Add(this.GBSuma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecoForm";
            this.GBSuma.ResumeLayout(false);
            this.GBSuma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBSuma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblPreorden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblInorden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblPosorden;
        private System.Windows.Forms.Button BtnOk;
    }
}