namespace StudentManagament
{
    partial class RegisterClassForm
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
            dataClass = new System.Windows.Forms.DataGridView();
            btnRegister = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataClass).BeginInit();
            SuspendLayout();
            // 
            // dataClass
            // 
            dataClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataClass.Location = new System.Drawing.Point(2, 1);
            dataClass.Name = "dataClass";
            dataClass.RowTemplate.Height = 25;
            dataClass.Size = new System.Drawing.Size(594, 361);
            dataClass.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.Location = new System.Drawing.Point(413, 386);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(75, 23);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(507, 386);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += button2_Click;
            // 
            // RegisterClassForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(598, 418);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(dataClass);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Name = "RegisterClassForm";
            Text = "Đăng ký môn học";
            Load += RegisterClassForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataClass).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataClass;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
    }
}