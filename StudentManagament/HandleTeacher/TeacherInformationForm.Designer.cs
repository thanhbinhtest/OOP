namespace StudentManagament.HandleTeacher
{
    partial class TeacherInformationForm
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
            btnUpdate = new System.Windows.Forms.Button();
            btnUpdateScore = new System.Windows.Forms.Button();
            dataClass = new System.Windows.Forms.DataGridView();
            label11 = new System.Windows.Forms.Label();
            btnWoman = new System.Windows.Forms.RadioButton();
            btnMen = new System.Windows.Forms.RadioButton();
            label9 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtPhone = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtBirthday = new System.Windows.Forms.DateTimePicker();
            txtEmail = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtCCCD = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataClass).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(655, 216);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(136, 23);
            btnUpdate.TabIndex = 79;
            btnUpdate.Text = "Cập nhật thông tin";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnUpdateScore
            // 
            btnUpdateScore.Location = new System.Drawing.Point(513, 216);
            btnUpdateScore.Name = "btnUpdateScore";
            btnUpdateScore.Size = new System.Drawing.Size(136, 23);
            btnUpdateScore.TabIndex = 78;
            btnUpdateScore.Text = "Cập nhật bảng điểm ";
            btnUpdateScore.UseVisualStyleBackColor = true;
            btnUpdateScore.Click += btnUpdateScore_Click;
            // 
            // dataClass
            // 
            dataClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataClass.Location = new System.Drawing.Point(2, 251);
            dataClass.Name = "dataClass";
            dataClass.RowTemplate.Height = 25;
            dataClass.Size = new System.Drawing.Size(807, 393);
            dataClass.TabIndex = 77;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(12, 224);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(85, 15);
            label11.TabIndex = 76;
            label11.Text = "Bảng môn học";
            label11.Click += label11_Click;
            // 
            // btnWoman
            // 
            btnWoman.AutoSize = true;
            btnWoman.Location = new System.Drawing.Point(257, 164);
            btnWoman.Name = "btnWoman";
            btnWoman.Size = new System.Drawing.Size(41, 19);
            btnWoman.TabIndex = 75;
            btnWoman.TabStop = true;
            btnWoman.Text = "Nữ";
            btnWoman.UseVisualStyleBackColor = true;
            // 
            // btnMen
            // 
            btnMen.AutoSize = true;
            btnMen.Location = new System.Drawing.Point(148, 164);
            btnMen.Name = "btnMen";
            btnMen.Size = new System.Drawing.Size(51, 19);
            btnMen.TabIndex = 74;
            btnMen.TabStop = true;
            btnMen.Text = "Nam";
            btnMen.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(42, 166);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(52, 15);
            label9.TabIndex = 73;
            label9.Text = "Giới tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(446, 73);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(27, 15);
            label6.TabIndex = 68;
            label6.Text = "SĐT";
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(507, 70);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(262, 23);
            txtPhone.TabIndex = 67;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(507, 18);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(262, 23);
            txtAddress.TabIndex = 66;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(446, 21);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(43, 15);
            label5.TabIndex = 65;
            label5.Text = "Địa chỉ";
            // 
            // txtBirthday
            // 
            txtBirthday.Location = new System.Drawing.Point(106, 120);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.Size = new System.Drawing.Size(262, 23);
            txtBirthday.TabIndex = 64;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(507, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(262, 23);
            txtEmail.TabIndex = 63;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(106, 70);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(262, 23);
            txtName.TabIndex = 62;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new System.Drawing.Point(106, 18);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new System.Drawing.Size(262, 23);
            txtCCCD.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(42, 78);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(58, 15);
            label4.TabIndex = 60;
            label4.Text = "Họ và tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(42, 123);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 15);
            label3.TabIndex = 59;
            label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(446, 123);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(36, 15);
            label2.TabIndex = 58;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(42, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 57;
            label1.Text = "CCCD";
            // 
            // TeacherInformationForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(810, 645);
            Controls.Add(btnUpdate);
            Controls.Add(btnUpdateScore);
            Controls.Add(dataClass);
            Controls.Add(label11);
            Controls.Add(btnWoman);
            Controls.Add(btnMen);
            Controls.Add(label9);
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
            Name = "TeacherInformationForm";
            Text = "Thông tin giảng viên";
            Load += TeacherInformationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataClass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUpdateScore;
        private System.Windows.Forms.DataGridView dataClass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton btnWoman;
        private System.Windows.Forms.RadioButton btnMen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtBirthday;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}