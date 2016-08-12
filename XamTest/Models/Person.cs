using System;

namespace XamTest
{
	
	public class Person
	{
		public delegate void MediaEventHandler(object sender, EventArgs args);

		public event MediaEventHandler ButtonClicked;

		public String Name { get; set; }
		public int Age { get; set; }


		public void DoMyAction()
		{
			if (ButtonClicked != null)
			{
				ButtonClicked(this, null);
			}
		}
	}
}

