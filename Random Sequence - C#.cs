using System;

namespace RandomSequence
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(generateSequence(8));
			Console.ReadLine();
		}

		// Any characters can be added here to include them in the generated sequence
		const string characters = "0123456789AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
		// If the instance of random is created inside of the generateSequence method, 
		// the result will generate the same value multiple times if called in quick succession.
		static Random rand = new Random();

		// length: The length that you want the generated sequence to be
		static string generateSequence(int length)
		{
			string seq = "";

			for (int i = 0; i < length; i++)
			{
				seq += characters[(int)(Math.Floor((decimal)rand.Next(0, characters.Length)))];
			}

			return seq;
		}

	}
}
