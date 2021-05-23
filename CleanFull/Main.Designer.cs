namespace CleanFull
{
	// Token: 0x02000008 RID: 8
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002444 File Offset: 0x00000644
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002494 File Offset: 0x00000694
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(31, 31);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "uh oh";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}

		// Token: 0x0400000B RID: 11
		private global::System.ComponentModel.IContainer components;
	}
}
