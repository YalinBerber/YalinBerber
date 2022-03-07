namespace ArraylistUygulama3
{
    partial class Form1
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
            this.btnAEkle = new System.Windows.Forms.Button();
            this.btnLEkle = new System.Windows.Forms.Button();
            this.btnATopla = new System.Windows.Forms.Button();
            this.btnLTopla = new System.Windows.Forms.Button();
            this.btnAYaz = new System.Windows.Forms.Button();
            this.btnLYaz = new System.Windows.Forms.Button();
            this.btnABul = new System.Windows.Forms.Button();
            this.btnLBul = new System.Windows.Forms.Button();
            this.listeA = new System.Windows.Forms.ListBox();
            this.lblAEkle = new System.Windows.Forms.Label();
            this.lblLEkle = new System.Windows.Forms.Label();
            this.lblATopla = new System.Windows.Forms.Label();
            this.lblLTopla = new System.Windows.Forms.Label();
            this.lblAYaz = new System.Windows.Forms.Label();
            this.lblLYaz = new System.Windows.Forms.Label();
            this.lblABul = new System.Windows.Forms.Label();
            this.lblLBul = new System.Windows.Forms.Label();
            this.listeL = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAEkle
            // 
            this.btnAEkle.BackColor = System.Drawing.Color.Silver;
            this.btnAEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAEkle.Location = new System.Drawing.Point(11, 47);
            this.btnAEkle.Name = "btnAEkle";
            this.btnAEkle.Size = new System.Drawing.Size(159, 36);
            this.btnAEkle.TabIndex = 0;
            this.btnAEkle.Text = "ArrayList Değer Ekle";
            this.btnAEkle.UseVisualStyleBackColor = false;
            this.btnAEkle.Click += new System.EventHandler(this.btnAEkle_Click);
            // 
            // btnLEkle
            // 
            this.btnLEkle.BackColor = System.Drawing.Color.Silver;
            this.btnLEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLEkle.Location = new System.Drawing.Point(11, 116);
            this.btnLEkle.Name = "btnLEkle";
            this.btnLEkle.Size = new System.Drawing.Size(159, 36);
            this.btnLEkle.TabIndex = 0;
            this.btnLEkle.Text = "List Değer Ekle";
            this.btnLEkle.UseVisualStyleBackColor = false;
            this.btnLEkle.Click += new System.EventHandler(this.btnLEkle_Click);
            // 
            // btnATopla
            // 
            this.btnATopla.BackColor = System.Drawing.Color.Silver;
            this.btnATopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnATopla.Location = new System.Drawing.Point(11, 182);
            this.btnATopla.Name = "btnATopla";
            this.btnATopla.Size = new System.Drawing.Size(159, 36);
            this.btnATopla.TabIndex = 0;
            this.btnATopla.Text = "ArrayList Değer Topla";
            this.btnATopla.UseVisualStyleBackColor = false;
            this.btnATopla.Click += new System.EventHandler(this.btnATopla_Click);
            // 
            // btnLTopla
            // 
            this.btnLTopla.BackColor = System.Drawing.Color.Silver;
            this.btnLTopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLTopla.Location = new System.Drawing.Point(11, 249);
            this.btnLTopla.Name = "btnLTopla";
            this.btnLTopla.Size = new System.Drawing.Size(159, 36);
            this.btnLTopla.TabIndex = 0;
            this.btnLTopla.Text = "List Değer Topla";
            this.btnLTopla.UseVisualStyleBackColor = false;
            this.btnLTopla.Click += new System.EventHandler(this.btnLTopla_Click);
            // 
            // btnAYaz
            // 
            this.btnAYaz.BackColor = System.Drawing.Color.Silver;
            this.btnAYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAYaz.Location = new System.Drawing.Point(244, 47);
            this.btnAYaz.Name = "btnAYaz";
            this.btnAYaz.Size = new System.Drawing.Size(159, 36);
            this.btnAYaz.TabIndex = 0;
            this.btnAYaz.Text = "Arraylist Değer Yaz";
            this.btnAYaz.UseVisualStyleBackColor = false;
            this.btnAYaz.Click += new System.EventHandler(this.btnAYaz_Click);
            // 
            // btnLYaz
            // 
            this.btnLYaz.BackColor = System.Drawing.Color.Silver;
            this.btnLYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLYaz.Location = new System.Drawing.Point(244, 116);
            this.btnLYaz.Name = "btnLYaz";
            this.btnLYaz.Size = new System.Drawing.Size(159, 36);
            this.btnLYaz.TabIndex = 0;
            this.btnLYaz.Text = "List Değer Yaz";
            this.btnLYaz.UseVisualStyleBackColor = false;
            this.btnLYaz.Click += new System.EventHandler(this.btnLYaz_Click);
            // 
            // btnABul
            // 
            this.btnABul.BackColor = System.Drawing.Color.Silver;
            this.btnABul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnABul.Location = new System.Drawing.Point(244, 182);
            this.btnABul.Name = "btnABul";
            this.btnABul.Size = new System.Drawing.Size(159, 36);
            this.btnABul.TabIndex = 0;
            this.btnABul.Text = "ArrayList Değer Bul";
            this.btnABul.UseVisualStyleBackColor = false;
            this.btnABul.Click += new System.EventHandler(this.btnABul_Click);
            // 
            // btnLBul
            // 
            this.btnLBul.BackColor = System.Drawing.Color.Silver;
            this.btnLBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLBul.Location = new System.Drawing.Point(244, 249);
            this.btnLBul.Name = "btnLBul";
            this.btnLBul.Size = new System.Drawing.Size(159, 36);
            this.btnLBul.TabIndex = 0;
            this.btnLBul.Text = "List Değer Bul";
            this.btnLBul.UseVisualStyleBackColor = false;
            this.btnLBul.Click += new System.EventHandler(this.btnLBul_Click);
            // 
            // listeA
            // 
            this.listeA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listeA.FormattingEnabled = true;
            this.listeA.Location = new System.Drawing.Point(473, 47);
            this.listeA.Name = "listeA";
            this.listeA.Size = new System.Drawing.Size(124, 212);
            this.listeA.TabIndex = 1;
            // 
            // lblAEkle
            // 
            this.lblAEkle.AutoSize = true;
            this.lblAEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAEkle.Location = new System.Drawing.Point(177, 47);
            this.lblAEkle.Name = "lblAEkle";
            this.lblAEkle.Size = new System.Drawing.Size(56, 17);
            this.lblAEkle.TabIndex = 2;
            this.lblAEkle.Text = "A EKLE";
            // 
            // lblLEkle
            // 
            this.lblLEkle.AutoSize = true;
            this.lblLEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLEkle.Location = new System.Drawing.Point(177, 116);
            this.lblLEkle.Name = "lblLEkle";
            this.lblLEkle.Size = new System.Drawing.Size(55, 17);
            this.lblLEkle.TabIndex = 2;
            this.lblLEkle.Text = "L EKLE";
            // 
            // lblATopla
            // 
            this.lblATopla.AutoSize = true;
            this.lblATopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblATopla.Location = new System.Drawing.Point(176, 182);
            this.lblATopla.Name = "lblATopla";
            this.lblATopla.Size = new System.Drawing.Size(67, 17);
            this.lblATopla.TabIndex = 2;
            this.lblATopla.Text = "A TOPLA";
            // 
            // lblLTopla
            // 
            this.lblLTopla.AutoSize = true;
            this.lblLTopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLTopla.Location = new System.Drawing.Point(177, 249);
            this.lblLTopla.Name = "lblLTopla";
            this.lblLTopla.Size = new System.Drawing.Size(66, 17);
            this.lblLTopla.TabIndex = 2;
            this.lblLTopla.Text = "L TOPLA";
            // 
            // lblAYaz
            // 
            this.lblAYaz.AutoSize = true;
            this.lblAYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAYaz.Location = new System.Drawing.Point(409, 47);
            this.lblAYaz.Name = "lblAYaz";
            this.lblAYaz.Size = new System.Drawing.Size(48, 17);
            this.lblAYaz.TabIndex = 2;
            this.lblAYaz.Text = "A YAZ";
            // 
            // lblLYaz
            // 
            this.lblLYaz.AutoSize = true;
            this.lblLYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLYaz.Location = new System.Drawing.Point(409, 116);
            this.lblLYaz.Name = "lblLYaz";
            this.lblLYaz.Size = new System.Drawing.Size(47, 17);
            this.lblLYaz.TabIndex = 2;
            this.lblLYaz.Text = "L YAZ";
            // 
            // lblABul
            // 
            this.lblABul.AutoSize = true;
            this.lblABul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblABul.Location = new System.Drawing.Point(408, 182);
            this.lblABul.Name = "lblABul";
            this.lblABul.Size = new System.Drawing.Size(48, 17);
            this.lblABul.TabIndex = 2;
            this.lblABul.Text = "A BUL";
            // 
            // lblLBul
            // 
            this.lblLBul.AutoSize = true;
            this.lblLBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLBul.Location = new System.Drawing.Point(409, 249);
            this.lblLBul.Name = "lblLBul";
            this.lblLBul.Size = new System.Drawing.Size(48, 17);
            this.lblLBul.TabIndex = 2;
            this.lblLBul.Text = "B BUL";
            // 
            // listeL
            // 
            this.listeL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listeL.FormattingEnabled = true;
            this.listeL.Location = new System.Drawing.Point(615, 47);
            this.listeL.Name = "listeL";
            this.listeL.Size = new System.Drawing.Size(124, 212);
            this.listeL.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(761, 318);
            this.Controls.Add(this.lblLBul);
            this.Controls.Add(this.lblLTopla);
            this.Controls.Add(this.lblABul);
            this.Controls.Add(this.lblATopla);
            this.Controls.Add(this.lblLYaz);
            this.Controls.Add(this.lblLEkle);
            this.Controls.Add(this.lblAYaz);
            this.Controls.Add(this.lblAEkle);
            this.Controls.Add(this.listeL);
            this.Controls.Add(this.listeA);
            this.Controls.Add(this.btnLBul);
            this.Controls.Add(this.btnLTopla);
            this.Controls.Add(this.btnABul);
            this.Controls.Add(this.btnATopla);
            this.Controls.Add(this.btnLYaz);
            this.Controls.Add(this.btnLEkle);
            this.Controls.Add(this.btnAYaz);
            this.Controls.Add(this.btnAEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAEkle;
        private System.Windows.Forms.Button btnLEkle;
        private System.Windows.Forms.Button btnATopla;
        private System.Windows.Forms.Button btnLTopla;
        private System.Windows.Forms.Button btnAYaz;
        private System.Windows.Forms.Button btnLYaz;
        private System.Windows.Forms.Button btnABul;
        private System.Windows.Forms.Button btnLBul;
        private System.Windows.Forms.ListBox listeA;
        private System.Windows.Forms.Label lblAEkle;
        private System.Windows.Forms.Label lblLEkle;
        private System.Windows.Forms.Label lblATopla;
        private System.Windows.Forms.Label lblLTopla;
        private System.Windows.Forms.Label lblAYaz;
        private System.Windows.Forms.Label lblLYaz;
        private System.Windows.Forms.Label lblABul;
        private System.Windows.Forms.Label lblLBul;
        private System.Windows.Forms.ListBox listeL;
    }
}

