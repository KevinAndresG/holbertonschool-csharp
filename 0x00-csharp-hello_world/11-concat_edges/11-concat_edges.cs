using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "C# (pronounced \"See Sharp\") is a simple, modern, object-oriented, and type-safe programming language. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers.";
		str = str.Substring(49, str.Length -210) + str.Substring(121, str.Length -224) + str.Substring(80, str.Length -213) + str.Substring(119, str.Length -222) + str.Substring(102, str.Length -223);
		Console.WriteLine(str);
    }
}