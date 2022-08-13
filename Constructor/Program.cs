
// C# program to illustrate how to invoke
// overloaded constructor using this keyword
using System;
namespace Constructor { 
class Geek
{

	// Constructor without parameter
	public Geek()
	{
		Console.WriteLine("Hello! Constructor 1");
	}

	// Constructor with parameter
	// Here this keyword is used
	// to call Geek constructor
	public Geek(int a)
	: this()
	{
		Console.WriteLine("Hello! Constructor 2");
	}
}

	// Driver Class
	public class GFG
	{

		// Main method
		static public void Main()
		{

			// Create object of Geek class
			Geek obj = new Geek(2);
		}
	}
}
