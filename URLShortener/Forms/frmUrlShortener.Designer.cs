namespace URLShortener
{
    partial class frmUrlShortener
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
            this.btnShorten = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.chkReadable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnShorten
            // 
            this.btnShorten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShorten.Enabled = false;
            this.btnShorten.Location = new System.Drawing.Point(12, 82);
            this.btnShorten.Name = "btnShorten";
            this.btnShorten.Size = new System.Drawing.Size(260, 63);
            this.btnShorten.TabIndex = 0;
            this.btnShorten.Text = "Shorten";
            this.btnShorten.UseVisualStyleBackColor = true;
            this.btnShorten.Click += new System.EventHandler(this.btnShorten_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUrl.Location = new System.Drawing.Point(12, 56);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(260, 20);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            // 
            // lblUrl
            // 
            this.lblUrl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(12, 37);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(116, 13);
            this.lblUrl.TabIndex = 2;
            this.lblUrl.Text = "Enter a URL to shorten";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtResult.Location = new System.Drawing.Point(12, 317);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(260, 20);
            this.txtResult.TabIndex = 3;
            this.txtResult.Click += new System.EventHandler(this.txtResult_Click);
            // 
            // lblResult
            // 
            this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(13, 298);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(121, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result (Click to copy url)";
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpen.Enabled = false;
            this.btnOpen.Location = new System.Drawing.Point(12, 151);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(260, 63);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // chkReadable
            // 
            this.chkReadable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkReadable.AutoSize = true;
            this.chkReadable.Checked = true;
            this.chkReadable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReadable.Location = new System.Drawing.Point(200, 220);
            this.chkReadable.Name = "chkReadable";
            this.chkReadable.Size = new System.Drawing.Size(72, 17);
            this.chkReadable.TabIndex = 6;
            this.chkReadable.Text = "Readable";
            this.chkReadable.UseVisualStyleBackColor = true;
            // 
            // frmUrlShortener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 349);
            this.Controls.Add(this.chkReadable);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnShorten);
            this.Name = "frmUrlShortener";
            this.Text = "URL Shortener";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShorten;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.CheckBox chkReadable;
    }
}

