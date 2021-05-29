using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetFriends
{
	class Program
	{
		static string outMsg = "Hey {0}, am glad to see you here!";
		static string endMsg = "Press any key to close this window..";
		static void Main(string[] args)
		{
			Console.Write("Enter your friend's name: ");
			string friendName = Console.ReadLine();

			GreetYourFriend(friendName);
			Console.WriteLine("\n" + endMsg);
			Console.ReadKey();
		}

		public static void GreetYourFriend(string yourFriendName)
		{
			Console.WriteLine(outMsg, yourFriendName);
		}
	}
}
