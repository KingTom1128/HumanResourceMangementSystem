namespace HRMSystem2019B
{
    partial class FormLogQuery
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
            this.lblHome = new System.Windows.Forms.LinkLabel();
            this.lblEnd = new System.Windows.Forms.LinkLabel();
            this.lblNext = new System.Windows.Forms.LinkLabel();
            this.lblLast = new System.Windows.Forms.LinkLabel();
            this.lblAll = new System.Windows.Forms.Label();
            this.lblNow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(28, 10);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 27;
            this.DataGridView.Size = new System.Drawing.Size(540, 297);
            this.DataGridView.TabIndex = 0;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Location = new System.Drawing.Point(324, 318);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(29, 12);
            this.lblHome.TabIndex = 7;
            this.lblHome.TabStop = true;
            this.lblHome.Text = "首页";
            this.lblHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblHome_LinkClicked);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(387, 318);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(29, 12);
            this.lblEnd.TabIndex = 8;
            this.lblEnd.TabStop = true;
            this.lblEnd.Text = "末页";
            this.lblEnd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEnd_LinkClicked);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(445, 318);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(41, 12);
            this.lblNext.TabIndex = 9;
            this.lblNext.TabStop = true;
            this.lblNext.Text = "下一页";
            this.lblNext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNext_LinkClicked);
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(508, 318);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(41, 12);
            this.lblLast.TabIndex = 10;
            this.lblLast.TabStop = true;
            this.lblLast.Text = "上一页";
            this.lblLast.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLast_LinkClicked);
            // 
            // lblAll
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.Location = new System.Drawing.Point(26, 318);
            this.lblAll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(0, 12);
            this.lblAll.TabIndex = 5;
            // 
            // lblNow
            // 
            this.lblNow.AutoSize = true;
            this.lblNow.Location = new System.Drawing.Point(87, 318);
            this.lblNow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNow.Name = "lblNow";
            this.lblNow.Size = new System.Drawing.Size(0, 12);
            this.lblNow.TabIndex = 6;
            // 
            // FormLogQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 367);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.lblNow);
            this.Controls.Add(this.lblAll);
            this.Controls.Add(this.DataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormLogQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLog";
            this.Load += new System.EventHandler(this.FormLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.LinkLabel lblHome;
        private System.Windows.Forms.LinkLabel lblEnd;
        private System.Windows.Forms.LinkLabel lblNext;
        private System.Windows.Forms.LinkLabel lblLast;
        private System.Windows.Forms.Label lblAll;
        private System.Windows.Forms.Label lblNow;
    }
}