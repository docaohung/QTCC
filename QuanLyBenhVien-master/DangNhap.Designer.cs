namespace QTCC_QuanLyBenhVien
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPwd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.cbRemember = new System.Windows.Forms.CheckBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dxErrorProviderDangnhap = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProviderDangnhap)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(83, 32);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(127, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.EditValueChanged += new System.EventHandler(this.txtUsername_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Username:";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(83, 58);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(127, 20);
            this.txtPwd.TabIndex = 0;
            this.txtPwd.EditValueChanged += new System.EventHandler(this.txtPwd_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(83, 125);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(113, 32);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbRemember
            // 
            this.cbRemember.AutoSize = true;
            this.cbRemember.Location = new System.Drawing.Point(83, 85);
            this.cbRemember.Name = "cbRemember";
            this.cbRemember.Size = new System.Drawing.Size(127, 17);
            this.cbRemember.TabIndex = 3;
            this.cbRemember.Text = "Nhớ mật khẩu của tôi";
            this.cbRemember.UseVisualStyleBackColor = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cbRemember);
            this.groupControl1.Controls.Add(this.txtUsername);
            this.groupControl1.Controls.Add(this.btnLogin);
            this.groupControl1.Controls.Add(this.txtPwd);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(254, 177);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Đăng nhập";
            // 
            // dxErrorProviderDangnhap
            // 
            this.dxErrorProviderDangnhap.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 177);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Đăng nhập";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProviderDangnhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPwd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private System.Windows.Forms.CheckBox cbRemember;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProviderDangnhap;
    }
}