namespace StudentManagament.HandleClass
{
    partial class ClassManagementForm
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
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            dataRegClass = new System.Windows.Forms.DataGridView();
            tabPage2 = new System.Windows.Forms.TabPage();
            dataPostClass = new System.Windows.Forms.DataGridView();
            btnDelete = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataRegClass).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataPostClass).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new System.Drawing.Point(0, 77);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(801, 327);
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataRegClass);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(793, 299);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lớp học chính quy";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataRegClass
            // 
            dataRegClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataRegClass.Location = new System.Drawing.Point(0, 0);
            dataRegClass.Name = "dataRegClass";
            dataRegClass.RowTemplate.Height = 25;
            dataRegClass.Size = new System.Drawing.Size(793, 303);
            dataRegClass.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataPostClass);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(793, 299);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Lớp học sau đại học";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataPostClass
            // 
            dataPostClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataPostClass.Location = new System.Drawing.Point(0, 0);
            dataPostClass.Name = "dataPostClass";
            dataPostClass.RowTemplate.Height = 25;
            dataPostClass.Size = new System.Drawing.Size(793, 284);
            dataPostClass.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(712, 37);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(631, 37);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(75, 23);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(550, 37);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(75, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // ClassManagementForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 400);
            Controls.Add(tabControl1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Name = "ClassManagementForm";
            Text = "Quản lý lớp học";
            Load += ClassManagementForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataRegClass).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataPostClass).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataRegClass;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataPostClass;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}