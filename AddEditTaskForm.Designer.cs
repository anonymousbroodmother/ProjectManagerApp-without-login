namespace WinFormsApp1
{
    partial class AddEditTaskForm
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
            txtTitle = new TextBox();
            dtpDueDate = new DateTimePicker();
            chkCompleted = new CheckBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(191, 51);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(224, 23);
            txtTitle.TabIndex = 0;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(191, 106);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(224, 23);
            dtpDueDate.TabIndex = 1;
            // 
            // chkCompleted
            // 
            chkCompleted.AutoSize = true;
            chkCompleted.Location = new Point(191, 170);
            chkCompleted.Name = "chkCompleted";
            chkCompleted.Size = new Size(83, 19);
            chkCompleted.TabIndex = 2;
            chkCompleted.Text = "checkBox1";
            chkCompleted.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(191, 237);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 3;
            btnOK.Text = "Ок";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(340, 237);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddEditTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(chkCompleted);
            Controls.Add(dtpDueDate);
            Controls.Add(txtTitle);
            Name = "AddEditTaskForm";
            Text = "AddEditTaskForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private DateTimePicker dtpDueDate;
        private CheckBox chkCompleted;
        private Button btnOK;
        private Button btnCancel;
    }
}