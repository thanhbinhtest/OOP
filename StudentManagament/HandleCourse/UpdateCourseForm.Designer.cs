namespace StudentManagament.HandleCourse
{
    partial class UpdateCourseForm
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
            txtName = new System.Windows.Forms.TextBox();
            txtHour = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtCredit = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            radioReg = new System.Windows.Forms.RadioButton();
            radioPost = new System.Windows.Forms.RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(31, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên môn học";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(140, 39);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(237, 23);
            txtName.TabIndex = 2;
            // 
            // txtHour
            // 
            txtHour.Location = new System.Drawing.Point(140, 129);
            txtHour.Name = "txtHour";
            txtHour.Size = new System.Drawing.Size(237, 23);
            txtHour.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(31, 132);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(103, 15);
            label3.TabIndex = 3;
            label3.Text = "Số giờ nghiên cứu";
            // 
            // txtCredit
            // 
            txtCredit.Location = new System.Drawing.Point(140, 167);
            txtCredit.Name = "txtCredit";
            txtCredit.Size = new System.Drawing.Size(237, 23);
            txtCredit.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(31, 170);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 15);
            label2.TabIndex = 5;
            label2.Text = "Số tín chỉ";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(76, 228);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(98, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Cập nhật";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(222, 228);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(98, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += button2_Click;
            // 
            // radioReg
            // 
            radioReg.AutoSize = true;
            radioReg.Location = new System.Drawing.Point(31, 87);
            radioReg.Name = "radioReg";
            radioReg.Size = new System.Drawing.Size(129, 19);
            radioReg.TabIndex = 9;
            radioReg.TabStop = true;
            radioReg.Text = "Môn học chính quy";
            radioReg.UseVisualStyleBackColor = true;
            radioReg.CheckedChanged += radioReg_CheckedChanged;
            // 
            // radioPost
            // 
            radioPost.AutoSize = true;
            radioPost.Location = new System.Drawing.Point(241, 87);
            radioPost.Name = "radioPost";
            radioPost.Size = new System.Drawing.Size(136, 19);
            radioPost.TabIndex = 10;
            radioPost.TabStop = true;
            radioPost.Text = "Môn học sau đại học";
            radioPost.UseVisualStyleBackColor = true;
            radioPost.CheckedChanged += radioPost_CheckedChanged;
            // 
            // UpdateCourseForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(416, 269);
            Controls.Add(radioPost);
            Controls.Add(radioReg);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtCredit);
            Controls.Add(label2);
            Controls.Add(txtHour);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Name = "UpdateCourseForm";
            Text = "Cập nhật môn học";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton radioReg;
        private System.Windows.Forms.RadioButton radioPost;
    }
}