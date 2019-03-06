namespace HRMSystem2019B
{
    partial class FormMain
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRealName = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblIsDeleted = new System.Windows.Forms.Label();
            this.lblRealName = new System.Windows.Forms.Label();
            this.lblIsLocked = new System.Windows.Forms.Label();
            this.cmbIsDeleted = new System.Windows.Forms.ComboBox();
            this.cmbIsLocked = new System.Windows.Forms.ComboBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(22, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseEnter += new System.EventHandler(this.btnSearch_MouseEnter);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(22, 119);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(22, 175);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(22, 235);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(75, 30);
            this.btnLock.TabIndex = 3;
            this.btnLock.Text = "锁定";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            this.btnLock.MouseEnter += new System.EventHandler(this.btnLock_MouseEnter);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(192, 68);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 25);
            this.txtId.TabIndex = 4;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(192, 148);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 25);
            this.txtUserName.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(192, 232);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 25);
            this.txtPassword.TabIndex = 6;
            // 
            // txtRealName
            // 
            this.txtRealName.Location = new System.Drawing.Point(383, 148);
            this.txtRealName.Name = "txtRealName";
            this.txtRealName.Size = new System.Drawing.Size(100, 25);
            this.txtRealName.TabIndex = 8;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(132, 71);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 15);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "id";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(112, 151);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(71, 15);
            this.lblUserName.TabIndex = 11;
            this.lblUserName.Text = "UserName";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(112, 235);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 15);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password";
            // 
            // lblIsDeleted
            // 
            this.lblIsDeleted.AutoSize = true;
            this.lblIsDeleted.Location = new System.Drawing.Point(298, 71);
            this.lblIsDeleted.Name = "lblIsDeleted";
            this.lblIsDeleted.Size = new System.Drawing.Size(79, 15);
            this.lblIsDeleted.TabIndex = 13;
            this.lblIsDeleted.Text = "IsDeleted";
            // 
            // lblRealName
            // 
            this.lblRealName.AutoSize = true;
            this.lblRealName.Location = new System.Drawing.Point(298, 151);
            this.lblRealName.Name = "lblRealName";
            this.lblRealName.Size = new System.Drawing.Size(71, 15);
            this.lblRealName.TabIndex = 14;
            this.lblRealName.Text = "RealName";
            // 
            // lblIsLocked
            // 
            this.lblIsLocked.AutoSize = true;
            this.lblIsLocked.Location = new System.Drawing.Point(298, 235);
            this.lblIsLocked.Name = "lblIsLocked";
            this.lblIsLocked.Size = new System.Drawing.Size(71, 15);
            this.lblIsLocked.TabIndex = 15;
            this.lblIsLocked.Text = "IsLocked";
            // 
            // cmbIsDeleted
            // 
            this.cmbIsDeleted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsDeleted.FormattingEnabled = true;
            this.cmbIsDeleted.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbIsDeleted.Location = new System.Drawing.Point(383, 68);
            this.cmbIsDeleted.Name = "cmbIsDeleted";
            this.cmbIsDeleted.Size = new System.Drawing.Size(100, 23);
            this.cmbIsDeleted.TabIndex = 16;
            // 
            // cmbIsLocked
            // 
            this.cmbIsLocked.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsLocked.FormattingEnabled = true;
            this.cmbIsLocked.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbIsLocked.Location = new System.Drawing.Point(383, 232);
            this.cmbIsLocked.Name = "cmbIsLocked";
            this.cmbIsLocked.Size = new System.Drawing.Size(100, 23);
            this.cmbIsLocked.TabIndex = 17;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(19, 292);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(0, 15);
            this.lblDisplay.TabIndex = 18;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(25, 357);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(458, 40);
            this.btnChangePassword.TabIndex = 19;
            this.btnChangePassword.Text = "修改密码";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 434);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.cmbIsLocked);
            this.Controls.Add(this.cmbIsDeleted);
            this.Controls.Add(this.lblIsLocked);
            this.Controls.Add(this.lblRealName);
            this.Controls.Add(this.lblIsDeleted);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtRealName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRealName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblIsDeleted;
        private System.Windows.Forms.Label lblRealName;
        private System.Windows.Forms.Label lblIsLocked;
        private System.Windows.Forms.ComboBox cmbIsDeleted;
        private System.Windows.Forms.ComboBox cmbIsLocked;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnChangePassword;
    }
}