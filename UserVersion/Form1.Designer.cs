namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            listBoxProjects = new ListBox();
            btnViewTasks = new Button();
            SuspendLayout();
            // 
            // listBoxProjects
            // 
            listBoxProjects.FormattingEnabled = true;
            listBoxProjects.Location = new Point(21, 22);
            listBoxProjects.Name = "listBoxProjects";
            listBoxProjects.Size = new Size(917, 349);
            listBoxProjects.TabIndex = 0;
            // 
            // btnViewTasks
            // 
            btnViewTasks.Location = new Point(21, 401);
            btnViewTasks.Name = "btnViewTasks";
            btnViewTasks.Size = new Size(917, 85);
            btnViewTasks.TabIndex = 4;
            btnViewTasks.Text = "Просмотр задач";
            btnViewTasks.UseVisualStyleBackColor = true;
            btnViewTasks.Click += btnViewTasks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 520);
            Controls.Add(btnViewTasks);
            Controls.Add(listBoxProjects);
            Name = "Form1";
            Text = "Управление проектами";
            ResumeLayout(false);
        }
        private ListBox listBoxProjects;
        private Button btnViewTasks;
    }
}   