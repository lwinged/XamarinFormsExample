using System;
namespace XamTest
{
	public interface ITextMeter
	{
		double MeasureTextSize(string text, double width, double fontSize, string fontName = null);
	}
}

