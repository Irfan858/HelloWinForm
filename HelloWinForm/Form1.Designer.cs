namespace HelloWinForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.btn_sapa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_umur = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello World C# With WinForm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masukan Nama Anda";
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(12, 103);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(296, 23);
            this.tb_nama.TabIndex = 2;
            // 
            // btn_sapa
            // 
            this.btn_sapa.Location = new System.Drawing.Point(12, 224);
            this.btn_sapa.Name = "btn_sapa";
            this.btn_sapa.Size = new System.Drawing.Size(75, 23);
            this.btn_sapa.TabIndex = 3;
            this.btn_sapa.Text = "Sapa";
            this.btn_sapa.UseVisualStyleBackColor = true;
            this.btn_sapa.Click += new System.EventHandler(this.btn_sapa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Masukkan Umur Anda";
            // 
            // tb_umur
            // 
            this.tb_umur.Location = new System.Drawing.Point(11, 170);
            this.tb_umur.Name = "tb_umur";
            this.tb_umur.Size = new System.Drawing.Size(297, 23);
            this.tb_umur.TabIndex = 5;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(114, 224);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Bersihkan";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.tb_umur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_sapa);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_nama;
        private Button btn_sapa;
        private Label label3;
        private TextBox tb_umur;
        private Button btn_clear;
    }
}