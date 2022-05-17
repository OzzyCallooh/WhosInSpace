namespace WhosInSpace {
	partial class TextDisplayForm {
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
			this.jsonBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// jsonBox
			// 
			this.jsonBox.AcceptsTab = true;
			this.jsonBox.Location = new System.Drawing.Point(12, 12);
			this.jsonBox.Multiline = true;
			this.jsonBox.Name = "jsonBox";
			this.jsonBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.jsonBox.Size = new System.Drawing.Size(356, 306);
			this.jsonBox.TabIndex = 0;
			// 
			// TextDisplayForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 330);
			this.Controls.Add(this.jsonBox);
			this.Name = "TextDisplayForm";
			this.Text = "Text Display";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox jsonBox;
	}
}