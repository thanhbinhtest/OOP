namespace StudentManagament.HandleClass
{
    partial class AddPostgraduateClassForm
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
            btnAdd = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            txtEndDate = new System.Windows.Forms.DateTimePicker();
            label4 = new System.Windows.Forms.Label();
            txtStartDate = new System.Windows.Forms.DateTimePicker();
            label3 = new System.Windows.Forms.Label();
            cbTeacher = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            cbCourse = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtNumOfStudents = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // txtTime
            // 
            txtTime.Location = new System.Drawing.Point(187, 125);
            txtTime.Name = "txtTime";
            txtTime.Size = new System.Drawing.Size(215, 23);
            txtTime.TabIndex = 28;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(478, 176);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(137, 50);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(187, 176);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(137, 50);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(59, 131);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(106, 15);
            label5.TabIndex = 24;
            label5.Text = "Thời gian nộp luận";
            // 
            // txtEndDate
            // 
            txtEndDate.Location = new System.Drawing.Point(539, 82);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new System.Drawing.Size(215, 23);
            txtEndDate.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(449, 88);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(81, 15);
            label4.TabIndex = 22;
            label4.Text = "Ngày kết thúc";
            // 
            // txtStartDate
            // 
            txtStartDate.Location = new System.Drawing.Point(187, 82);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new System.Drawing.Size(215, 23);
            txtStartDate.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(59, 88);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(78, 15);
            label3.TabIndex = 20;
            label3.Text = "Ngày bắt đầu";
            // 
            // cbTeacher
            // 
            cbTeacher.FormattingEnabled = true;
            cbTeacher.Location = new System.Drawing.Point(539, 41);
            cbTeacher.Name = "cbTeacher";
            cbTeacher.Size = new System.Drawing.Size(215, 23);
            cbTeacher.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(450, 44);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 15);
            label2.TabIndex = 18;
            label2.Text = "Tên giảng viên";
            // 
            // cbCourse
            // 
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new System.Drawing.Point(187, 41);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new System.Drawing.Size(215, 23);
            cbCourse.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(59, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 15);
            label1.TabIndex = 16;
            label1.Text = "Tên môn học";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(427, 133);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(104, 15);
            label6.TabIndex = 29;
            label6.Text = "Số lượng sinh viên";
            // 
            // txtNumOfStudents
            // 
            txtNumOfStudents.Location = new System.Drawing.Point(539, 128);
            txtNumOfStudents.Name = "txtNumOfStudents";
            txtNumOfStudents.Size = new System.Drawing.Size(215, 23);
            txtNumOfStudents.TabIndex = 30;
            // 
            // AddPostgraduateClassForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(783, 245);
            Controls.Add(txtNumOfStudents);
            Controls.Add(label6);
            Controls.Add(txtTime);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
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
            Name = "AddPostgraduateClassForm";
            Text = "Thêm lớp học sau đại học";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtTime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtEndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTeacher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumOfStudents;
    }
}