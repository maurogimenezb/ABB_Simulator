﻿
namespace Arbol_Binario
{
    partial class AlturaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlturaForm));
            this.GBSuma = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblSuma = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.GBSuma.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBSuma
            // 
            this.GBSuma.BackColor = System.Drawing.Color.Transparent;
            this.GBSuma.Controls.Add(this.label1);
            this.GBSuma.Controls.Add(this.LblSuma);
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
            this.GBSuma.Text = "Altura";
            this.GBSuma.Enter += new System.EventHandler(this.GBSuma_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 154;
            this.label1.Text = "La altura del arbol es:";
            // 
            // LblSuma
            // 
            this.LblSuma.AutoSize = true;
            this.LblSuma.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblSuma.Location = new System.Drawing.Point(295, 76);
            this.LblSuma.Name = "LblSuma";
            this.LblSuma.Size = new System.Drawing.Size(24, 25);
            this.LblSuma.TabIndex = 153;
            this.LblSuma.Text = "0";
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
            // AlturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 180);
            this.Controls.Add(this.GBSuma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlturaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlturaForm";
            this.GBSuma.ResumeLayout(false);
            this.GBSuma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBSuma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblSuma;
        private System.Windows.Forms.Button BtnOk;
    }
}