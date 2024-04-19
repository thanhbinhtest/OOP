namespace StudentManagament
{
    partial class UpdateInfoStudent
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
            label6 = new System.Windows.Forms.Label();
            txtPhone = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            btnUpdate = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(28, 86);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(27, 15);
            label6.TabIndex = 44;
            label6.Text = "SĐT";
            //label6.Click += this.label6_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(89, 83);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(262, 23);
            txtPhone.TabIndex = 43;
            //txtPhone.TextChanged += this.txtPhone_TextChanged;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(89, 31);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(262, 23);
            txtAddress.TabIndex = 42;
            //txtAddress.TextChanged += this.txtAddress_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(28, 34);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(43, 15);
            label5.TabIndex = 41;
            label5.Text = "Địa chỉ";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(30, 137);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 15);
            label1.TabIndex = 46;
            label1.Text = "Mật khẩu";
            //label1.Click += this.label1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(91, 134);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(262, 23);
            txtPassword.TabIndex = 45;
            //txtPassword.TextChanged += this.txtPassword_TextChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(50, 206);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(120, 42);
            btnUpdate.TabIndex = 48;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(213, 206);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(120, 42);
            btnCancel.TabIndex = 49;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // UpdateInfoStudent
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(376, 275);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(label6);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Name = "UpdateInfoStudent";
            Text = "Cập nhật thông tin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
    }
}