﻿namespace PABD_Final
{
    partial class Menu_Utama
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
            this.btnMenuResto = new System.Windows.Forms.Button();
            this.btnSuplier = new System.Windows.Forms.Button();
            this.btnPembeli = new System.Windows.Forms.Button();
            this.btnKasir = new System.Windows.Forms.Button();
            this.btnKoki = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuResto
            // 
            this.btnMenuResto.Location = new System.Drawing.Point(647, 179);
            this.btnMenuResto.Name = "btnMenuResto";
            this.btnMenuResto.Size = new System.Drawing.Size(105, 93);
            this.btnMenuResto.TabIndex = 9;
            this.btnMenuResto.Text = "Menu Resto";
            this.btnMenuResto.UseVisualStyleBackColor = true;
            this.btnMenuResto.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSuplier
            // 
            this.btnSuplier.Location = new System.Drawing.Point(486, 179);
            this.btnSuplier.Name = "btnSuplier";
            this.btnSuplier.Size = new System.Drawing.Size(105, 93);
            this.btnSuplier.TabIndex = 8;
            this.btnSuplier.Text = "Suplier";
            this.btnSuplier.UseVisualStyleBackColor = true;
            this.btnSuplier.Click += new System.EventHandler(this.btnSuplier_Click);
            // 
            // btnPembeli
            // 
            this.btnPembeli.Location = new System.Drawing.Point(340, 179);
            this.btnPembeli.Name = "btnPembeli";
            this.btnPembeli.Size = new System.Drawing.Size(105, 93);
            this.btnPembeli.TabIndex = 7;
            this.btnPembeli.Text = "Pembeli";
            this.btnPembeli.UseVisualStyleBackColor = true;
            this.btnPembeli.Click += new System.EventHandler(this.btnPembeli_Click);
            // 
            // btnKasir
            // 
            this.btnKasir.Location = new System.Drawing.Point(198, 179);
            this.btnKasir.Name = "btnKasir";
            this.btnKasir.Size = new System.Drawing.Size(105, 93);
            this.btnKasir.TabIndex = 6;
            this.btnKasir.Text = "Kasir";
            this.btnKasir.UseVisualStyleBackColor = true;
            this.btnKasir.Click += new System.EventHandler(this.btnKasir_Click);
            // 
            // btnKoki
            // 
            this.btnKoki.Location = new System.Drawing.Point(48, 179);
            this.btnKoki.Name = "btnKoki";
            this.btnKoki.Size = new System.Drawing.Size(105, 93);
            this.btnKoki.TabIndex = 5;
            this.btnKoki.Text = "Koki";
            this.btnKoki.UseVisualStyleBackColor = true;
            this.btnKoki.Click += new System.EventHandler(this.btnKoki_Click);
            // 
            // Menu_Utama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenuResto);
            this.Controls.Add(this.btnSuplier);
            this.Controls.Add(this.btnPembeli);
            this.Controls.Add(this.btnKasir);
            this.Controls.Add(this.btnKoki);
            this.Name = "Menu_Utama";
            this.Text = "Menu_Utama";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuResto;
        private System.Windows.Forms.Button btnSuplier;
        private System.Windows.Forms.Button btnPembeli;
        private System.Windows.Forms.Button btnKasir;
        private System.Windows.Forms.Button btnKoki;
    }
}