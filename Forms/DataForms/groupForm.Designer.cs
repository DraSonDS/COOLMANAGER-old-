
namespace ExampleSQLApp
{
    partial class groupForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.warningDataLabel = new System.Windows.Forms.Label();
            this.nameSearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupAddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDataGridView
            // 
            this.groupDataGridView.AllowUserToAddRows = false;
            this.groupDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.groupDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.groupDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.groupDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.groupDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.groupDataGridView.ColumnHeadersHeight = 100;
            this.groupDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDataGridView.EnableHeadersVisualStyles = false;
            this.groupDataGridView.GridColor = System.Drawing.Color.Gray;
            this.groupDataGridView.Location = new System.Drawing.Point(0, 0);
            this.groupDataGridView.Name = "groupDataGridView";
            this.groupDataGridView.ReadOnly = true;
            this.groupDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.groupDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.groupDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.groupDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.groupDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupDataGridView.Size = new System.Drawing.Size(1021, 388);
            this.groupDataGridView.TabIndex = 19;
            this.groupDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupDataGridView_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.groupDataGridView);
            this.panel2.Location = new System.Drawing.Point(12, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 388);
            this.panel2.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.warningDataLabel);
            this.panel1.Controls.Add(this.nameSearchBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 149);
            this.panel1.TabIndex = 25;
            // 
            // warningDataLabel
            // 
            this.warningDataLabel.AutoSize = true;
            this.warningDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.warningDataLabel.ForeColor = System.Drawing.Color.Yellow;
            this.warningDataLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.warningDataLabel.Location = new System.Drawing.Point(8, 111);
            this.warningDataLabel.Name = "warningDataLabel";
            this.warningDataLabel.Size = new System.Drawing.Size(175, 13);
            this.warningDataLabel.TabIndex = 16;
            this.warningDataLabel.Text = "*такой группы нет в базе данных";
            this.warningDataLabel.Visible = false;
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
            this.nameSearchBox.Text = "Название группы";
            this.nameSearchBox.TextChanged += new System.EventHandler(this.nameSearchBox_TextChanged);
            this.nameSearchBox.Enter += new System.EventHandler(this.nameSearchBox_Enter);
            this.nameSearchBox.Leave += new System.EventHandler(this.nameSearchBox_Leave);
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
            // groupAddButton
            // 
            this.groupAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupAddButton.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupAddButton.ForeColor = System.Drawing.Color.White;
            this.groupAddButton.Location = new System.Drawing.Point(893, 6);
            this.groupAddButton.Name = "groupAddButton";
            this.groupAddButton.Size = new System.Drawing.Size(125, 35);
            this.groupAddButton.TabIndex = 17;
            this.groupAddButton.Text = "Добавить";
            this.groupAddButton.UseVisualStyleBackColor = false;
            this.groupAddButton.Click += new System.EventHandler(this.groupAddButton_Click);
            // 
            // groupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1046, 603);
            this.Controls.Add(this.groupAddButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "groupForm";
            this.Text = "groupForm";
            this.Load += new System.EventHandler(this.groupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView groupDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label warningDataLabel;
        private System.Windows.Forms.TextBox nameSearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button groupAddButton;
    }
}