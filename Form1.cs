using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TXTextControl;
using TXTextControl.Drawing;
using TXTextControl.LegalExtensions;

namespace tx_pdf_lines {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			textControl1.TextFrameMarkerLines = false;
			textControl1.DrawingMarkerLines = false;
			textControl1.Sections[1].Format.PageSize = new PageSize(850, 1400);
			textControl1.Sections[1].Format.PageMargins = new PageMargins(150, 100, 50, 70);
		}

		private void tsbInsertNumbering_Click(object sender, EventArgs e) {
			LegalExtensions.LineWidth = 30;
			LegalExtensions.LineColor = Color.Blue;

			textControl1.AddLegalStyles("CourtFilings");
			textControl1.AddLegalLineNumbering(LegalExtensions.StyleName, 200, true);
		}

	}
}
