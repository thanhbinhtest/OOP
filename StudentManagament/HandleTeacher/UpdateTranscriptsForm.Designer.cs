namespace StudentManagament.HandleTeacher
{
    partial class UpdateTranscriptsForm
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
            dataTranscripts = new System.Windows.Forms.DataGridView();
            btnUpdate = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataTranscripts).BeginInit();
            SuspendLayout();
            // 
            // dataTranscripts
            // 
            dataTranscripts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTranscripts.Location = new System.Drawing.Point(-2, 0);
            dataTranscripts.Name = "dataTranscripts";
            dataTranscripts.RowTemplate.Height = 25;
            dataTranscripts.Size = new System.Drawing.Size(456, 372);
            dataTranscripts.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(237, 397);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(93, 30);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(348, 397);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(93, 30);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // UpdateTranscriptsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(453, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(dataTranscripts);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Name = "UpdateTranscriptsForm";
            Text = "Cập nhật bảng điểm";
            Load += UpdateTranscriptsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataTranscripts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataTranscripts;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
    }
}