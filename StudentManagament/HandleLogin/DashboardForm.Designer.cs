namespace StudentManagament.HandleLogin
{
    partial class DashboardForm
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
            btnStudent = new System.Windows.Forms.Button();
            btnClass = new System.Windows.Forms.Button();
            btnCourse = new System.Windows.Forms.Button();
            btnTeacher = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnStudent
            // 
            btnStudent.Location = new System.Drawing.Point(52, 57);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new System.Drawing.Size(200, 120);
            btnStudent.TabIndex = 0;
            btnStudent.Text = "QUẢN LÝ SINH VIÊN";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnClass
            // 
            btnClass.Location = new System.Drawing.Point(280, 57);
            btnClass.Name = "btnClass";
            btnClass.Size = new System.Drawing.Size(200, 120);
            btnClass.TabIndex = 1;
            btnClass.Text = "QUẢN LÝ LỚP HỌC";
            btnClass.UseVisualStyleBackColor = true;
            btnClass.Click += btnClass_Click;
            // 
            // btnCourse
            // 
            btnCourse.Location = new System.Drawing.Point(52, 217);
            btnCourse.Name = "btnCourse";
            btnCourse.Size = new System.Drawing.Size(200, 120);
            btnCourse.TabIndex = 2;
            btnCourse.Text = "QUẢN LÝ MÔN HỌC";
            btnCourse.UseVisualStyleBackColor = true;
            btnCourse.Click += btnCourse_Click;
            // 
            // btnTeacher
            // 
            btnTeacher.Location = new System.Drawing.Point(280, 217);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Size = new System.Drawing.Size(200, 120);
            btnTeacher.TabIndex = 3;
            btnTeacher.Text = "QUẢN LÝ GIẢNG VIÊN";
            btnTeacher.UseVisualStyleBackColor = true;
            btnTeacher.Click += btnTeacher_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(525, 379);
            Controls.Add(btnTeacher);
            Controls.Add(btnCourse);
            Controls.Add(btnClass);
            Controls.Add(btnStudent);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Name = "DashboardForm";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnTeacher;
    }
}