namespace StudentManagament.HandleClass
{
    partial class UpdateRegularClassForm
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
            cbNumLessons = new System.Windows.Forms.ComboBox();
            txtClassTime = new System.Windows.Forms.DateTimePicker();
            btnCancel = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
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
            // cbNumLessons
            // 
            cbNumLessons.FormattingEnabled = true;
            cbNumLessons.Location = new System.Drawing.Point(541, 126);
            cbNumLessons.Name = "cbNumLessons";
            cbNumLessons.Size = new System.Drawing.Size(215, 23);
            cbNumLessons.TabIndex = 29;
            // 
            // txtClassTime
            // 
            txtClassTime.Location = new System.Drawing.Point(206, 126);
            txtClassTime.Name = "txtClassTime";
            txtClassTime.Size = new System.Drawing.Size(215, 23);
            txtClassTime.TabIndex = 28;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(518, 237);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(137, 50);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(189, 237);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(137, 50);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(452, 132);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(63, 15);
            label6.TabIndex = 25;
            label6.Text = "Số tiết học";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(61, 132);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(122, 15);
            label5.TabIndex = 24;
            label5.Text = "Thời gian bắt đầu học";
            // 
            // txtEndDate
            // 
            txtEndDate.Location = new System.Drawing.Point(541, 83);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new System.Drawing.Size(215, 23);
            txtEndDate.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(451, 89);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(81, 15);
            label4.TabIndex = 22;
            label4.Text = "Ngày kết thúc";
            // 
            // txtStartDate
            // 
            txtStartDate.Location = new System.Drawing.Point(206, 83);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new System.Drawing.Size(215, 23);
            txtStartDate.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(61, 89);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(78, 15);
            label3.TabIndex = 20;
            label3.Text = "Ngày bắt đầu";
            // 
            // cbTeacher
            // 
            cbTeacher.FormattingEnabled = true;
            cbTeacher.Location = new System.Drawing.Point(541, 42);
            cbTeacher.Name = "cbTeacher";
            cbTeacher.Size = new System.Drawing.Size(215, 23);
            cbTeacher.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(452, 45);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 15);
            label2.TabIndex = 18;
            label2.Text = "Tên giảng viên";
            // 
            // cbCourse
            // 
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new System.Drawing.Point(206, 42);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new System.Drawing.Size(215, 23);
            cbCourse.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(61, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 15);
            label1.TabIndex = 16;
            label1.Text = "Tên môn học";
            // 
            // txtNumOfStudents
            // 
            txtNumOfStudents.Location = new System.Drawing.Point(206, 176);
            txtNumOfStudents.Name = "txtNumOfStudents";
            txtNumOfStudents.Size = new System.Drawing.Size(215, 23);
            txtNumOfStudents.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(61, 179);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(104, 15);
            label7.TabIndex = 30;
            label7.Text = "Số lượng sinh viên";
            // 
            // UpdateRegularClassForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(822, 311);
            Controls.Add(txtNumOfStudents);
            Controls.Add(label7);
            Controls.Add(cbNumLessons);
            Controls.Add(txtClassTime);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(label6);
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
            Name = "UpdateRegularClassForm";
            Text = "Cập nhật lớp học chính quy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbNumLessons;
        private System.Windows.Forms.DateTimePicker txtClassTime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label6;
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