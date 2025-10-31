namespace WinFormsApp1
{
    partial class AddProjectForm
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
            txtName = new TextBox();
            txtDescription = new TextBox();
            buttonOK = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(189, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(297, 23);
            txtName.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(189, 120);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(297, 23);
            txtDescription.TabIndex = 1;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(189, 211);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "Ок";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += btnOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(401, 211);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += btnCancel_Click;
            // 
            // AddProjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Name = "AddProjectForm";
            Text = "AddProjectForm";
            Load += AddProjectForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtDescription;
        private Button buttonOK;
        private Button buttonCancel;
    }
}