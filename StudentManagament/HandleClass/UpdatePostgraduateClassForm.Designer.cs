namespace StudentManagament.HandleClass
{
    partial class UpdatePostgraduateClassForm
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
            txtTime = new System.Windows.Forms.DateTimePicker();
            btnCancel = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            txtEndDate = new System.Windows.Forms.DateTimePicker();
            label4 = new System.Windows.Forms.Label();
            txtStartDate = new System.Windows.Forms.DateTimePicker();
            label3 = new System.Windows.Forms.Label();
            cbTeacher = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            cbCourse = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            txtNumOfStudents = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtTime
            // 
            txtTime.Location = new System.Drawing.Point(176, 125);
            txtTime.Name = "txtTime";
            txtTime.Size = new System.Drawing.Size(215, 23);
            txtTime.TabIndex = 40;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(467, 176);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(137, 50);
            btnCancel.TabIndex = 39;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(176, 176);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(137, 50);
            btnUpdate.TabIndex = 38;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(48, 131);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(106, 15);
            label5.TabIndex = 37;
            label5.Text = "Thời gian nộp luận";
            // 
            // txtEndDate
            // 
            txtEndDate.Location = new System.Drawing.Point(528, 82);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new System.Drawing.Size(215, 23);
            txtEndDate.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(438, 88);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(81, 15);
            label4.TabIndex = 35;
            label4.Text = "Ngày kết thúc";
            // 
            // txtStartDate
            // 
            txtStartDate.Location = new System.Drawing.Point(176, 82);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new System.Drawing.Size(215, 23);
            txtStartDate.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(48, 88);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(78, 15);
            label3.TabIndex = 33;
            label3.Text = "Ngày bắt đầu";
            // 
            // cbTeacher
            // 
            cbTeacher.FormattingEnabled = true;
            cbTeacher.Location = new System.Drawing.Point(528, 41);
            cbTeacher.Name = "cbTeacher";
            cbTeacher.Size = new System.Drawing.Size(215, 23);
            cbTeacher.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(439, 44);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 15);
            label2.TabIndex = 31;
            label2.Text = "Tên giảng viên";
            // 
            // cbCourse
            // 
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new System.Drawing.Point(176, 41);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new System.Drawing.Size(215, 23);
            cbCourse.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(48, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 15);
            label1.TabIndex = 29;
            label1.Text = "Tên môn học";
            // 
            // txtNumOfStudents
            // 
            txtNumOfStudents.Location = new System.Drawing.Point(528, 125);
            txtNumOfStudents.Name = "txtNumOfStudents";
            txtNumOfStudents.Size = new System.Drawing.Size(215, 23);
            txtNumOfStudents.TabIndex = 42;
            txtNumOfStudents.TextChanged += txtNumOfStudents_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(418, 128);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(104, 15);
            label7.TabIndex = 41;
            label7.Text = "Số lượng sinh viên";
            // 
            // UpdatePostgraduateClassForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(787, 243);
            Controls.Add(txtNumOfStudents);
            Controls.Add(label7);
            Controls.Add(txtTime);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(label5);
            Controls.Add(txtEndDate);
            Controls.Add(label4);
            Controls.Add(txtStartDate);
            Controls.Add(label3);
            Controls.Add(cbTeacher);
            Controls.Add(label2);
            Controls.Add(cbCourse);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Name = "UpdatePostgraduateClassForm";
            Text = "Cập nhật lớp học sau đại học";
            Load += UpdatePostgraduateClassForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtTime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtEndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTeacher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumOfStudents;
        private System.Windows.Forms.Label label7;
    }
}