namespace ACT1C_CRUD
{
    partial class register
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
            btnBackSignIn = new Button();
            btnRegisterAccount = new Button();
            panel3 = new Panel();
            txtName = new TextBox();
            label1 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            txtPassword = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            txtUsername = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnBackSignIn
            // 
            btnBackSignIn.BackColor = SystemColors.HotTrack;
            btnBackSignIn.FlatAppearance.BorderSize = 0;
            btnBackSignIn.FlatStyle = FlatStyle.Flat;
            btnBackSignIn.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackSignIn.ForeColor = Color.White;
            btnBackSignIn.Location = new Point(36, 370);
            btnBackSignIn.Name = "btnBackSignIn";
            btnBackSignIn.Size = new Size(226, 44);
            btnBackSignIn.TabIndex = 34;
            btnBackSignIn.Text = "Sign In";
            btnBackSignIn.UseVisualStyleBackColor = false;
            btnBackSignIn.Click += btnBackSignIn_Click;
            // 
            // btnRegisterAccount
            // 
            btnRegisterAccount.BackColor = Color.Green;
            btnRegisterAccount.FlatAppearance.BorderSize = 0;
            btnRegisterAccount.FlatStyle = FlatStyle.Flat;
            btnRegisterAccount.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterAccount.ForeColor = Color.White;
            btnRegisterAccount.Location = new Point(36, 307);
            btnRegisterAccount.Name = "btnRegisterAccount";
            btnRegisterAccount.Size = new Size(226, 44);
            btnRegisterAccount.TabIndex = 30;
            btnRegisterAccount.Text = "Register Account";
            btnRegisterAccount.UseVisualStyleBackColor = false;
            btnRegisterAccount.Click += btnRegisterAccount_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Location = new Point(37, 143);
            panel3.Name = "panel3";
            panel3.Size = new Size(225, 2);
            panel3.TabIndex = 41;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.DimGray;
            txtName.Location = new Point(36, 119);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter your name";
            txtName.Size = new Size(226, 25);
            txtName.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(94, 21);
            label1.Name = "label1";
            label1.Size = new Size(119, 37);
            label1.TabIndex = 39;
            label1.Text = "Sign Up";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(34, 95);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 40;
            label4.Text = "Name";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Location = new Point(37, 288);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 2);
            panel2.TabIndex = 38;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(36, 264);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(226, 25);
            txtPassword.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(34, 240);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 37;
            label3.Text = "Password";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Location = new Point(37, 212);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 2);
            panel1.TabIndex = 36;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.DimGray;
            txtUsername.Location = new Point(36, 188);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your username";
            txtUsername.Size = new Size(226, 25);
            txtUsername.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(34, 164);
            label2.Name = "label2";
            label2.Size = new Size(75, 17);
            label2.TabIndex = 35;
            label2.Text = "Username";
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 443);
            Controls.Add(btnBackSignIn);
            Controls.Add(btnRegisterAccount);
            Controls.Add(panel3);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Name = "register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackSignIn;
        private Button btnRegisterAccount;
        private Panel panel3;
        private TextBox txtName;
        private Label label1;
        private Label label4;
        private Panel panel2;
        private TextBox txtPassword;
        private Label label3;
        private Panel panel1;
        private TextBox txtUsername;
        private Label label2;
    }
}