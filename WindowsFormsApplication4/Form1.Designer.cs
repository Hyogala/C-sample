namespace WindowsFormsApplication4
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtHtml2 = new System.Windows.Forms.TextBox();
            this.txtTitle2 = new System.Windows.Forms.TextBox();
            this.lblView2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(542, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(48, 70);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(362, 19);
            this.txtUrl.TabIndex = 4;
            this.txtUrl.Text = "http://www.casleyconsulting.co.jp/";
            // 
            // txtHtml2
            // 
            this.txtHtml2.Location = new System.Drawing.Point(48, 179);
            this.txtHtml2.Multiline = true;
            this.txtHtml2.Name = "txtHtml2";
            this.txtHtml2.Size = new System.Drawing.Size(752, 334);
            this.txtHtml2.TabIndex = 2;
            // 
            // txtTitle2
            // 
            this.txtTitle2.Location = new System.Drawing.Point(48, 154);
            this.txtTitle2.Name = "txtTitle2";
            this.txtTitle2.Size = new System.Drawing.Size(866, 19);
            this.txtTitle2.TabIndex = 3;
            // 
            // lblView2
            // 
            this.lblView2.AutoSize = true;
            this.lblView2.Location = new System.Drawing.Point(48, 113);
            this.lblView2.Name = "lblView2";
            this.lblView2.Size = new System.Drawing.Size(0, 12);
            this.lblView2.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1213, 565);
            this.Controls.Add(this.lblView2);
            this.Controls.Add(this.txtTitle2);
            this.Controls.Add(this.txtHtml2);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label txtHtml;
        private System.Windows.Forms.TextBox lblView;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtHtml2;
        private System.Windows.Forms.TextBox txtTitle2;
        private System.Windows.Forms.Label lblView2;
    }
}

