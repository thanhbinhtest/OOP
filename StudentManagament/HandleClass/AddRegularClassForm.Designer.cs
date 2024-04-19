namespace StudentManagament.HandleClass
{
    partial class AddRegularClassForm
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
            cbCourse = new System.Windows.Forms.ComboBox();
            cbTeacher = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtStartDate = new System.Windows.Forms.DateTimePicker();
            txtEndDate = new System.Windows.Forms.DateTimePicker();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            txtClassTime = new System.Windows.Forms.DateTimePicker();
            cbNumLessons = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            txtNumOfStudents = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(50, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên môn học";
            // 
            // cbCourse
            // 
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new System.Drawing.Point(195, 36);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new System.Drawing.Size(215, 23);
            cbCourse.TabIndex = 1;
            // 
            // cbTeacher
            // 
            cbTeacher.FormattingEnabled = true;
            cbTeacher.Location = new System.Drawing.Point(530, 36);
            cbTeacher.Name = "cbTeacher";
            cbTeacher.Size = new System.Drawing.Size(215, 23);
            cbTeacher.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(441, 39);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên giảng viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(50, 83);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(78, 15);
            label3.TabIndex = 4;
            label3.Text = "Ngày bắt đầu";
            // 
            // txtStartDate
            // 
            txtStartDate.Location = new System.Drawing.Point(195, 77);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new System.Drawing.Size(215, 23);
            txtStartDate.TabIndex = 5;
            // 
            // txtEndDate
            // 
            txtEndDate.Location = new System.Drawing.Point(530, 77);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new System.Drawing.Size(215, 23);
            txtEndDate.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(440, 83);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(81, 15);
            label4.TabIndex = 6;
            label4.Text = "Ngày kết thúc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(50, 126);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(122, 15);
            label5.TabIndex = 8;
            label5.Text = "Thời gian bắt đầu học";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(441, 126);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(63, 15);
            label6.TabIndex = 9;
            label6.Text = "Số tiết học";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(186, 222);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(137, 50);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(500, 222);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(137, 50);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtClassTime
            // 
            txtClassTime.Location = new System.Drawing.Point(195, 120);
            txtClassTime.Name = "txtClassTime";
            txtClassTime.Size = new System.Drawing.Size(215, 23);
            txtClassTime.TabIndex = 14;
            // 
            // cbNumLessons
            // 
            cbNumLessons.FormattingEnabled = true;
            cbNumLessons.Location = new System.Drawing.Point(530, 120);
            cbNumLessons.Name = "cbNumLessons";
            cbNumLessons.Size = new System.Drawing.Size(215, 23);
            cbNumLessons.TabIndex = 15;
            cbNumLessons.SelectedIndexChanged += cbNumLessons_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(50, 171);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(104, 15);
            label7.TabIndex = 16;
            label7.Text = "Số lượng sinh viên";
            // 
            // txtNumOfStudents
            // 
            txtNumOfStudents.Location = new System.Drawing.Point(195, 168);
            txtNumOfStudents.Name = "txtNumOfStudents";
            txtNumOfStudents.Size = new System.Drawing.Size(215, 23);
            txtNumOfStudents.TabIndex = 17;
            // 
            // AddRegularClassForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 313);
            Controls.Add(txtNumOfStudents);
            Controls.Add(label7);
            Controls.Add(cbNumLessons);
            Controls.Add(txtClassTime);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
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
            Name = "AddRegularClassForm";
            Text = "Thêm lớp  học chính quy";
            Load += AddRegularClassFormcs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.ComboBox cbTeacher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtStartDate;
        private System.Windows.Forms.DateTimePicker txtEndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker txtClassTime;
        private System.Windows.Forms.ComboBox cbNumLessons;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumOfStudents;
    }
}