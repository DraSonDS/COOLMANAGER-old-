
namespace ExampleSQLApp
{
    partial class studentRegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.surnameField = new System.Windows.Forms.TextBox();
            this.LastnameField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.advertComboBox = new System.Windows.Forms.ComboBox();
            this.studTargetComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.warningchecklabel = new System.Windows.Forms.Label();
            this.buttonStudentReg = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.registerDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация ученика";
            // 
            // nameField
            // 
            this.nameField.BackColor = System.Drawing.Color.Gray;
            this.nameField.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameField.ForeColor = System.Drawing.Color.Silver;
            this.nameField.Location = new System.Drawing.Point(18, 69);
            this.nameField.Multiline = true;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(210, 30);
            this.nameField.TabIndex = 2;
            this.nameField.Text = "Введите имя";
            this.nameField.Enter += new System.EventHandler(this.nameField_Enter);
            this.nameField.Leave += new System.EventHandler(this.nameField_Leave);
            // 
            // surnameField
            // 
            this.surnameField.BackColor = System.Drawing.Color.Gray;
            this.surnameField.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameField.ForeColor = System.Drawing.Color.Silver;
            this.surnameField.Location = new System.Drawing.Point(254, 69);
            this.surnameField.Multiline = true;
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(210, 30);
            this.surnameField.TabIndex = 3;
            this.surnameField.Text = "Введите фамилию";
            this.surnameField.Enter += new System.EventHandler(this.surnameField_Enter);
            this.surnameField.Leave += new System.EventHandler(this.surnameField_Leave);
            // 
            // LastnameField
            // 
            this.LastnameField.BackColor = System.Drawing.Color.Gray;
            this.LastnameField.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastnameField.ForeColor = System.Drawing.Color.Silver;
            this.LastnameField.Location = new System.Drawing.Point(489, 69);
            this.LastnameField.Multiline = true;
            this.LastnameField.Name = "LastnameField";
            this.LastnameField.Size = new System.Drawing.Size(210, 30);
            this.LastnameField.TabIndex = 4;
            this.LastnameField.Text = "Введите отчество";
            this.LastnameField.Enter += new System.EventHandler(this.LastnameField_Enter);
            this.LastnameField.Leave += new System.EventHandler(this.LastnameField_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(473, 125);
            this.label4.MaximumSize = new System.Drawing.Size(130, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 50);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата обращения:";
            this.label4.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Рекламный источник:";
            // 
            // advertComboBox
            // 
            this.advertComboBox.BackColor = System.Drawing.Color.Gray;
            this.advertComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.advertComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.advertComboBox.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.advertComboBox.ForeColor = System.Drawing.Color.FloralWhite;
            this.advertComboBox.FormattingEnabled = true;
            this.advertComboBox.Items.AddRange(new object[] {
            "Рекомендация",
            "Insagram",
            "Сайт",
            "Яндекс карты",
            "Google карты",
            "2ГИС",
            "Органический трафик"});
            this.advertComboBox.Location = new System.Drawing.Point(254, 223);
            this.advertComboBox.Name = "advertComboBox";
            this.advertComboBox.Size = new System.Drawing.Size(231, 29);
            this.advertComboBox.TabIndex = 12;
            // 
            // studTargetComboBox
            // 
            this.studTargetComboBox.BackColor = System.Drawing.Color.Gray;
            this.studTargetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studTargetComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.studTargetComboBox.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studTargetComboBox.ForeColor = System.Drawing.Color.FloralWhite;
            this.studTargetComboBox.FormattingEnabled = true;
            this.studTargetComboBox.Items.AddRange(new object[] {
            "Видеомонтаж",
            "Программирование",
            "Компьютерная грамотность",
            "Учебный лагерь",
            "Подготовка к экзаменам"});
            this.studTargetComboBox.Location = new System.Drawing.Point(254, 283);
            this.studTargetComboBox.Name = "studTargetComboBox";
            this.studTargetComboBox.Size = new System.Drawing.Size(231, 29);
            this.studTargetComboBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Цель обучения:";
            // 
            // warningchecklabel
            // 
            this.warningchecklabel.AutoSize = true;
            this.warningchecklabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.warningchecklabel.ForeColor = System.Drawing.Color.Yellow;
            this.warningchecklabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.warningchecklabel.Location = new System.Drawing.Point(260, 24);
            this.warningchecklabel.Name = "warningchecklabel";
            this.warningchecklabel.Size = new System.Drawing.Size(206, 13);
            this.warningchecklabel.TabIndex = 15;
            this.warningchecklabel.Text = "*заполните все поля для воода данных";
            this.warningchecklabel.Visible = false;
            // 
            // buttonStudentReg
            // 
            this.buttonStudentReg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonStudentReg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonStudentReg.BackColor = System.Drawing.Color.Teal;
            this.buttonStudentReg.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonStudentReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudentReg.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.buttonStudentReg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonStudentReg.Location = new System.Drawing.Point(553, 345);
            this.buttonStudentReg.Name = "buttonStudentReg";
            this.buttonStudentReg.Size = new System.Drawing.Size(153, 38);
            this.buttonStudentReg.TabIndex = 16;
            this.buttonStudentReg.Text = "Добавить";
            this.buttonStudentReg.UseVisualStyleBackColor = false;
            this.buttonStudentReg.Click += new System.EventHandler(this.buttonStudentReg_Click);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(694, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 24);
            this.closeButton.TabIndex = 17;
            this.closeButton.Text = "x";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(249, 125);
            this.label3.MaximumSize = new System.Drawing.Size(130, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 50);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата рождения:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пол:";
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
            "Муж.",
            "Жен."});
            this.sexComboBox.Location = new System.Drawing.Point(74, 137);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(78, 29);
            this.sexComboBox.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.warningchecklabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 53);
            this.panel1.TabIndex = 18;
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDateTimePicker.CustomFormat = "dd MMM yyyy";
            this.birthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDateTimePicker.Location = new System.Drawing.Point(357, 149);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(107, 21);
            this.birthDateTimePicker.TabIndex = 22;
            this.birthDateTimePicker.Value = new System.DateTime(2021, 2, 14, 0, 0, 0, 0);
            // 
            // registerDateTimePicker
            // 
            this.registerDateTimePicker.CustomFormat = "dd MMM yyyy";
            this.registerDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.registerDateTimePicker.Location = new System.Drawing.Point(592, 149);
            this.registerDateTimePicker.Name = "registerDateTimePicker";
            this.registerDateTimePicker.Size = new System.Drawing.Size(107, 21);
            this.registerDateTimePicker.TabIndex = 23;
            this.registerDateTimePicker.Value = new System.DateTime(2021, 2, 14, 0, 0, 0, 0);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Gainsboro;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(387, 345);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(153, 38);
            this.cancelButton.TabIndex = 30;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // studentRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(718, 406);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.registerDateTimePicker);
            this.Controls.Add(this.birthDateTimePicker);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonStudentReg);
            this.Controls.Add(this.studTargetComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.advertComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastnameField);
            this.Controls.Add(this.surnameField);
            this.Controls.Add(this.nameField);
            this.Font = new System.Drawing.Font("Tekton Pro", 8.25F);
            this.ForeColor = System.Drawing.Color.FloralWhite;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "studentRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "studentRegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox surnameField;
        private System.Windows.Forms.TextBox LastnameField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox advertComboBox;
        private System.Windows.Forms.ComboBox studTargetComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label warningchecklabel;
        private System.Windows.Forms.Button buttonStudentReg;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.DateTimePicker registerDateTimePicker;
        private System.Windows.Forms.Button cancelButton;
    }
}