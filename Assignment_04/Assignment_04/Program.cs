namespace Assignment_04
{
	internal class Program
	{
		static void Main()
		{
			//value types
			//integral types
			var numberOne = SByte.MaxValue;
			var numberTwo = Byte.MaxValue;
			var numberThree = short.MaxValue;
			var numberFour = ushort.MaxValue;
			var numberFive = int.MaxValue;
			var numberSix = uint.MaxValue;
			var numberSeven = long.MaxValue;
			var numberEight = ulong.MaxValue;
			var numberNine = nint.MaxValue;
			var numberTen = nuint.MaxValue;
			Console.WriteLine($"sbyte max value is {numberOne}");
			Console.WriteLine($"byte max value is {numberTwo}");
			Console.WriteLine($"short max value is {numberThree}");
			Console.WriteLine($"ushort max value is {numberFour}");
			Console.WriteLine($"int max value is {numberFive}");
			Console.WriteLine($"uint max value is {numberSix}");
			Console.WriteLine($"long max value is {numberSeven}");
			Console.WriteLine($"ulong max value is {numberEight}");
			Console.WriteLine($"nint max value is {numberNine}");
			Console.WriteLine($"nuint max value is {numberTen}");

			//floating point types
			var numberEleven = float.MaxValue;
			var numberTwelve = double.MaxValue;
			var numberThirteen = decimal.MaxValue;
			Console.WriteLine($"float max value is {numberEleven}");
			Console.WriteLine($"double max value is {numberTwelve}");
			Console.WriteLine($"decimal max value is {numberThirteen}");

			//bool and char
			var isAlive = true;
			var letter = 'A';
			Console.WriteLine($"is alive is {isAlive}");
			Console.WriteLine($"the first letter is {letter}");

			
			//reference types
			//class
			var prog = new Program();
			//string
			var text = "letters";
			var obj = new object();
			Console.WriteLine($"the text is {text}");
			Console.WriteLine($"{obj}");


			//use static method
			Console.WriteLine(GetTimeNow());

			//use of non-static method
			var program = new Program();
			Console.WriteLine(program.GetTimeTomorrow());

			//boxing and unboxing
			int i = 123;
			object o = i;

			o = 123;
			i = (int)o;
		}

		public static string GetTimeNow()
		{
			var time = DateTime.UtcNow;
			return time.ToString();
		}

		public string GetTimeTomorrow()
		{
			var date = DateTime.UtcNow + TimeSpan.FromDays(1);
			return date.ToString();
		}
	}
}