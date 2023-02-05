namespace bilgi_yarismasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtb_Soru = new System.Windows.Forms.RichTextBox();
            this.btn_A = new System.Windows.Forms.Button();
            this.btn_B = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_D = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_SoruNo = new System.Windows.Forms.Label();
            this.lbl_Dogru = new System.Windows.Forms.Label();
            this.lbl_Yanlis = new System.Windows.Forms.Label();
            this.btn_Sonraki = new System.Windows.Forms.Button();
            this.pct_Yesil = new System.Windows.Forms.PictureBox();
            this.pct_Kirmizi = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Yesil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Kirmizi)).BeginInit();
            this.SuspendLayout();
            // 
            // rtb_Soru
            // 
            this.rtb_Soru.Location = new System.Drawing.Point(3, 2);
            this.rtb_Soru.Name = "rtb_Soru";
            this.rtb_Soru.Size = new System.Drawing.Size(428, 169);
            this.rtb_Soru.TabIndex = 0;
            this.rtb_Soru.Text = "";
            // 
            // btn_A
            // 
            this.btn_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_A.Location = new System.Drawing.Point(3, 178);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(204, 40);
            this.btn_A.TabIndex = 1;
            this.btn_A.Text = "A";
            this.btn_A.UseVisualStyleBackColor = false;
            this.btn_A.Click += new System.EventHandler(this.btn_A_Click);
            // 
            // btn_B
            // 
            this.btn_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_B.Location = new System.Drawing.Point(227, 178);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(204, 40);
            this.btn_B.TabIndex = 1;
            this.btn_B.Text = "B";
            this.btn_B.UseVisualStyleBackColor = false;
            this.btn_B.Click += new System.EventHandler(this.btn_B_Click);
            // 
            // btn_C
            // 
            this.btn_C.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_C.Location = new System.Drawing.Point(3, 224);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(204, 40);
            this.btn_C.TabIndex = 1;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = false;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_D
            // 
            this.btn_D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_D.Location = new System.Drawing.Point(227, 224);
            this.btn_D.Name = "btn_D";
            this.btn_D.Size = new System.Drawing.Size(204, 40);
            this.btn_D.TabIndex = 1;
            this.btn_D.Text = "D";
            this.btn_D.UseVisualStyleBackColor = false;
            this.btn_D.Click += new System.EventHandler(this.btn_D_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Soru No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doğru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yanlış:";
            // 
            // lbl_SoruNo
            // 
            this.lbl_SoruNo.AutoSize = true;
            this.lbl_SoruNo.Location = new System.Drawing.Point(572, 34);
            this.lbl_SoruNo.Name = "lbl_SoruNo";
            this.lbl_SoruNo.Size = new System.Drawing.Size(20, 23);
            this.lbl_SoruNo.TabIndex = 2;
            this.lbl_SoruNo.Text = "0";
            // 
            // lbl_Dogru
            // 
            this.lbl_Dogru.AutoSize = true;
            this.lbl_Dogru.Location = new System.Drawing.Point(572, 69);
            this.lbl_Dogru.Name = "lbl_Dogru";
            this.lbl_Dogru.Size = new System.Drawing.Size(20, 23);
            this.lbl_Dogru.TabIndex = 2;
            this.lbl_Dogru.Text = "0";
            // 
            // lbl_Yanlis
            // 
            this.lbl_Yanlis.AutoSize = true;
            this.lbl_Yanlis.Location = new System.Drawing.Point(572, 103);
            this.lbl_Yanlis.Name = "lbl_Yanlis";
            this.lbl_Yanlis.Size = new System.Drawing.Size(20, 23);
            this.lbl_Yanlis.TabIndex = 2;
            this.lbl_Yanlis.Text = "0";
            // 
            // btn_Sonraki
            // 
            this.btn_Sonraki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Sonraki.Location = new System.Drawing.Point(460, 129);
            this.btn_Sonraki.Name = "btn_Sonraki";
            this.btn_Sonraki.Size = new System.Drawing.Size(204, 40);
            this.btn_Sonraki.TabIndex = 1;
            this.btn_Sonraki.Text = "Sonraki";
            this.btn_Sonraki.UseVisualStyleBackColor = false;
            this.btn_Sonraki.Click += new System.EventHandler(this.btn_Sonraki_Click);
            // 
            // pct_Yesil
            // 
            this.pct_Yesil.Image = ((System.Drawing.Image)(resources.GetObject("pct_Yesil.Image")));
            this.pct_Yesil.Location = new System.Drawing.Point(460, 178);
            this.pct_Yesil.Name = "pct_Yesil";
            this.pct_Yesil.Size = new System.Drawing.Size(111, 86);
            this.pct_Yesil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_Yesil.TabIndex = 3;
            this.pct_Yesil.TabStop = false;
            this.pct_Yesil.Visible = false;
            // 
            // pct_Kirmizi
            // 
            this.pct_Kirmizi.Image = ((System.Drawing.Image)(resources.GetObject("pct_Kirmizi.Image")));
            this.pct_Kirmizi.Location = new System.Drawing.Point(577, 178);
            this.pct_Kirmizi.Name = "pct_Kirmizi";
            this.pct_Kirmizi.Size = new System.Drawing.Size(111, 86);
            this.pct_Kirmizi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_Kirmizi.TabIndex = 3;
            this.pct_Kirmizi.TabStop = false;
            this.pct_Kirmizi.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 281);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pct_Kirmizi);
            this.Controls.Add(this.pct_Yesil);
            this.Controls.Add(this.lbl_Yanlis);
            this.Controls.Add(this.lbl_Dogru);
            this.Controls.Add(this.lbl_SoruNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Sonraki);
            this.Controls.Add(this.btn_B);
            this.Controls.Add(this.btn_D);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_A);
            this.Controls.Add(this.rtb_Soru);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Bilgi Yarışması";
            ((System.ComponentModel.ISupportInitialize)(this.pct_Yesil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Kirmizi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Soru;
        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_D;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_SoruNo;
        private System.Windows.Forms.Label lbl_Dogru;
        private System.Windows.Forms.Label lbl_Yanlis;
        private System.Windows.Forms.Button btn_Sonraki;
        private System.Windows.Forms.PictureBox pct_Yesil;
        private System.Windows.Forms.PictureBox pct_Kirmizi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

