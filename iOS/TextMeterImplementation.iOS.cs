﻿using System;
using Foundation;
using UIKit;
using System.Drawing;
using XamTest.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(TextMeterImplementation))]
namespace XamTest.iOS
{
	public class TextMeterImplementation : ITextMeter
	{
		//public static Xamarin.Forms.Size MeasureTextSize(string text, double width, double fontSize, string fontName = null)
		public double MeasureTextSize(string text, double width, double fontSize, string fontName = null)
		{
			var nsText = new NSString(text);
			var boundSize = new SizeF((float)width, float.MaxValue);
			var options = NSStringDrawingOptions.UsesFontLeading | NSStringDrawingOptions.UsesLineFragmentOrigin;

			if (fontName == null)
			{
				fontName = "HelveticaNeue";
			}

			var attributes = new UIStringAttributes
			{
				Font = UIFont.FromName(fontName, (float)fontSize)
			};

			var sizeF = nsText.GetBoundingRect(boundSize, options, attributes, null).Size;

			//return new Xamarin.Forms.Size((double)sizeF.Width, (double)sizeF.Height);
			return (double)sizeF.Height + 5;
		}
	}
}