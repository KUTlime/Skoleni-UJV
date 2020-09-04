using System;
using System.IO.Ports;

namespace ConsoleSerialPort
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ports available:");
			foreach (var port in SerialPort.GetPortNames())
			{
				Console.WriteLine($"Port name: {port}");
			}
		}
	}
}
