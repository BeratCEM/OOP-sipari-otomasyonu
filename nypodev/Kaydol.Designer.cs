namespace nypodev
{
    partial class Kaydol
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mstrad = new System.Windows.Forms.TextBox();
            this.mstrsoy = new System.Windows.Forms.TextBox();
            this.kllanad = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.KaydolBtn = new System.Windows.Forms.Button();
            this.AnaSyfBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(619, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(619, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müşteri Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(619, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(619, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre:";
            // 
            // mstrad
            // 
            this.mstrad.Location = new System.Drawing.Point(764, 237);
            this.mstrad.Name = "mstrad";
            this.mstrad.Size = new System.Drawing.Size(100, 20);
            this.mstrad.TabIndex = 4;
            // 
            // mstrsoy
            // 
            this.mstrsoy.Location = new System.Drawing.Point(764, 292);
            this.mstrsoy.Name = "mstrsoy";
            this.mstrsoy.Size = new System.Drawing.Size(100, 20);
            this.mstrsoy.TabIndex = 5;
            // 
            // kllanad
            // 
            this.kllanad.Location = new System.Drawing.Point(764, 350);
            this.kllanad.Name = "kllanad";
            this.kllanad.Size = new System.Drawing.Size(100, 20);
            this.kllanad.TabIndex = 6;
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(764, 412);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(100, 20);
            this.sifre.TabIndex = 6;
            // 
            // KaydolBtn
            // 
            this.KaydolBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KaydolBtn.Location = new System.Drawing.Point(623, 485);
            this.KaydolBtn.Name = "KaydolBtn";
            this.KaydolBtn.Size = new System.Drawing.Size(241, 32);
            this.KaydolBtn.TabIndex = 7;
            this.KaydolBtn.Text = "Kaydol";
            this.KaydolBtn.UseVisualStyleBackColor = true;
            this.KaydolBtn.Click += new System.EventHandler(this.KaydolBtn_Click);
            // 
            // AnaSyfBtn
            // 
            this.AnaSyfBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnaSyfBtn.Location = new System.Drawing.Point(623, 538);
            this.AnaSyfBtn.Name = "AnaSyfBtn";
            this.AnaSyfBtn.Size = new System.Drawing.Size(241, 33);
            this.AnaSyfBtn.TabIndex = 8;
            this.AnaSyfBtn.Text = "Ana Sayfa";
            this.AnaSyfBtn.UseVisualStyleBackColor = true;
            this.AnaSyfBtn.Click += new System.EventHandler(this.AnaSyfBtn_Click);
            // 
            // Kaydol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.AnaSyfBtn);
            this.Controls.Add(this.KaydolBtn);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kllanad);
            this.Controls.Add(this.mstrsoy);
            this.Controls.Add(this.mstrad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kaydol";
            this.Text = "Kaydol";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mstrad;
        private System.Windows.Forms.TextBox mstrsoy;
        private System.Windows.Forms.TextBox kllanad;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Button KaydolBtn;
        private System.Windows.Forms.Button AnaSyfBtn;
    }
}