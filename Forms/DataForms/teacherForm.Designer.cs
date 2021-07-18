
namespace ExampleSQLApp
{
    partial class teacherForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.warningDataLabel = new System.Windows.Forms.Label();
            this.teachersTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.teacherDataGridView = new System.Windows.Forms.DataGridView();
            this.teacherAddButton = new System.Windows.Forms.Button();
            this.refreshPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фильтр";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.warningDataLabel);
            this.panel1.Controls.Add(this.teachersTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 149);
            this.panel1.TabIndex = 8;
            // 
            // warningDataLabel
            // 
            this.warningDataLabel.AutoSize = true;
            this.warningDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.warningDataLabel.ForeColor = System.Drawing.Color.Yellow;
            this.warningDataLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.warningDataLabel.Location = new System.Drawing.Point(8, 111);
            this.warningDataLabel.Name = "warningDataLabel";
            this.warningDataLabel.Size = new System.Drawing.Size(221, 13);
            this.warningDataLabel.TabIndex = 16;
            this.warningDataLabel.Text = "*такого преподавателя нет в базе данных";
            this.warningDataLabel.Visible = false;
            // 
            // teachersTextBox
            // 
            this.teachersTextBox.BackColor = System.Drawing.Color.Gray;
            this.teachersTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teachersTextBox.ForeColor = System.Drawing.Color.Silver;
            this.teachersTextBox.Location = new System.Drawing.Point(11, 57);
            this.teachersTextBox.Multiline = true;
            this.teachersTextBox.Name = "teachersTextBox";
            this.teachersTextBox.Size = new System.Drawing.Size(273, 30);
            this.teachersTextBox.TabIndex = 1;
            this.teachersTextBox.Text = "Имя, фамилия";
            this.teachersTextBox.TextChanged += new System.EventHandler(this.teachersTextBox_TextChanged);
            this.teachersTextBox.Enter += new System.EventHandler(this.teachersTextBox_Enter);
            this.teachersTextBox.Leave += new System.EventHandler(this.teachersTextBox_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.teacherDataGridView);
            this.panel2.Location = new System.Drawing.Point(12, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 388);
            this.panel2.TabIndex = 9;
            // 
            // teacherDataGridView
            // 
            this.teacherDataGridView.AllowUserToAddRows = false;
            this.teacherDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teacherDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.teacherDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teacherDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.teacherDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teacherDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.teacherDataGridView.ColumnHeadersHeight = 100;
            this.teacherDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.teacherDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacherDataGridView.EnableHeadersVisualStyles = false;
            this.teacherDataGridView.GridColor = System.Drawing.Color.Gray;
            this.teacherDataGridView.Location = new System.Drawing.Point(0, 0);
            this.teacherDataGridView.Name = "teacherDataGridView";
            this.teacherDataGridView.ReadOnly = true;
            this.teacherDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teacherDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.teacherDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teacherDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.teacherDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.teacherDataGridView.Size = new System.Drawing.Size(1021, 388);
            this.teacherDataGridView.TabIndex = 1;
            this.teacherDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teacherDataGridView_CellContentClick);
            // 
            // teacherAddButton
            // 
            this.teacherAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teacherAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.teacherAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacherAddButton.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherAddButton.ForeColor = System.Drawing.Color.White;
            this.teacherAddButton.Location = new System.Drawing.Point(893, 8);
            this.teacherAddButton.Name = "teacherAddButton";
            this.teacherAddButton.Size = new System.Drawing.Size(125, 35);
            this.teacherAddButton.TabIndex = 10;
            this.teacherAddButton.Text = "Изменить";
            this.teacherAddButton.UseVisualStyleBackColor = false;
            this.teacherAddButton.Click += new System.EventHandler(this.teacherAddButton_Click);
            // 
            // refreshPictureBox
            // 
            this.refreshPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.refreshPictureBox.Image = global::ExampleSQLApp.Properties.Resources.icon;
            this.refreshPictureBox.Location = new System.Drawing.Point(842, 8);
            this.refreshPictureBox.Name = "refreshPictureBox";
            this.refreshPictureBox.Size = new System.Drawing.Size(32, 32);
            this.refreshPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshPictureBox.TabIndex = 11;
            this.refreshPictureBox.TabStop = false;
            this.refreshPictureBox.Click += new System.EventHandler(this.refreshPictureBox_Click);
            // 
            // teacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1046, 603);
            this.Controls.Add(this.refreshPictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.teacherAddButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "teacherForm";
            this.Text = "teacherForm";
            this.Load += new System.EventHandler(this.teacherForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label warningDataLabel;
        private System.Windows.Forms.TextBox teachersTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView teacherDataGridView;
        private System.Windows.Forms.Button teacherAddButton;
        private System.Windows.Forms.PictureBox refreshPictureBox;
    }
}