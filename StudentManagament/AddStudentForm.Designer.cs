namespace StudentManagament
{
    partial class AddStudentForm
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtCCCD = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtBirthday = new System.Windows.Forms.DateTimePicker();
            label5 = new System.Windows.Forms.Label();
            txtAddress = new System.Windows.Forms.TextBox();
            txtPhone = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            txtDayAdd = new System.Windows.Forms.DateTimePicker();
            txtMajor = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            btnMen = new System.Windows.Forms.RadioButton();
            btnWoman = new System.Windows.Forms.RadioButton();
            cbType = new System.Windows.Forms.ComboBox();
            btnAdd = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            checkReg = new System.Windows.Forms.CheckBox();
            checkPost = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(29, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "CCCD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(29, 180);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(29, 137);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(29, 90);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Họ và tên";
            label4.Click += label4_Click;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new System.Drawing.Point(93, 30);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new System.Drawing.Size(262, 23);
            txtCCCD.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(93, 82);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(262, 23);
            txtName.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(93, 172);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(262, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtBirthday
            // 
            txtBirthday.Location = new System.Drawing.Point(93, 129);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.Size = new System.Drawing.Size(262, 23);
            txtBirthday.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(433, 33);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(43, 15);
            label5.TabIndex = 9;
            label5.Text = "Địa chỉ";
            label5.Click += label5_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(494, 30);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(262, 23);
            txtAddress.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(494, 82);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(262, 23);
            txtPhone.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(433, 85);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(27, 15);
            label6.TabIndex = 12;
            label6.Text = "SĐT";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(388, 137);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(88, 15);
            label7.TabIndex = 13;
            label7.Text = "Ngày nhập học";
            // 
            // txtDayAdd
            // 
            txtDayAdd.Location = new System.Drawing.Point(494, 131);
            txtDayAdd.Name = "txtDayAdd";
            txtDayAdd.Size = new System.Drawing.Size(262, 23);
            txtDayAdd.TabIndex = 14;
            // 
            // txtMajor
            // 
            txtMajor.Location = new System.Drawing.Point(494, 172);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new System.Drawing.Size(262, 23);
            txtMajor.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(430, 180);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(43, 15);
            label8.TabIndex = 15;
            label8.Text = "Ngành";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(32, 219);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(52, 15);
            label9.TabIndex = 17;
            label9.Text = "Giới tính";
            // 
            // btnMen
            // 
            btnMen.AutoSize = true;
            btnMen.Location = new System.Drawing.Point(145, 215);
            btnMen.Name = "btnMen";
            btnMen.Size = new System.Drawing.Size(51, 19);
            btnMen.TabIndex = 18;
            btnMen.TabStop = true;
            btnMen.Text = "Nam";
            btnMen.UseVisualStyleBackColor = true;
            btnMen.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // btnWoman
            // 
            btnWoman.AutoSize = true;
            btnWoman.Location = new System.Drawing.Point(224, 215);
            btnWoman.Name = "btnWoman";
            btnWoman.Size = new System.Drawing.Size(41, 19);
            btnWoman.TabIndex = 19;
            btnWoman.TabStop = true;
            btnWoman.Text = "Nữ";
            btnWoman.UseVisualStyleBackColor = true;
            btnWoman.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new System.Drawing.Point(494, 255);
            cbType.Name = "cbType";
            cbType.Size = new System.Drawing.Size(263, 23);
            cbType.TabIndex = 22;
            cbType.SelectedIndexChanged += cbType_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(148, 304);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(154, 45);
            btnAdd.TabIndex = 23;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(494, 304);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(154, 45);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // checkReg
            // 
            checkReg.AutoSize = true;
            checkReg.Location = new System.Drawing.Point(494, 212);
            checkReg.Name = "checkReg";
            checkReg.Size = new System.Drawing.Size(97, 19);
            checkReg.TabIndex = 25;
            checkReg.Text = "SV Chính quy";
            checkReg.UseVisualStyleBackColor = true;
            checkReg.CheckedChanged += checkReg_CheckedChanged;
            // 
            // checkPost
            // 
            checkPost.AutoSize = true;
            checkPost.Location = new System.Drawing.Point(654, 212);
            checkPost.Name = "checkPost";
            checkPost.Size = new System.Drawing.Size(103, 19);
            checkPost.TabIndex = 26;
            checkPost.Text = "SV Sau đại học";
            checkPost.UseVisualStyleBackColor = true;
            checkPost.CheckedChanged += checkPost_CheckedChanged;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 365);
            Controls.Add(checkPost);
            Controls.Add(checkReg);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(cbType);
            Controls.Add(btnWoman);
            Controls.Add(btnMen);
            Controls.Add(label9);
            Controls.Add(txtMajor);
            Controls.Add(label8);
            Controls.Add(txtDayAdd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(txtBirthday);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtCCCD);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Name = "AddStudentForm";
            Text = "Thêm sinh viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker txtBirthday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtDayAdd;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton btnMen;
        private System.Windows.Forms.RadioButton btnWoman;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox checkReg;
        private System.Windows.Forms.CheckBox checkPost;
    }
}