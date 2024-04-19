namespace StudentManagament.HandleTeacher
{
    partial class TeacherManagementForm
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
            btnSearch = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            dataTeachers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataTeachers).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(470, 21);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(75, 23);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += txtSeach_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(551, 21);
            btnAdd.Name = "btnAdd";
            btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            btnAdd.Size = new System.Drawing.Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(632, 21);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(75, 23);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(713, 21);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(269, 21);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(195, 23);
            txtSearch.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(214, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 15);
            label1.TabIndex = 5;
            label1.Text = "Từ khóa";
            label1.Click += label1_Click;
            // 
            // dataTeachers
            // 
            dataTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTeachers.Location = new System.Drawing.Point(-1, 71);
            dataTeachers.Name = "dataTeachers";
            dataTeachers.RowTemplate.Height = 25;
            dataTeachers.Size = new System.Drawing.Size(800, 379);
            dataTeachers.TabIndex = 6;
            // 
            // TeacherManagementForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dataTeachers);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Name = "TeacherManagementForm";
            Text = "Quản lý giảng viên";
            Load += TeacherManagamentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataTeachers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataTeachers;
    }
}