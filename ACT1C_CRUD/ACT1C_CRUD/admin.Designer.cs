namespace ACT1C_CRUD
{
    partial class admin
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
            cbRole = new ComboBox();
            btnLogout = new Button();
            btnSearch = new Button();
            panel6 = new Panel();
            txtSearch = new TextBox();
            panel5 = new Panel();
            panel4 = new Panel();
            label6 = new Label();
            txtID = new TextBox();
            label5 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnAdd = new Button();
            panel3 = new Panel();
            txtName = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            txtPassword = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            txtUsername = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Admin", "Student", "Teacher", "Blocked" });
            cbRole.Location = new Point(43, 378);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(226, 23);
            cbRole.TabIndex = 188;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DarkRed;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(603, 49);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(171, 44);
            btnLogout.TabIndex = 187;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Green;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(620, 144);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(115, 25);
            btnSearch.TabIndex = 186;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.HotTrack;
            panel6.Location = new Point(314, 168);
            panel6.Name = "panel6";
            panel6.Size = new Size(300, 2);
            panel6.TabIndex = 184;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.DimGray;
            txtSearch.Location = new Point(313, 144);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(301, 25);
            txtSearch.TabIndex = 185;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.HotTrack;
            panel5.Location = new Point(44, 401);
            panel5.Name = "panel5";
            panel5.Size = new Size(225, 2);
            panel5.TabIndex = 178;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.HotTrack;
            panel4.Location = new Point(46, 129);
            panel4.Name = "panel4";
            panel4.Size = new Size(225, 2);
            panel4.TabIndex = 182;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(41, 353);
            label6.Name = "label6";
            label6.Size = new Size(38, 17);
            label6.TabIndex = 176;
            label6.Text = "Role";
            // 
            // txtID
            // 
            txtID.BackColor = Color.White;
            txtID.BorderStyle = BorderStyle.None;
            txtID.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtID.ForeColor = Color.DimGray;
            txtID.Location = new Point(45, 105);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(226, 25);
            txtID.TabIndex = 183;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(43, 81);
            label5.Name = "label5";
            label5.Size = new Size(17, 17);
            label5.TabIndex = 181;
            label5.Text = "#";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(314, 62);
            label1.Name = "label1";
            label1.Size = new Size(148, 37);
            label1.TabIndex = 180;
            label1.Text = "Welcome,";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(314, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(421, 366);
            dataGridView1.TabIndex = 179;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.HotTrack;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(46, 466);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(226, 44);
            btnUpdate.TabIndex = 169;
            btnUpdate.Text = "Update Account";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.DarkRed;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(46, 516);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(226, 44);
            btnRemove.TabIndex = 170;
            btnRemove.Text = "Remove Account";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(45, 415);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(226, 44);
            btnAdd.TabIndex = 168;
            btnAdd.Text = "Add Account";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Location = new Point(45, 192);
            panel3.Name = "panel3";
            panel3.Size = new Size(225, 2);
            panel3.TabIndex = 177;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.DimGray;
            txtName.Location = new Point(44, 168);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(226, 25);
            txtName.TabIndex = 165;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(42, 144);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 175;
            label4.Text = "Name";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Location = new Point(45, 337);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 2);
            panel2.TabIndex = 174;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(44, 313);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(226, 25);
            txtPassword.TabIndex = 167;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(42, 289);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 173;
            label3.Text = "Password";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Location = new Point(45, 261);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 2);
            panel1.TabIndex = 172;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.DimGray;
            txtUsername.Location = new Point(44, 237);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(226, 25);
            txtUsername.TabIndex = 166;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(42, 213);
            label2.Name = "label2";
            label2.Size = new Size(75, 17);
            label2.TabIndex = 171;
            label2.Text = "Username";
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 607);
            Controls.Add(cbRole);
            Controls.Add(btnLogout);
            Controls.Add(btnSearch);
            Controls.Add(panel6);
            Controls.Add(txtSearch);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(label6);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdate);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(panel3);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Name = "admin";
            Text = "admin";
            Load += admin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbRole;
        private Button btnLogout;
        private Button btnSearch;
        private Panel panel6;
        private TextBox txtSearch;
        private Panel panel5;
        private Panel panel4;
        private Label label6;
        private TextBox txtID;
        private Label label5;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnUpdate;
        private Button btnRemove;
        private Button btnAdd;
        private Panel panel3;
        private TextBox txtName;
        private Label label4;
        private Panel panel2;
        private TextBox txtPassword;
        private Label label3;
        private Panel panel1;
        private TextBox txtUsername;
        private Label label2;
    }
}