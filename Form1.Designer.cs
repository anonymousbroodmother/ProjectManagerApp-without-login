namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxProjects = new ListBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnViewTasks = new Button();
            SuspendLayout();
            // 
            // listBoxProjects
            // 
            listBoxProjects.FormattingEnabled = true;
            listBoxProjects.Location = new Point(25, 12);
            listBoxProjects.Name = "listBoxProjects";
            listBoxProjects.Size = new Size(772, 364);
            listBoxProjects.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(54, 389);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Добавить проект";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(213, 389);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(104, 23);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(404, 389);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = " Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnViewTasks
            // 
            btnViewTasks.Location = new Point(628, 389);
            btnViewTasks.Name = "btnViewTasks";
            btnViewTasks.Size = new Size(117, 23);
            btnViewTasks.TabIndex = 5;
            btnViewTasks.Text = "Просмотр задач";
            btnViewTasks.UseVisualStyleBackColor = true;
            btnViewTasks.Click += btnViewTasks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnViewTasks);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(listBoxProjects);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxProjects;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnViewTasks;
    }
}
