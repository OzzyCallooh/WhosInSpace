namespace WhosInSpace {
    partial class WhosInSpaceForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.commandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewJson = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.urlTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.astrosListBox = new System.Windows.Forms.ListBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandToolStripMenuItem,
            this.urlTextBox,
            this.toolStripMenuItem1,
            this.refreshToolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(385, 27);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// commandToolStripMenuItem
			// 
			this.commandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewJson,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.commandToolStripMenuItem.Name = "commandToolStripMenuItem";
			this.commandToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
			this.commandToolStripMenuItem.Text = "File";
			// 
			// viewJson
			// 
			this.viewJson.Enabled = false;
			this.viewJson.Name = "viewJson";
			this.viewJson.Size = new System.Drawing.Size(130, 22);
			this.viewJson.Text = "View JSON";
			this.viewJson.Click += new System.EventHandler(this.viewJSONToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.ToolTipText = "Closes the application";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// urlTextBox
			// 
			this.urlTextBox.Name = "urlTextBox";
			this.urlTextBox.Size = new System.Drawing.Size(250, 23);
			this.urlTextBox.Text = "http://api.open-notify.org/astros.json";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 23);
			// 
			// refreshToolStripMenuItem1
			// 
			this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
			this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(58, 23);
			this.refreshToolStripMenuItem1.Text = "Refresh";
			this.refreshToolStripMenuItem1.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
			// 
			// astrosListBox
			// 
			this.astrosListBox.FormattingEnabled = true;
			this.astrosListBox.Location = new System.Drawing.Point(12, 27);
			this.astrosListBox.Name = "astrosListBox";
			this.astrosListBox.Size = new System.Drawing.Size(361, 225);
			this.astrosListBox.TabIndex = 1;
			// 
			// WhosInSpaceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(385, 265);
			this.Controls.Add(this.astrosListBox);
			this.Controls.Add(this.menuStrip1);
			this.Name = "WhosInSpaceForm";
			this.Text = "Who\'s in Space?";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem commandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox astrosListBox;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripTextBox urlTextBox;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem viewJson;
		private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
	}
}

