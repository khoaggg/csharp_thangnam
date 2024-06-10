namespace csharp_thangnam
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.lsbDanhSach = new System.Windows.Forms.ListBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.lblketqua = new System.Windows.Forms.Label();
            this.lbtnam = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "tính can chi";
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(117, 181);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(120, 20);
            this.txtketqua.TabIndex = 4;
            // 
            // lsbDanhSach
            // 
            this.lsbDanhSach.FormattingEnabled = true;
            this.lsbDanhSach.Location = new System.Drawing.Point(296, 67);
            this.lsbDanhSach.Name = "lsbDanhSach";
            this.lsbDanhSach.Size = new System.Drawing.Size(452, 199);
            this.lsbDanhSach.TabIndex = 5;
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(117, 232);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 23);
            this.btntinh.TabIndex = 6;
            this.btntinh.Text = "tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(117, 92);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(120, 20);
            this.txtnam.TabIndex = 7;
            // 
            // lblketqua
            // 
            this.lblketqua.AutoSize = true;
            this.lblketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblketqua.Location = new System.Drawing.Point(12, 181);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(71, 24);
            this.lblketqua.TabIndex = 8;
            this.lblketqua.Text = "kết quả";
            // 
            // lbtnam
            // 
            this.lbtnam.AutoSize = true;
            this.lbtnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtnam.Location = new System.Drawing.Point(5, 87);
            this.lbtnam.Name = "lbtnam";
            this.lbtnam.Size = new System.Drawing.Size(47, 24);
            this.lbtnam.TabIndex = 9;
            this.lbtnam.Text = "năm";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(117, 56);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbtnam);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.lsbDanhSach);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.ListBox lsbDanhSach;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Label lblketqua;
        private System.Windows.Forms.Label lbtnam;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

