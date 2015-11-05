namespace PTHOrder.Forms
{
    partial class frmChangepassword
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassOld = new DevExpress.XtraEditors.TextEdit();
            this.txtPassNew = new DevExpress.XtraEditors.TextEdit();
            this.txtPassConfirm = new DevExpress.XtraEditors.TextEdit();
            this.btnChangePass = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassOld.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassConfirm.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mật khẩu:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mật khẩu mới:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 83);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(85, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Nhập lại mật khẩu";
            // 
            // txtPassOld
            // 
            this.txtPassOld.Location = new System.Drawing.Point(114, 14);
            this.txtPassOld.Name = "txtPassOld";
            this.txtPassOld.Properties.UseSystemPasswordChar = true;
            this.txtPassOld.Size = new System.Drawing.Size(159, 20);
            this.txtPassOld.TabIndex = 0;
            // 
            // txtPassNew
            // 
            this.txtPassNew.Location = new System.Drawing.Point(114, 47);
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.Properties.UseSystemPasswordChar = true;
            this.txtPassNew.Size = new System.Drawing.Size(159, 20);
            this.txtPassNew.TabIndex = 1;
            // 
            // txtPassConfirm
            // 
            this.txtPassConfirm.Location = new System.Drawing.Point(114, 80);
            this.txtPassConfirm.Name = "txtPassConfirm";
            this.txtPassConfirm.Properties.UseSystemPasswordChar = true;
            this.txtPassConfirm.Size = new System.Drawing.Size(159, 20);
            this.txtPassConfirm.TabIndex = 2;
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(198, 117);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(75, 23);
            this.btnChangePass.TabIndex = 3;
            this.btnChangePass.Text = "Xác nhận";
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // frmChangepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 150);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.txtPassConfirm);
            this.Controls.Add(this.txtPassNew);
            this.Controls.Add(this.txtPassOld);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmChangepassword";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.txtPassOld.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassConfirm.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPassOld;
        private DevExpress.XtraEditors.TextEdit txtPassNew;
        private DevExpress.XtraEditors.TextEdit txtPassConfirm;
        private DevExpress.XtraEditors.SimpleButton btnChangePass;
    }
}