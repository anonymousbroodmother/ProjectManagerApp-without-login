namespace WinFormsApp1
{
    partial class TaskViewForm
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
            lblTitle = new Label();
            dataGridViewTasks = new DataGridView();
            btnEditTask = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(55, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(178, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Задачи проекта: [Имя проекта]";
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Location = new Point(37, 50);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.Size = new Size(718, 295);
            dataGridViewTasks.TabIndex = 1;
            // 
            // btnEditTask
            // 
            btnEditTask.Location = new Point(37, 371);
            btnEditTask.Name = "btnEditTask";
            btnEditTask.Size = new Size(718, 67);
            btnEditTask.TabIndex = 3;
            btnEditTask.Text = "Редактировать";
            btnEditTask.UseVisualStyleBackColor = true;
            btnEditTask.Click += btnEditTask_Click;
            // 
            // TaskViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditTask);
            Controls.Add(dataGridViewTasks);
            Controls.Add(lblTitle);
            Name = "TaskViewForm";
            Text = "TaskViewForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dataGridViewTasks;
        private Button btnEditTask;
    }
}