
namespace ExampleSQLApp.Forms.DataForms
{
    partial class groupEditForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupDataGridView = new System.Windows.Forms.DataGridView();
            this.groupNameLabel = new System.Windows.Forms.Label();
            this.groupStatuslabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.teacherNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentAddButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Label();
            this.subjectNameLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentGroupDeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDataGridView
            // 
            this.groupDataGridView.AllowUserToAddRows = false;
            this.groupDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groupDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.groupDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.groupDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.groupDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.groupDataGridView.ColumnHeadersHeight = 100;
            this.groupDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupDataGridView.EnableHeadersVisualStyles = false;
            this.groupDataGridView.GridColor = System.Drawing.Color.Gray;
            this.groupDataGridView.Location = new System.Drawing.Point(414, 149);
            this.groupDataGridView.Name = "groupDataGridView";
            this.groupDataGridView.ReadOnly = true;
            this.groupDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.groupDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.groupDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.groupDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.groupDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupDataGridView.Size = new System.Drawing.Size(553, 307);
            this.groupDataGridView.TabIndex = 20;
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.AutoSize = true;
            this.groupNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupNameLabel.Location = new System.Drawing.Point(3, 3);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(225, 35);
            this.groupNameLabel.TabIndex = 31;
            this.groupNameLabel.Text = "Название группы";
            // 
            // groupStatuslabel
            // 
            this.groupStatuslabel.AutoSize = true;
            this.groupStatuslabel.Font = new System.Drawing.Font("Segoe UI Semilight", 18.25F, System.Drawing.FontStyle.Bold);
            this.groupStatuslabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupStatuslabel.Location = new System.Drawing.Point(3, 392);
            this.groupStatuslabel.Name = "groupStatuslabel";
            this.groupStatuslabel.Size = new System.Drawing.Size(151, 35);
            this.groupStatuslabel.TabIndex = 32;
            this.groupStatuslabel.Text = "Тип группы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(9, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Группа";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(5, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "Преподаватель";
            // 
            // teacherNameLabel
            // 
            this.teacherNameLabel.AutoSize = true;
            this.teacherNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.teacherNameLabel.Location = new System.Drawing.Point(3, 201);
            this.teacherNameLabel.Name = "teacherNameLabel";
            this.teacherNameLabel.Size = new System.Drawing.Size(393, 35);
            this.teacherNameLabel.TabIndex = 35;
            this.teacherNameLabel.Text = "Имя и фамилия преподавателя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(409, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Ученики";
            // 
            // studentAddButton
            // 
            this.studentAddButton.BackColor = System.Drawing.Color.Teal;
            this.studentAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.studentAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentAddButton.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentAddButton.ForeColor = System.Drawing.Color.White;
            this.studentAddButton.Location = new System.Drawing.Point(678, 102);
            this.studentAddButton.Name = "studentAddButton";
            this.studentAddButton.Size = new System.Drawing.Size(137, 37);
            this.studentAddButton.TabIndex = 37;
            this.studentAddButton.Text = "Добавить";
            this.studentAddButton.UseVisualStyleBackColor = false;
            this.studentAddButton.Click += new System.EventHandler(this.studentAddButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(965, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 24);
            this.closeButton.TabIndex = 38;
            this.closeButton.Text = "x";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // subjectNameLabel
            // 
            this.subjectNameLabel.AutoSize = true;
            this.subjectNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subjectNameLabel.Location = new System.Drawing.Point(-1, 289);
            this.subjectNameLabel.Name = "subjectNameLabel";
            this.subjectNameLabel.Size = new System.Drawing.Size(254, 35);
            this.subjectNameLabel.TabIndex = 39;
            this.subjectNameLabel.Text = "Название предмета";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(3, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 40;
            this.label6.Text = "Предмет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(5, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "Статус";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.groupNameLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 73);
            this.panel1.TabIndex = 42;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // studentGroupDeleteButton
            // 
            this.studentGroupDeleteButton.BackColor = System.Drawing.Color.IndianRed;
            this.studentGroupDeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.studentGroupDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentGroupDeleteButton.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentGroupDeleteButton.ForeColor = System.Drawing.Color.White;
            this.studentGroupDeleteButton.Location = new System.Drawing.Point(830, 102);
            this.studentGroupDeleteButton.Name = "studentGroupDeleteButton";
            this.studentGroupDeleteButton.Size = new System.Drawing.Size(137, 37);
            this.studentGroupDeleteButton.TabIndex = 43;
            this.studentGroupDeleteButton.Text = "Удалить";
            this.studentGroupDeleteButton.UseVisualStyleBackColor = false;
            this.studentGroupDeleteButton.Click += new System.EventHandler(this.studentGroupDeleteButton_Click);
            // 
            // groupEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(991, 532);
            this.Controls.Add(this.studentGroupDeleteButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.subjectNameLabel);
            this.Controls.Add(this.studentAddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teacherNameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupStatuslabel);
            this.Controls.Add(this.groupDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "groupEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "groupEditForm";
            this.Load += new System.EventHandler(this.groupEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView groupDataGridView;
        private System.Windows.Forms.Label groupNameLabel;
        private System.Windows.Forms.Label groupStatuslabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label teacherNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button studentAddButton;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label subjectNameLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button studentGroupDeleteButton;
    }
}