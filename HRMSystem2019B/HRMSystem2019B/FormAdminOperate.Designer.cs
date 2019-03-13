namespace HRMSystem2019B
{
    partial class FormAdminOperate
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
            this.cmbIsLocked = new System.Windows.Forms.ComboBox();
            this.cmbIsDeleted = new System.Windows.Forms.ComboBox();
            this.lblIsLocked = new System.Windows.Forms.Label();
            this.lblRealName = new System.Windows.Forms.Label();
            this.lblIsDeleted = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtRealName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbIsLocked
            // 
            this.cmbIsLocked.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsLocked.FormattingEnabled = true;
            this.cmbIsLocked.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbIsLocked.Location = new System.Drawing.Point(523, 243);
            this.cmbIsLocked.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbIsLocked.Name = "cmbIsLocked";
            this.cmbIsLocked.Size = new System.Drawing.Size(100, 23);
            this.cmbIsLocked.TabIndex = 33;
            // 
            // cmbIsDeleted
            // 
            this.cmbIsDeleted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsDeleted.FormattingEnabled = true;
            this.cmbIsDeleted.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbIsDeleted.Location = new System.Drawing.Point(523, 79);
            this.cmbIsDeleted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbIsDeleted.Name = "cmbIsDeleted";
            this.cmbIsDeleted.Size = new System.Drawing.Size(100, 23);
            this.cmbIsDeleted.TabIndex = 32;
            // 
            // lblIsLocked
            // 
            this.lblIsLocked.AutoSize = true;
            this.lblIsLocked.Location = new System.Drawing.Point(439, 246);
            this.lblIsLocked.Name = "lblIsLocked";
            this.lblIsLocked.Size = new System.Drawing.Size(71, 15);
            this.lblIsLocked.TabIndex = 31;
            this.lblIsLocked.Text = "IsLocked";
            // 
            // lblRealName
            // 
            this.lblRealName.AutoSize = true;
            this.lblRealName.Location = new System.Drawing.Point(439, 162);
            this.lblRealName.Name = "lblRealName";
            this.lblRealName.Size = new System.Drawing.Size(71, 15);
            this.lblRealName.TabIndex = 30;
            this.lblRealName.Text = "RealName";
            // 
            // lblIsDeleted
            // 
            this.lblIsDeleted.AutoSize = true;
            this.lblIsDeleted.Location = new System.Drawing.Point(439, 82);
            this.lblIsDeleted.Name = "lblIsDeleted";
            this.lblIsDeleted.Size = new System.Drawing.Size(79, 15);
            this.lblIsDeleted.TabIndex = 29;
            this.lblIsDeleted.Text = "IsDeleted";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(252, 246);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 15);
            this.lblPassword.TabIndex = 28;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(252, 162);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(71, 15);
            this.lblUserName.TabIndex = 27;
            this.lblUserName.Text = "UserName";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(272, 82);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 15);
            this.lblId.TabIndex = 26;
            this.lblId.Text = "id";
            // 
            // txtRealName
            // 
            this.txtRealName.Location = new System.Drawing.Point(523, 159);
            this.txtRealName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRealName.Name = "txtRealName";
            this.txtRealName.Size = new System.Drawing.Size(100, 25);
            this.txtRealName.TabIndex = 25;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(332, 243);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 25);
            this.txtPassword.TabIndex = 24;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(332, 159);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 25);
            this.txtUserName.TabIndex = 23;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(332, 79);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 25);
            this.txtId.TabIndex = 22;
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(161, 246);
            this.btnLock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(75, 30);
            this.btnLock.TabIndex = 21;
            this.btnLock.Text = "锁定";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            this.btnLock.MouseEnter += new System.EventHandler(this.btnLock_MouseEnter);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(161, 186);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(161, 130);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(161, 73);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseEnter += new System.EventHandler(this.btnSearch_MouseEnter);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(158, 330);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(0, 15);
            this.lblDisplay.TabIndex = 34;
            // 
            // FormAdminOperate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "FormAdminOperate";
            this.Text = "FormAdminOperate";
            this.Load += new System.EventHandler(this.FormAdminOperate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIsLocked;
        private System.Windows.Forms.ComboBox cmbIsDeleted;
        private System.Windows.Forms.Label lblIsLocked;
        private System.Windows.Forms.Label lblRealName;
        private System.Windows.Forms.Label lblIsDeleted;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtRealName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDisplay;
    }
}