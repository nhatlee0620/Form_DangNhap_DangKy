namespace Z_Solution_CSDL_Bai76_DangNhap_DangKy
{
    partial class QuenMatKhau
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailDK_QMK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLayLaiMatKhau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Z_Solution_CSDL_Bai76_DangNhap_DangKy.Properties.Resources.icons8_contacts_300px;
            this.pictureBox1.Location = new System.Drawing.Point(115, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(34, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email đăng ký:";
            // 
            // txtEmailDK_QMK
            // 
            this.txtEmailDK_QMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailDK_QMK.Location = new System.Drawing.Point(180, 275);
            this.txtEmailDK_QMK.Name = "txtEmailDK_QMK";
            this.txtEmailDK_QMK.Size = new System.Drawing.Size(332, 30);
            this.txtEmailDK_QMK.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(175, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kết quả:";
            // 
            // btnLayLaiMatKhau
            // 
            this.btnLayLaiMatKhau.BackColor = System.Drawing.Color.Blue;
            this.btnLayLaiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayLaiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnLayLaiMatKhau.Location = new System.Drawing.Point(180, 375);
            this.btnLayLaiMatKhau.Name = "btnLayLaiMatKhau";
            this.btnLayLaiMatKhau.Size = new System.Drawing.Size(233, 35);
            this.btnLayLaiMatKhau.TabIndex = 3;
            this.btnLayLaiMatKhau.Text = "Lấy Lại Mật Khẩu";
            this.btnLayLaiMatKhau.UseVisualStyleBackColor = false;
            this.btnLayLaiMatKhau.Click += new System.EventHandler(this.btnLayLaiMatKhau_Click);
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 441);
            this.Controls.Add(this.btnLayLaiMatKhau);
            this.Controls.Add(this.txtEmailDK_QMK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên Mật Khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailDK_QMK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLayLaiMatKhau;
    }
}