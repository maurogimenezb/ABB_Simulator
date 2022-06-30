
namespace Arbol_Binario
{
    partial class ErrorForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorForm2));
            this.GBSuma = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.GBSuma.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBSuma
            // 
            this.GBSuma.BackColor = System.Drawing.Color.Transparent;
            this.GBSuma.Controls.Add(this.label1);
            this.GBSuma.Controls.Add(this.BtnOk);
            this.GBSuma.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GBSuma.ForeColor = System.Drawing.Color.SeaGreen;
            this.GBSuma.Location = new System.Drawing.Point(4, 3);
            this.GBSuma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBSuma.Name = "GBSuma";
            this.GBSuma.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBSuma.Size = new System.Drawing.Size(393, 174);
            this.GBSuma.TabIndex = 156;
            this.GBSuma.TabStop = false;
            this.GBSuma.Text = "¡ERROR!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 28);
            this.label1.TabIndex = 154;
            this.label1.Text = "¡Ya existe nodo en el arbol!";
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
            // ErrorForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 180);
            this.Controls.Add(this.GBSuma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ErrorForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErrorForm2";
            this.GBSuma.ResumeLayout(false);
            this.GBSuma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBSuma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOk;
    }
}