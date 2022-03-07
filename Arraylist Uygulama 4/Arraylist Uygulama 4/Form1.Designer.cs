namespace Arraylist_Uygulama_4
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
            this.btnSiraAl = new System.Windows.Forms.Button();
            this.btnSiraCikart = new System.Windows.Forms.Button();
            this.listeSiralar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSiraAl
            // 
            this.btnSiraAl.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSiraAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiraAl.Location = new System.Drawing.Point(41, 51);
            this.btnSiraAl.Name = "btnSiraAl";
            this.btnSiraAl.Size = new System.Drawing.Size(120, 96);
            this.btnSiraAl.TabIndex = 0;
            this.btnSiraAl.Text = "Sıra Al";
            this.btnSiraAl.UseVisualStyleBackColor = false;
            this.btnSiraAl.Click += new System.EventHandler(this.btnSıraAl_Click);
            // 
            // btnSiraCikart
            // 
            this.btnSiraCikart.BackColor = System.Drawing.Color.Brown;
            this.btnSiraCikart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiraCikart.Location = new System.Drawing.Point(427, 51);
            this.btnSiraCikart.Name = "btnSiraCikart";
            this.btnSiraCikart.Size = new System.Drawing.Size(120, 96);
            this.btnSiraCikart.TabIndex = 1;
            this.btnSiraCikart.Text = "Sıra Çıkart";
            this.btnSiraCikart.UseVisualStyleBackColor = false;
            this.btnSiraCikart.Click += new System.EventHandler(this.btnSiraCikart_Click);
            // 
            // listeSiralar
            // 
            this.listeSiralar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listeSiralar.FormattingEnabled = true;
            this.listeSiralar.ItemHeight = 16;
            this.listeSiralar.Location = new System.Drawing.Point(211, 27);
            this.listeSiralar.Name = "listeSiralar";
            this.listeSiralar.Size = new System.Drawing.Size(157, 180);
            this.listeSiralar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(600, 284);
            this.Controls.Add(this.listeSiralar);
            this.Controls.Add(this.btnSiraCikart);
            this.Controls.Add(this.btnSiraAl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSiraAl;
        private System.Windows.Forms.Button btnSiraCikart;
        private System.Windows.Forms.ListBox listeSiralar;
    }
}

