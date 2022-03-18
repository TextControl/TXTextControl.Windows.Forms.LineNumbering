using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TXTextControl;
using TXTextControl.Drawing;

namespace TXTextControl.LegalExtensions {
	public static class LegalExtensions {

		private static int m_lineWidth = 20;
		private static Color m_lineColor = Color.Black;
		private static string m_styleName;

		public static int LineWidth {
			get { return m_lineWidth; }
			set { m_lineWidth = value; }
		}

		public static Color LineColor {
			get { return m_lineColor; }
			set { m_lineColor = value; }
		}

		public static string StyleName {
			get { return m_styleName; }
			set { m_styleName = value; }
		}

		public static void AddLegalStyles(
			this TextControl textControl,
			string styleName,
			string fontName = "Courier New",
			int fontSize = 240,
			Color? foreColor = null,
			int lineSpacing = 200) {

			m_styleName = styleName + "Numbering";

			// create new styles for the legal content
			ParagraphStyle psLegalContent = new ParagraphStyle(styleName);
			psLegalContent.FontName = fontName;
			psLegalContent.FontSize = fontSize;
			psLegalContent.ForeColor = foreColor ?? Color.Black;
			psLegalContent.ParagraphFormat.LineSpacing = lineSpacing;

			textControl.ParagraphStyles.Add(psLegalContent);
			textControl.SelectAll();

			textControl.Selection.FormattingStyle = "CourtFilings";

			// second style is inherited and right aligned
			ParagraphStyle psLegalNumbering = new ParagraphStyle(styleName + "Numbering", styleName);
			psLegalNumbering.ParagraphFormat.Alignment = TXTextControl.HorizontalAlignment.Right;

			textControl.ParagraphStyles.Add(psLegalNumbering);
		}

		public static void AddLegalLineNumbering(this TextControl textControl, string paragraphStyle, int textDistance = 100, bool doubleLines = true) {
			
			// set the unit to word on twips basis
			textControl.PageUnit = MeasuringUnit.Twips;

			// retrieve margins and page size from first section
			PageMargins pageMargins = textControl.Sections[1].Format.PageMargins;
			PageSize pageSize = textControl.Sections[1].Format.PageSize;

			// calculate the TextFrame size including the gap between
			// the text and the frame
			Size frameSize = new Size(
				(int)pageMargins.Left - textDistance,
				(int)pageSize.Height -
				(int)pageMargins.Top -
				(int)pageMargins.Bottom);

			// set the right border to have enough space for all numbers
			TextFrame frame = new TextFrame(frameSize);
			frame.InternalMargins = new int[] { 0, 0, 300, 0 };
			frame.BorderWidth = 0; // no visible borders

			// add a header
			textControl.Sections[1].HeadersAndFooters.Add(HeaderFooterType.Header);
			HeaderFooter hf = textControl.Sections[1].HeadersAndFooters.GetItem(HeaderFooterType.Header);
			hf.Distance = 0; // header should start at top of page

			// add the text frame to the left page border (x)
			// and beginning of main text (y)
			hf.TextFrames.Add(
				frame,
				1,
				new Point(-(int)pageMargins.Left, (int)pageMargins.Top - hf.Distance),
				TextFrameInsertionMode.FixedOnPage | TextFrameInsertionMode.AboveTheText);

			// apply the formatting style
			frame.Selection.FormattingStyle = paragraphStyle;

			// calculate the number of lines that fit into the page
			var lineHeight = textControl.Lines[1].TextBounds.Height;
			var lineCount = frame.Size.Height / (lineHeight * 2);

			// add the line numbers
			for (int i = 1; i <= lineCount; i++) {
				frame.Selection.Text = i.ToString() + "\r\n";
			}

			// if double lines are required
			if (doubleLines == true)
				AddDoubleLines(frameSize, pageSize, pageMargins, hf);
		}

		private static Shape CreateLine(int x, Size drawingSize) {
			
			Shape shape = new Shape(ShapeType.Line);

			// set the color and border width
			shape.ShapeFill.Color = m_lineColor;
			shape.ShapeOutline.Color = m_lineColor;
			shape.ShapeOutline.Width = m_lineWidth;
			shape.Size = new Size(m_lineWidth, drawingSize.Height);

			shape.Bounds = new Rectangle(drawingSize.Width - m_lineWidth - x, 0, 0, drawingSize.Height);

			return shape;
		}

		private static void AddDoubleLines(Size frameSize, PageSize pageSize, PageMargins pageMargins, HeaderFooter hf) {

			// calculate the drawing size
			Size drawingSize = new Size(
				frameSize.Width,
				(int)pageSize.Height);

			// create a new drawing control
			TXDrawingControl drawing =
				new TXDrawingControl(drawingSize.Width, drawingSize.Height);

			// add the first line to the drawing control
			drawing.Shapes.Add(
				 CreateLine(0, drawingSize),
				 ShapeCollection.AddStyle.None);

			// add the second line to the drawing control
			drawing.Shapes.Add(
				 CreateLine(100, drawingSize),
				 ShapeCollection.AddStyle.None);

			// create a new drawing frame object from the created drawing control
			TXTextControl.DataVisualization.DrawingFrame drawingFrame =
				 new TXTextControl.DataVisualization.DrawingFrame(drawing);

			// add the frame to the document
			hf.Drawings.Add(drawingFrame, 1, new Point(-(int)pageMargins.Left, 0),
				FrameInsertionMode.FixedOnPage | FrameInsertionMode.AboveTheText);
		}
	}
}
