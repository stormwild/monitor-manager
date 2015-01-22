using System;
using System.Runtime.InteropServices;

namespace MonitorManager
{
	/// <summary>
	/// Reference: http://stackoverflow.com/questions/713498/turn-on-off-monitor/22636982#22636982
	/// </summary>
	class MonitorManager
	{
		private static int WM_SYSCOMMAND = 0x0112;
		private static uint SC_MONITORPOWER = 0xF170;

		static void Main(string[] args)
		{
			SendMessage(GetConsoleWindow(), WM_SYSCOMMAND, (IntPtr)SC_MONITORPOWER, (IntPtr)2);
		}

		[DllImport("kernel32.dll")]
		static extern IntPtr GetConsoleWindow();

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);
	}
}
