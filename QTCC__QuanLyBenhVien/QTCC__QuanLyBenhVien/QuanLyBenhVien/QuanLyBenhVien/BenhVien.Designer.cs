namespace QuanLyBenhVien
{
    partial class BenhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BenhVien));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.abtnChiTiet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 436);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // abtnChiTiet
            // 
            this.abtnChiTiet.Location = new System.Drawing.Point(379, 351);
            this.abtnChiTiet.Name = "abtnChiTiet";
            this.abtnChiTiet.Size = new System.Drawing.Size(107, 30);
            this.abtnChiTiet.TabIndex = 2;
            this.abtnChiTiet.Text = "Chi Tiết";
            this.abtnChiTiet.UseVisualStyleBackColor = true;
            this.abtnChiTiet.Click += new System.EventHandler(this.abtnChiTiet_Click);
            // 
            // BenhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 436);
            this.Controls.Add(this.abtnChiTiet);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BenhVien";
            this.Text = "Bệnh Viện";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button abtnChiTiet;
    }
}