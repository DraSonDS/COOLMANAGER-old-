
namespace ExampleSQLApp
{
    partial class studentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.warningDataLabel = new System.Windows.Forms.Label();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameSearchBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EmpoyeesListDataGridView = new System.Windows.Forms.DataGridView();
            this.studentAddButton = new System.Windows.Forms.Button();
            this.refreshPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpoyeesListDataGridView)).BeginInit();
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
            this.panel1.Controls.Add(this.sexComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nameSearchBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 149);
            this.panel1.TabIndex = 1;
            // 
            // warningDataLabel
            // 
            this.warningDataLabel.AutoSize = true;
            this.warningDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.warningDataLabel.ForeColor = System.Drawing.Color.Yellow;
            this.warningDataLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.warningDataLabel.Location = new System.Drawing.Point(8, 111);
            this.warningDataLabel.Name = "warningDataLabel";
            this.warningDataLabel.Size = new System.Drawing.Size(178, 13);
            this.warningDataLabel.TabIndex = 16;
            this.warningDataLabel.Text = "*такого ученика нет в базе даных";
            this.warningDataLabel.Visible = false;
            // 
            // sexComboBox
            // 
            this.sexComboBox.BackColor = System.Drawing.Color.Gray;
            this.sexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sexComboBox.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexComboBox.ForeColor = System.Drawing.Color.FloralWhite;
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "-",
            "Муж.",
            "Жен."});
            this.sexComboBox.Location = new System.Drawing.Point(384, 60);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(78, 29);
            this.sexComboBox.TabIndex = 8;
            this.sexComboBox.SelectedIndexChanged += new System.EventHandler(this.sexComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(315, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пол:";
            // 
            // nameSearchBox
            // 
            this.nameSearchBox.BackColor = System.Drawing.Color.Gray;
            this.nameSearchBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameSearchBox.ForeColor = System.Drawing.Color.Silver;
            this.nameSearchBox.Location = new System.Drawing.Point(11, 57);
            this.nameSearchBox.Multiline = true;
            this.nameSearchBox.Name = "nameSearchBox";
            this.nameSearchBox.Size = new System.Drawing.Size(273, 30);
            this.nameSearchBox.TabIndex = 1;
            this.nameSearchBox.Text = "Имя, фамилия, отчество";
            this.nameSearchBox.TextChanged += new System.EventHandler(this.nameSearchBox_TextChanged);
            this.nameSearchBox.Enter += new System.EventHandler(this.textBox1_Enter);
            this.nameSearchBox.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.EmpoyeesListDataGridView);
            this.panel2.Location = new System.Drawing.Point(12, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 388);
            this.panel2.TabIndex = 2;
            // 
            // EmpoyeesListDataGridView
            // 
            this.EmpoyeesListDataGridView.AllowUserToAddRows = false;
            this.EmpoyeesListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.EmpoyeesListDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.EmpoyeesListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpoyeesListDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmpoyeesListDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpoyeesListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EmpoyeesListDataGridView.ColumnHeadersHeight = 100;
            this.EmpoyeesListDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.EmpoyeesListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmpoyeesListDataGridView.EnableHeadersVisualStyles = false;
            this.EmpoyeesListDataGridView.GridColor = System.Drawing.Color.Gray;
            this.EmpoyeesListDataGridView.Location = new System.Drawing.Point(0, 0);
            this.EmpoyeesListDataGridView.Name = "EmpoyeesListDataGridView";
            this.EmpoyeesListDataGridView.ReadOnly = true;
            this.EmpoyeesListDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpoyeesListDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmpoyeesListDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpoyeesListDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.EmpoyeesListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmpoyeesListDataGridView.Size = new System.Drawing.Size(1021, 388);
            this.EmpoyeesListDataGridView.TabIndex = 1;
            // 
            // studentAddButton
            // 
            this.studentAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.studentAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.studentAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentAddButton.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentAddButton.ForeColor = System.Drawing.Color.White;
            this.studentAddButton.Location = new System.Drawing.Point(893, 6);
            this.studentAddButton.Name = "studentAddButton";
            this.studentAddButton.Size = new System.Drawing.Size(125, 35);
            this.studentAddButton.TabIndex = 7;
            this.studentAddButton.Text = "Добавить";
            this.studentAddButton.UseVisualStyleBackColor = false;
            this.studentAddButton.Click += new System.EventHandler(this.studentAddButton_Click_1);
            // 
            // refreshPictureBox
            // 
            this.refreshPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.refreshPictureBox.Image = global::ExampleSQLApp.Properties.Resources.icon;
            this.refreshPictureBox.Location = new System.Drawing.Point(839, 6);
            this.refreshPictureBox.Name = "refreshPictureBox";
            this.refreshPictureBox.Size = new System.Drawing.Size(32, 32);
            this.refreshPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshPictureBox.TabIndex = 9;
            this.refreshPictureBox.TabStop = false;
            this.refreshPictureBox.Click += new System.EventHandler(this.refreshPictureBox_Click);
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1046, 603);
            this.Controls.Add(this.refreshPictureBox);
            this.Controls.Add(this.studentAddButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "studentForm";
            this.Text = "studentForm";
            this.Load += new System.EventHandler(this.studentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmpoyeesListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nameSearchBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView EmpoyeesListDataGridView;
        private System.Windows.Forms.Button studentAddButton;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label warningDataLabel;
        private System.Windows.Forms.PictureBox refreshPictureBox;
    }
}