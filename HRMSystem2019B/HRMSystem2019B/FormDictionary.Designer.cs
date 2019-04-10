namespace HRMSystem2019B
{
    partial class FormDictionary
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.btnAddSex = new System.Windows.Forms.Button();
            this.btnDeleteSex = new System.Windows.Forms.Button();
            this.btuUpdateSex = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdateEdu = new System.Windows.Forms.Button();
            this.btnDeleteEdu = new System.Windows.Forms.Button();
            this.btnAddEdu = new System.Windows.Forms.Button();
            this.txtEdu = new System.Windows.Forms.TextBox();
            this.cmbEducation = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdateState = new System.Windows.Forms.Button();
            this.btnDeleteState = new System.Windows.Forms.Button();
            this.btnAddState = new System.Windows.Forms.Button();
            this.txtState = new System.Windows.Forms.TextBox();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUpdateMarry = new System.Windows.Forms.Button();
            this.btnDeleteMarry = new System.Windows.Forms.Button();
            this.btnAddMarry = new System.Windows.Forms.Button();
            this.txtMarry = new System.Windows.Forms.TextBox();
            this.cmbMarry = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btuUpdateSex);
            this.groupBox1.Controls.Add(this.btnDeleteSex);
            this.groupBox1.Controls.Add(this.btnAddSex);
            this.groupBox1.Controls.Add(this.txtSex);
            this.groupBox1.Controls.Add(this.cmbSex);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "性别";
            // 
            // cmbSex
            // 
            this.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Location = new System.Drawing.Point(53, 36);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(121, 23);
            this.cmbSex.TabIndex = 0;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(41, 128);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(145, 25);
            this.txtSex.TabIndex = 1;
            // 
            // btnAddSex
            // 
            this.btnAddSex.Location = new System.Drawing.Point(76, 179);
            this.btnAddSex.Name = "btnAddSex";
            this.btnAddSex.Size = new System.Drawing.Size(75, 33);
            this.btnAddSex.TabIndex = 2;
            this.btnAddSex.Text = "增加";
            this.btnAddSex.UseVisualStyleBackColor = true;
            this.btnAddSex.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeleteSex
            // 
            this.btnDeleteSex.Location = new System.Drawing.Point(76, 218);
            this.btnDeleteSex.Name = "btnDeleteSex";
            this.btnDeleteSex.Size = new System.Drawing.Size(75, 33);
            this.btnDeleteSex.TabIndex = 3;
            this.btnDeleteSex.Text = "删除";
            this.btnDeleteSex.UseVisualStyleBackColor = true;
            this.btnDeleteSex.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btuUpdateSex
            // 
            this.btuUpdateSex.Location = new System.Drawing.Point(76, 257);
            this.btuUpdateSex.Name = "btuUpdateSex";
            this.btuUpdateSex.Size = new System.Drawing.Size(75, 33);
            this.btuUpdateSex.TabIndex = 4;
            this.btuUpdateSex.Text = "修改";
            this.btuUpdateSex.UseVisualStyleBackColor = true;
            this.btuUpdateSex.Click += new System.EventHandler(this.btuUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdateEdu);
            this.groupBox2.Controls.Add(this.btnDeleteEdu);
            this.groupBox2.Controls.Add(this.btnAddEdu);
            this.groupBox2.Controls.Add(this.txtEdu);
            this.groupBox2.Controls.Add(this.cmbEducation);
            this.groupBox2.Location = new System.Drawing.Point(265, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 365);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "学历";
            // 
            // btnUpdateEdu
            // 
            this.btnUpdateEdu.Location = new System.Drawing.Point(76, 257);
            this.btnUpdateEdu.Name = "btnUpdateEdu";
            this.btnUpdateEdu.Size = new System.Drawing.Size(75, 33);
            this.btnUpdateEdu.TabIndex = 4;
            this.btnUpdateEdu.Text = "修改";
            this.btnUpdateEdu.UseVisualStyleBackColor = true;
            this.btnUpdateEdu.Click += new System.EventHandler(this.btnUpdateEdu_Click);
            // 
            // btnDeleteEdu
            // 
            this.btnDeleteEdu.Location = new System.Drawing.Point(76, 218);
            this.btnDeleteEdu.Name = "btnDeleteEdu";
            this.btnDeleteEdu.Size = new System.Drawing.Size(75, 33);
            this.btnDeleteEdu.TabIndex = 3;
            this.btnDeleteEdu.Text = "删除";
            this.btnDeleteEdu.UseVisualStyleBackColor = true;
            this.btnDeleteEdu.Click += new System.EventHandler(this.btnDeleteEdu_Click);
            // 
            // btnAddEdu
            // 
            this.btnAddEdu.Location = new System.Drawing.Point(76, 179);
            this.btnAddEdu.Name = "btnAddEdu";
            this.btnAddEdu.Size = new System.Drawing.Size(75, 33);
            this.btnAddEdu.TabIndex = 2;
            this.btnAddEdu.Text = "增加";
            this.btnAddEdu.UseVisualStyleBackColor = true;
            this.btnAddEdu.Click += new System.EventHandler(this.btnAddEdu_Click);
            // 
            // txtEdu
            // 
            this.txtEdu.Location = new System.Drawing.Point(41, 128);
            this.txtEdu.Name = "txtEdu";
            this.txtEdu.Size = new System.Drawing.Size(145, 25);
            this.txtEdu.TabIndex = 1;
            // 
            // cmbEducation
            // 
            this.cmbEducation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEducation.FormattingEnabled = true;
            this.cmbEducation.Location = new System.Drawing.Point(53, 36);
            this.cmbEducation.Name = "cmbEducation";
            this.cmbEducation.Size = new System.Drawing.Size(121, 23);
            this.cmbEducation.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUpdateState);
            this.groupBox3.Controls.Add(this.btnDeleteState);
            this.groupBox3.Controls.Add(this.btnAddState);
            this.groupBox3.Controls.Add(this.txtState);
            this.groupBox3.Controls.Add(this.cmbState);
            this.groupBox3.Location = new System.Drawing.Point(501, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 365);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "政治面貌";
            // 
            // btnUpdateState
            // 
            this.btnUpdateState.Location = new System.Drawing.Point(76, 257);
            this.btnUpdateState.Name = "btnUpdateState";
            this.btnUpdateState.Size = new System.Drawing.Size(75, 33);
            this.btnUpdateState.TabIndex = 4;
            this.btnUpdateState.Text = "修改";
            this.btnUpdateState.UseVisualStyleBackColor = true;
            this.btnUpdateState.Click += new System.EventHandler(this.btnUpdateState_Click);
            // 
            // btnDeleteState
            // 
            this.btnDeleteState.Location = new System.Drawing.Point(76, 218);
            this.btnDeleteState.Name = "btnDeleteState";
            this.btnDeleteState.Size = new System.Drawing.Size(75, 33);
            this.btnDeleteState.TabIndex = 3;
            this.btnDeleteState.Text = "删除";
            this.btnDeleteState.UseVisualStyleBackColor = true;
            this.btnDeleteState.Click += new System.EventHandler(this.btnDeleteState_Click);
            // 
            // btnAddState
            // 
            this.btnAddState.Location = new System.Drawing.Point(76, 179);
            this.btnAddState.Name = "btnAddState";
            this.btnAddState.Size = new System.Drawing.Size(75, 33);
            this.btnAddState.TabIndex = 2;
            this.btnAddState.Text = "增加";
            this.btnAddState.UseVisualStyleBackColor = true;
            this.btnAddState.Click += new System.EventHandler(this.btnAddState_Click);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(41, 128);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(145, 25);
            this.txtState.TabIndex = 1;
            // 
            // cmbState
            // 
            this.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(53, 36);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(121, 23);
            this.cmbState.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnUpdateMarry);
            this.groupBox4.Controls.Add(this.btnDeleteMarry);
            this.groupBox4.Controls.Add(this.btnAddMarry);
            this.groupBox4.Controls.Add(this.txtMarry);
            this.groupBox4.Controls.Add(this.cmbMarry);
            this.groupBox4.Location = new System.Drawing.Point(737, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(230, 365);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "婚姻情况";
            // 
            // btnUpdateMarry
            // 
            this.btnUpdateMarry.Location = new System.Drawing.Point(76, 257);
            this.btnUpdateMarry.Name = "btnUpdateMarry";
            this.btnUpdateMarry.Size = new System.Drawing.Size(75, 33);
            this.btnUpdateMarry.TabIndex = 4;
            this.btnUpdateMarry.Text = "修改";
            this.btnUpdateMarry.UseVisualStyleBackColor = true;
            this.btnUpdateMarry.Click += new System.EventHandler(this.btnUpdateMarry_Click);
            // 
            // btnDeleteMarry
            // 
            this.btnDeleteMarry.Location = new System.Drawing.Point(76, 218);
            this.btnDeleteMarry.Name = "btnDeleteMarry";
            this.btnDeleteMarry.Size = new System.Drawing.Size(75, 33);
            this.btnDeleteMarry.TabIndex = 3;
            this.btnDeleteMarry.Text = "删除";
            this.btnDeleteMarry.UseVisualStyleBackColor = true;
            this.btnDeleteMarry.Click += new System.EventHandler(this.btnDeleteMarry_Click);
            // 
            // btnAddMarry
            // 
            this.btnAddMarry.Location = new System.Drawing.Point(76, 179);
            this.btnAddMarry.Name = "btnAddMarry";
            this.btnAddMarry.Size = new System.Drawing.Size(75, 33);
            this.btnAddMarry.TabIndex = 2;
            this.btnAddMarry.Text = "增加";
            this.btnAddMarry.UseVisualStyleBackColor = true;
            this.btnAddMarry.Click += new System.EventHandler(this.btnAddMarry_Click);
            // 
            // txtMarry
            // 
            this.txtMarry.Location = new System.Drawing.Point(41, 128);
            this.txtMarry.Name = "txtMarry";
            this.txtMarry.Size = new System.Drawing.Size(145, 25);
            this.txtMarry.TabIndex = 1;
            // 
            // cmbMarry
            // 
            this.cmbMarry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarry.FormattingEnabled = true;
            this.cmbMarry.Location = new System.Drawing.Point(53, 36);
            this.cmbMarry.Name = "cmbMarry";
            this.cmbMarry.Size = new System.Drawing.Size(121, 23);
            this.cmbMarry.TabIndex = 0;
            // 
            // FormDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDictionary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDictionary";
            this.Load += new System.EventHandler(this.FormDictionary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btuUpdateSex;
        private System.Windows.Forms.Button btnDeleteSex;
        private System.Windows.Forms.Button btnAddSex;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdateEdu;
        private System.Windows.Forms.Button btnDeleteEdu;
        private System.Windows.Forms.Button btnAddEdu;
        private System.Windows.Forms.TextBox txtEdu;
        private System.Windows.Forms.ComboBox cmbEducation;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUpdateState;
        private System.Windows.Forms.Button btnDeleteState;
        private System.Windows.Forms.Button btnAddState;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUpdateMarry;
        private System.Windows.Forms.Button btnDeleteMarry;
        private System.Windows.Forms.Button btnAddMarry;
        private System.Windows.Forms.TextBox txtMarry;
        private System.Windows.Forms.ComboBox cmbMarry;
    }
}