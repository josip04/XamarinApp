using System;
using Gtk;

namespace projekt
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Application.Init();
			DB.CreateDB();
			MainWindow win = new MainWindow();
			win.Show();
			Application.Run();
		}
	}
}
