
namespace tx_pdf_lines {
	partial class Form1 {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.textControl1 = new TXTextControl.TextControl();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbInsertNumbering = new System.Windows.Forms.ToolStripButton();
			this.ribbon1 = new TXTextControl.Windows.Forms.Ribbon.Ribbon();
			this.statusBar1 = new TXTextControl.StatusBar();
			this.rulerBar1 = new TXTextControl.RulerBar();
			this.rulerBar2 = new TXTextControl.RulerBar();
			this.ribbonFormattingTab1 = new TXTextControl.Windows.Forms.Ribbon.RibbonFormattingTab();
			this.toolStrip1.SuspendLayout();
			this.ribbon1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textControl1
			// 
			this.textControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textControl1.Font = new System.Drawing.Font("Courier New", 12F);
			this.textControl1.FormattingPrinter = "Standard";
			this.textControl1.Location = new System.Drawing.Point(25, 166);
			this.textControl1.Name = "textControl1";
			this.textControl1.Ribbon = this.ribbon1;
			this.textControl1.RulerBar = this.rulerBar2;
			this.textControl1.Size = new System.Drawing.Size(908, 413);
			this.textControl1.StatusBar = this.statusBar1;
			this.textControl1.TabIndex = 0;
			this.textControl1.UserNames = null;
			this.textControl1.VerticalRulerBar = this.rulerBar1;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbInsertNumbering});
			this.toolStrip1.Location = new System.Drawing.Point(0, 141);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(933, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbInsertNumbering
			// 
			this.tsbInsertNumbering.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsbInsertNumbering.Image = ((System.Drawing.Image)(resources.GetObject("tsbInsertNumbering.Image")));
			this.tsbInsertNumbering.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbInsertNumbering.Name = "tsbInsertNumbering";
			this.tsbInsertNumbering.Size = new System.Drawing.Size(129, 22);
			this.tsbInsertNumbering.Text = "Insert Line Numbering";
			this.tsbInsertNumbering.Click += new System.EventHandler(this.tsbInsertNumbering_Click);
			// 
			// ribbon1
			// 
			this.ribbon1.Controls.Add(this.ribbonFormattingTab1);
			this.ribbon1.Dock = System.Windows.Forms.DockStyle.Top;
			this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ribbon1.HotTrack = true;
			this.ribbon1.Location = new System.Drawing.Point(0, 0);
			this.ribbon1.Name = "ribbon1";
			this.ribbon1.SelectedIndex = 1;
			this.ribbon1.Size = new System.Drawing.Size(933, 116);
			this.ribbon1.TabIndex = 2;
			this.ribbon1.Text = "ribbon1";
			// 
			// statusBar1
			// 
			this.statusBar1.BackColor = System.Drawing.SystemColors.Control;
			this.statusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.statusBar1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.statusBar1.Location = new System.Drawing.Point(0, 579);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Size = new System.Drawing.Size(933, 22);
			this.statusBar1.TabIndex = 3;
			// 
			// rulerBar1
			// 
			this.rulerBar1.Alignment = TXTextControl.RulerBarAlignment.Left;
			this.rulerBar1.Dock = System.Windows.Forms.DockStyle.Left;
			this.rulerBar1.Location = new System.Drawing.Point(0, 166);
			this.rulerBar1.Name = "rulerBar1";
			this.rulerBar1.Size = new System.Drawing.Size(25, 413);
			this.rulerBar1.TabIndex = 4;
			this.rulerBar1.Text = "rulerBar1";
			// 
			// rulerBar2
			// 
			this.rulerBar2.Dock = System.Windows.Forms.DockStyle.Top;
			this.rulerBar2.Location = new System.Drawing.Point(0, 116);
			this.rulerBar2.Name = "rulerBar2";
			this.rulerBar2.Size = new System.Drawing.Size(933, 25);
			this.rulerBar2.TabIndex = 5;
			this.rulerBar2.Text = "rulerBar2";
			// 
			// ribbonFormattingTab1
			// 
			this.ribbonFormattingTab1.Location = new System.Drawing.Point(4, 24);
			this.ribbonFormattingTab1.Name = "ribbonFormattingTab1";
			this.ribbonFormattingTab1.Size = new System.Drawing.Size(925, 88);
			this.ribbonFormattingTab1.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(933, 601);
			this.Controls.Add(this.textControl1);
			this.Controls.Add(this.rulerBar1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.rulerBar2);
			this.Controls.Add(this.statusBar1);
			this.Controls.Add(this.ribbon1);
			this.Name = "Form1";
			this.Text = "Legal Numbering Sample";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ribbon1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TXTextControl.TextControl textControl1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbInsertNumbering;
		private TXTextControl.Windows.Forms.Ribbon.Ribbon ribbon1;
		private TXTextControl.Windows.Forms.Ribbon.RibbonFormattingTab ribbonFormattingTab1;
		private TXTextControl.RulerBar rulerBar2;
		private TXTextControl.StatusBar statusBar1;
		private TXTextControl.RulerBar rulerBar1;
	}
}

