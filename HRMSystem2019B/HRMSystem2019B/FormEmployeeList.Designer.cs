namespace HRMSystem2019B
{
    partial class FormEmployeeList
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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeOut = new System.Windows.Forms.DateTimePicker();
            this.TimeIn = new System.Windows.Forms.DateTimePicker();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chbTime = new System.Windows.Forms.CheckBox();
            this.chbDepartment = new System.Windows.Forms.CheckBox();
            this.chbName = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.grbSearch.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(21, 161);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 23;
            this.DataGridView.Size = new System.Drawing.Size(736, 164);
            this.DataGridView.TabIndex = 0;
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.btnSearch);
            this.grbSearch.Controls.Add(this.label1);
            this.grbSearch.Controls.Add(this.TimeOut);
            this.grbSearch.Controls.Add(this.TimeIn);
            this.grbSearch.Controls.Add(this.cmbDepartment);
            this.grbSearch.Controls.Add(this.txtName);
            this.grbSearch.Controls.Add(this.chbTime);
            this.grbSearch.Controls.Add(this.chbDepartment);
            this.grbSearch.Controls.Add(this.chbName);
            this.grbSearch.Location = new System.Drawing.Point(21, 57);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(735, 84);
            this.grbSearch.TabIndex = 1;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "搜索条件";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(288, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "到";
            // 
            // TimeOut
            // 
            this.TimeOut.Location = new System.Drawing.Point(548, 17);
            this.TimeOut.Name = "TimeOut";
            this.TimeOut.Size = new System.Drawing.Size(127, 21);
            this.TimeOut.TabIndex = 6;
            // 
            // TimeIn
            // 
            this.TimeIn.Location = new System.Drawing.Point(392, 17);
            this.TimeIn.Name = "TimeIn";
            this.TimeIn.Size = new System.Drawing.Size(127, 21);
            this.TimeIn.TabIndex = 5;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(85, 50);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(121, 20);
            this.cmbDepartment.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 21);
            this.txtName.TabIndex = 3;
            // 
            // chbTime
            // 
            this.chbTime.AutoSize = true;
            this.chbTime.Location = new System.Drawing.Point(288, 20);
            this.chbTime.Name = "chbTime";
            this.chbTime.Size = new System.Drawing.Size(72, 16);
            this.chbTime.TabIndex = 2;
            this.chbTime.Text = "入职时间";
            this.chbTime.UseVisualStyleBackColor = true;
            // 
            // chbDepartment
            // 
            this.chbDepartment.AutoSize = true;
            this.chbDepartment.Location = new System.Drawing.Point(21, 52);
            this.chbDepartment.Name = "chbDepartment";
            this.chbDepartment.Size = new System.Drawing.Size(48, 16);
            this.chbDepartment.TabIndex = 1;
            this.chbDepartment.Text = "部门";
            this.chbDepartment.UseVisualStyleBackColor = true;
            // 
            // chbName
            // 
            this.chbName.AutoSize = true;
            this.chbName.Location = new System.Drawing.Point(21, 20);
            this.chbName.Name = "chbName";
            this.chbName.Size = new System.Drawing.Size(48, 16);
            this.chbName.TabIndex = 0;
            this.chbName.Text = "姓名";
            this.chbName.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(780, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::HRMSystem2019B.Properties.Resources.add;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::HRMSystem2019B.Properties.Resources.edit;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::HRMSystem2019B.Properties.Resources.del;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::HRMSystem2019B.Properties.Resources.export;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // FormEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 337);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.DataGridView);
            this.Name = "FormEmployeeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmployeeList";
            this.Load += new System.EventHandler(this.FormEmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chbTime;
        private System.Windows.Forms.CheckBox chbDepartment;
        private System.Windows.Forms.CheckBox chbName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker TimeOut;
        private System.Windows.Forms.DateTimePicker TimeIn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}