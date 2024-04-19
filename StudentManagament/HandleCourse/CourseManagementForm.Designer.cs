namespace StudentManagament.HandleCourse
{
    partial class CourseManagementForm
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
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            dataRegCourse = new System.Windows.Forms.DataGridView();
            tabPage2 = new System.Windows.Forms.TabPage();
            dataPostCourse = new System.Windows.Forms.DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataRegCourse).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataPostCourse).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(245, 27);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(75, 23);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(326, 27);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(407, 27);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(75, 23);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(488, 27);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(63, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(162, 23);
            txtSearch.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 15);
            label1.TabIndex = 5;
            label1.Text = "Từ khóa";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new System.Drawing.Point(-2, 70);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(582, 312);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataRegCourse);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(574, 284);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Môn học chính quy";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataRegCourse
            // 
            dataRegCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataRegCourse.Location = new System.Drawing.Point(0, 0);
            dataRegCourse.Name = "dataRegCourse";
            dataRegCourse.RowTemplate.Height = 25;
            dataRegCourse.Size = new System.Drawing.Size(573, 284);
            dataRegCourse.TabIndex = 0;
            dataRegCourse.CellContentClick += dataRegCourse_CellContentClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataPostCourse);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(574, 284);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Môn học sau đại học";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataPostCourse
            // 
            dataPostCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataPostCourse.Location = new System.Drawing.Point(0, 0);
            dataPostCourse.Name = "dataPostCourse";
            dataPostCourse.RowTemplate.Height = 25;
            dataPostCourse.Size = new System.Drawing.Size(574, 284);
            dataPostCourse.TabIndex = 0;
            // 
            // CourseManagementForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(577, 379);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Name = "CourseManagementForm";
            Text = "Quản lý môn học";
            Load += CourseManagamentForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataRegCourse).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataPostCourse).EndInit();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataRegCourse;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataPostCourse;
    }
}