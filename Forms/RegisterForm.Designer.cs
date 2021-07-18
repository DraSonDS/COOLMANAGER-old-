
namespace ExampleSQLApp
{
    partial class RegisterForm
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
            this.AutLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.registerLabel = new System.Windows.Forms.Label();
            this.warningchecklabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.userSurnameField = new System.Windows.Forms.TextBox();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.postComboBox = new System.Windows.Forms.ComboBox();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutLabel
            // 
            this.AutLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AutLabel.AutoSize = true;
            this.AutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AutLabel.Location = new System.Drawing.Point(115, 42);
            this.AutLabel.Name = "AutLabel";
            this.AutLabel.Size = new System.Drawing.Size(229, 26);
            this.AutLabel.TabIndex = 0;
            this.AutLabel.Text = "Новый пользователь";
            this.AutLabel.Click += new System.EventHandler(this.AutLabel_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainPanel.Controls.Add(this.postComboBox);
            this.MainPanel.Controls.Add(this.registerLabel);
            this.MainPanel.Controls.Add(this.warningchecklabel);
            this.MainPanel.Controls.Add(this.warningLabel);
            this.MainPanel.Controls.Add(this.userSurnameField);
            this.MainPanel.Controls.Add(this.userNameField);
            this.MainPanel.Controls.Add(this.AutLabel);
            this.MainPanel.Controls.Add(this.closeButton);
            this.MainPanel.Controls.Add(this.buttonLogin);
            this.MainPanel.Controls.Add(this.passField);
            this.MainPanel.Controls.Add(this.loginField);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(491, 623);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.registerLabel.ForeColor = System.Drawing.Color.White;
            this.registerLabel.Location = new System.Drawing.Point(187, 556);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(101, 15);
            this.registerLabel.TabIndex = 9;
            this.registerLabel.Text = "Войти в аккаунт";
            this.registerLabel.Click += new System.EventHandler(this.registerLabel_Click);
            // 
            // warningchecklabel
            // 
            this.warningchecklabel.AutoSize = true;
            this.warningchecklabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.warningchecklabel.ForeColor = System.Drawing.Color.Yellow;
            this.warningchecklabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.warningchecklabel.Location = new System.Drawing.Point(117, 96);
            this.warningchecklabel.Name = "warningchecklabel";
            this.warningchecklabel.Size = new System.Drawing.Size(222, 13);
            this.warningchecklabel.TabIndex = 8;
            this.warningchecklabel.Text = "*такой пользоваель уже зарегистрирован";
            this.warningchecklabel.Visible = false;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.warningLabel.ForeColor = System.Drawing.Color.Yellow;
            this.warningLabel.Location = new System.Drawing.Point(117, 96);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(200, 13);
            this.warningLabel.TabIndex = 7;
            this.warningLabel.Text = "*заполните все поля для регистрации";
            this.warningLabel.Visible = false;
            // 
            // userSurnameField
            // 
            this.userSurnameField.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.userSurnameField.Location = new System.Drawing.Point(120, 200);
            this.userSurnameField.Name = "userSurnameField";
            this.userSurnameField.Size = new System.Drawing.Size(238, 39);
            this.userSurnameField.TabIndex = 5;
            this.userSurnameField.TextChanged += new System.EventHandler(this.userSurnameField_TextChanged);
            this.userSurnameField.Enter += new System.EventHandler(this.userSurnameField_Enter);
            this.userSurnameField.Leave += new System.EventHandler(this.userSurnameField_Leave);
            // 
            // userNameField
            // 
            this.userNameField.AccessibleDescription = "";
            this.userNameField.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.userNameField.Location = new System.Drawing.Point(120, 130);
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(238, 39);
            this.userNameField.TabIndex = 6;
            this.userNameField.Tag = "";
            this.userNameField.Enter += new System.EventHandler(this.userNameField_Enter);
            this.userNameField.Leave += new System.EventHandler(this.userNameField_Leave);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(464, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 24);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "x";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogin.Location = new System.Drawing.Point(161, 498);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(153, 38);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Регистрация";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.passField.Location = new System.Drawing.Point(120, 337);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(238, 39);
            this.passField.TabIndex = 1;
            this.passField.UseSystemPasswordChar = true;
            this.passField.Enter += new System.EventHandler(this.passField_Enter);
            this.passField.Leave += new System.EventHandler(this.passField_Leave);
            // 
            // loginField
            // 
            this.loginField.AccessibleDescription = "";
            this.loginField.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.loginField.Location = new System.Drawing.Point(120, 266);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(238, 39);
            this.loginField.TabIndex = 1;
            this.loginField.Tag = "";
            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // postComboBox
            // 
            this.postComboBox.BackColor = System.Drawing.Color.Gray;
            this.postComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.postComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.postComboBox.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postComboBox.ForeColor = System.Drawing.Color.FloralWhite;
            this.postComboBox.FormattingEnabled = true;
            this.postComboBox.Items.AddRange(new object[] {
            "Учитель",
            "Администратор",
            "Директор"});
            this.postComboBox.Location = new System.Drawing.Point(120, 404);
            this.postComboBox.Name = "postComboBox";
            this.postComboBox.Size = new System.Drawing.Size(238, 29);
            this.postComboBox.TabIndex = 10;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 623);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AutLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.TextBox userSurnameField;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label warningchecklabel;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.ComboBox postComboBox;
    }
}