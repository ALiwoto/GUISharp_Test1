using System;

namespace GUIVoidTest1
{
	public class Program
	{
		[STAThread]
		private static void Main()
		{
			GUIVoid.Client.GUIClient test = new();
			test.Start();
		}
	}
}