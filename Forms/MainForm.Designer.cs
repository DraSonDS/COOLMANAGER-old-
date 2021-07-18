
namespace ExampleSQLApp
{
    partial class MainForm
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
            this.tabPanel = new System.Windows.Forms.Panel();
            this.taskButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupButton = new System.Windows.Forms.Button();
            this.teacherButton = new System.Windows.Forms.Button();
            this.studentButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Label();
            this.formNameLabel = new System.Windows.Forms.Label();
            this.formOpener = new System.Windows.Forms.Panel();
            this.tabPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPanel
            // 
            this.tabPanel.BackColor = System.Drawing.Color.DimGray;
            this.tabPanel.Controls.Add(this.taskButton);
            this.tabPanel.Controls.Add(this.panel1);
            this.tabPanel.Controls.Add(this.groupButton);
            this.tabPanel.Controls.Add(this.teacherButton);
            this.tabPanel.Controls.Add(this.studentButton);
            this.tabPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabPanel.Location = new System.Drawing.Point(0, 0);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(218, 681);
            this.tabPanel.TabIndex = 0;
            // 
            // taskButton
            // 
            this.taskButton.BackColor = System.Drawing.Color.Transparent;
            this.taskButton.FlatAppearance.BorderSize = 0;
            this.taskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.taskButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.taskButton.Image = global::ExampleSQLApp.Properties.Resources._11;
            this.taskButton.Location = new System.Drawing.Point(0, 206);
            this.taskButton.Name = "taskButton";
            this.taskButton.Size = new System.Drawing.Size(220, 56);
            this.taskButton.TabIndex = 9;
            this.taskButton.Text = "Мои задачи";
            this.taskButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.taskButton.UseVisualStyleBackColor = false;
            this.taskButton.Click += new System.EventHandler(this.taskButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loginLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 196);
            this.panel1.TabIndex = 8;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginLabel.Location = new System.Drawing.Point(53, 147);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(107, 25);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "User Name";
            this.loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExampleSQLApp.Properties.Resources.avatar;
            this.pictureBox1.Location = new System.Drawing.Point(35, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupButton
            // 
            this.groupButton.BackColor = System.Drawing.Color.Transparent;
            this.groupButton.FlatAppearance.BorderSize = 0;
            this.groupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.groupButton.Image = global::ExampleSQLApp.Properties.Resources.group;
            this.groupButton.Location = new System.Drawing.Point(0, 376);
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(220, 56);
            this.groupButton.TabIndex = 6;
            this.groupButton.Text = "Группы";
            this.groupButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.groupButton.UseVisualStyleBackColor = false;
            this.groupButton.Click += new System.EventHandler(this.groupButton_Click);
            // 
            // teacherButton
            // 
            this.teacherButton.BackColor = System.Drawing.Color.Transparent;
            this.teacherButton.FlatAppearance.BorderSize = 0;
            this.teacherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacherButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.teacherButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.teacherButton.Image = global::ExampleSQLApp.Properties.Resources.teacher;
            this.teacherButton.Location = new System.Drawing.Point(0, 324);
            this.teacherButton.Name = "teacherButton";
            this.teacherButton.Size = new System.Drawing.Size(220, 56);
            this.teacherButton.TabIndex = 5;
            this.teacherButton.Text = "Преподаватели";
            this.teacherButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.teacherButton.UseVisualStyleBackColor = false;
            this.teacherButton.Click += new System.EventHandler(this.teacherButton_Click);
            // 
            // studentButton
            // 
            this.studentButton.BackColor = System.Drawing.Color.Transparent;
            this.studentButton.FlatAppearance.BorderSize = 0;
            this.studentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.studentButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.studentButton.Image = global::ExampleSQLApp.Properties.Resources._11;
            this.studentButton.Location = new System.Drawing.Point(0, 268);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(220, 56);
            this.studentButton.TabIndex = 4;
            this.studentButton.Text = "Ученики";
            this.studentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.studentButton.UseVisualStyleBackColor = false;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(1240, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 24);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "x";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // formNameLabel
            // 
            this.formNameLabel.AutoSize = true;
            this.formNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formNameLabel.ForeColor = System.Drawing.Color.FloralWhite;
            this.formNameLabel.Location = new System.Drawing.Point(226, 12);
            this.formNameLabel.Name = "formNameLabel";
            this.formNameLabel.Size = new System.Drawing.Size(140, 45);
            this.formNameLabel.TabIndex = 6;
            this.formNameLabel.Text = "Ученики";
            this.formNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formOpener
            // 
            this.formOpener.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.formOpener.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.formOpener.ForeColor = System.Drawing.SystemColors.ControlText;
            this.formOpener.Location = new System.Drawing.Point(218, 78);
            this.formOpener.Name = "formOpener";
            this.formOpener.Size = new System.Drawing.Size(1046, 603);
            this.formOpener.TabIndex = 1;
            this.formOpener.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.formNameLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.formOpener);
            this.Controls.Add(this.tabPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel tabPanel;
        private System.Windows.Forms.Button groupButton;
        private System.Windows.Forms.Button teacherButton;
        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button taskButton;
        public System.Windows.Forms.Panel formOpener;
        public System.Windows.Forms.Label formNameLabel;
    }
}