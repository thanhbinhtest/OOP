namespace StudentManagament.HandleTeacher
{
    partial class UpdateInfoTeacherForm
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
            btnCancel = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtPhone = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(212, 203);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(120, 42);
            btnCancel.TabIndex = 57;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(49, 203);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(120, 42);
            btnUpdate.TabIndex = 56;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(29, 134);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 15);
            label1.TabIndex = 55;
            label1.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(90, 131);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(262, 23);
            txtPassword.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(27, 83);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(27, 15);
            label6.TabIndex = 53;
            label6.Text = "SĐT";
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(88, 80);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(262, 23);
            txtPhone.TabIndex = 52;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(88, 28);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(262, 23);
            txtAddress.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(27, 31);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(43, 15);
            label5.TabIndex = 50;
            label5.Text = "Địa chỉ";
            // 
            // UpdateInfoTeacherForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(375, 268);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(label6);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Name = "UpdateInfoTeacherForm";
            Text = "Cập nhật thông tin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
    }
}