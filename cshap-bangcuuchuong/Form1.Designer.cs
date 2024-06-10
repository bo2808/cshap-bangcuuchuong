namespace cshap_bangcuuchuong
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
            this.txtso = new System.Windows.Forms.TextBox();
            this.btnxem = new System.Windows.Forms.Button();
            this.lsbKetqua = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtso
            // 
            this.txtso.Location = new System.Drawing.Point(118, 122);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(137, 20);
            this.txtso.TabIndex = 0;
            // 
            // btnxem
            // 
            this.btnxem.Location = new System.Drawing.Point(406, 119);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(75, 23);
            this.btnxem.TabIndex = 1;
            this.btnxem.Text = "Xem";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.button1_Click);
            // 
            // lsbKetqua
            // 
            this.lsbKetqua.FormattingEnabled = true;
            this.lsbKetqua.Location = new System.Drawing.Point(117, 206);
            this.lsbKetqua.Name = "lsbKetqua";
            this.lsbKetqua.Size = new System.Drawing.Size(364, 95);
            this.lsbKetqua.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bảng Cửu Chương";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bạn muốn xem cửu chương mấy ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbKetqua);
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.txtso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtso;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.ListBox lsbKetqua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

