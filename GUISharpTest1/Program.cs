using System;

namespace GUISharpTest1
{
	public class Program
	{
		[STAThread]
		private static void Main()
		{
			GUISharp.Client.GUIClient test = new();
			test.ChangeLocation(0, 0);
			test.Start();
		}
	}
}