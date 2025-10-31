namespace WinFormsApp1
{
    partial class AnalyticsForm
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
            txtResults = new TextBox();
            btnRefresh = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(45, 37);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(65, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Заголовок";
            // 
            // txtResults
            // 
            txtResults.Location = new Point(167, 34);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.ScrollBars = ScrollBars.Vertical;
            txtResults.Size = new Size(364, 241);
            txtResults.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(167, 322);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(128, 57);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Обновить";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(393, 322);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(138, 57);
            btnClose.TabIndex = 3;
            btnClose.Text = "Закрыть";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // AnalyticsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnRefresh);
            Controls.Add(txtResults);
            Controls.Add(lblTitle);
            Name = "AnalyticsForm";
            Text = "AnalyticsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtResults;
        private Button btnRefresh;
        private Button btnClose;
    }
}