namespace HRMSystem2019B
{
    partial class FormDepartment
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
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOld = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbAdd = new System.Windows.Forms.GroupBox();
            this.grbShow = new System.Windows.Forms.GroupBox();
            this.lblShow = new System.Windows.Forms.Label();
            this.grpDelete.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpUpdate.SuspendLayout();
            this.grbAdd.SuspendLayout();
            this.grbShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDelete
            // 
            this.grpDelete.Controls.Add(this.btnDelete);
            this.grpDelete.Controls.Add(this.txtDelete);
            this.grpDelete.Controls.Add(this.label2);
            this.grpDelete.Location = new System.Drawing.Point(228, 64);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Size = new System.Drawing.Size(171, 273);
            this.grpDelete.TabIndex = 1;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "删除";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.label3);
            this.grpSearch.Location = new System.Drawing.Point(405, 64);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(171, 273);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "查找";
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.btnUpdate);
            this.grpUpdate.Controls.Add(this.txtNew);
            this.grpUpdate.Controls.Add(this.label5);
            this.grpUpdate.Controls.Add(this.txtOld);
            this.grpUpdate.Controls.Add(this.label4);
            this.grpUpdate.Location = new System.Drawing.Point(582, 64);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(171, 273);
            this.grpUpdate.TabIndex = 1;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "修改";
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(35, 89);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(100, 25);
            this.txtDelete.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "部门名称：";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(41, 89);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 25);
            this.txtSearch.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "部门名称：";
            // 
            // txtOld
            // 
            this.txtOld.Location = new System.Drawing.Point(39, 89);
            this.txtOld.Name = "txtOld";
            this.txtOld.Size = new System.Drawing.Size(100, 25);
            this.txtOld.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "部门旧名称：";
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(39, 181);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(100, 25);
            this.txtNew.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "部门新名称：";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(48, 171);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "确认";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(54, 171);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "确认";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(51, 228);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "确认";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "部门名称：";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(36, 89);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(100, 25);
            this.txtAdd.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(49, 171);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "确认";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grbAdd
            // 
            this.grbAdd.Controls.Add(this.btnAdd);
            this.grbAdd.Controls.Add(this.txtAdd);
            this.grbAdd.Controls.Add(this.label1);
            this.grbAdd.Location = new System.Drawing.Point(51, 64);
            this.grbAdd.Name = "grbAdd";
            this.grbAdd.Size = new System.Drawing.Size(171, 273);
            this.grbAdd.TabIndex = 0;
            this.grbAdd.TabStop = false;
            this.grbAdd.Text = "增加";
            // 
            // grbShow
            // 
            this.grbShow.Controls.Add(this.lblShow);
            this.grbShow.Location = new System.Drawing.Point(51, 349);
            this.grbShow.Name = "grbShow";
            this.grbShow.Size = new System.Drawing.Size(701, 82);
            this.grbShow.TabIndex = 2;
            this.grbShow.TabStop = false;
            this.grbShow.Text = "查找部门信息：";
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(22, 21);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(0, 15);
            this.lblShow.TabIndex = 0;
            // 
            // FormDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbShow);
            this.Controls.Add(this.grpDelete);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.grbAdd);
            this.Name = "FormDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDepartment";
            this.grpDelete.ResumeLayout(false);
            this.grpDelete.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.grbAdd.ResumeLayout(false);
            this.grbAdd.PerformLayout();
            this.grbShow.ResumeLayout(false);
            this.grbShow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpDelete;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOld;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grbAdd;
        private System.Windows.Forms.GroupBox grbShow;
        private System.Windows.Forms.Label lblShow;
    }
}