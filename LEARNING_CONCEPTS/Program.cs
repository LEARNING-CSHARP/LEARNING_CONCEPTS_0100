namespace LEARNING_CSHARP
{
	/// <summary>
	/// Startup Class
	/// </summary>
	class Program
	{
		/// <summary>
		/// Startup Function
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			// Inline Comment

			/*

				Block Comment

			 */

			// برای دوره پیشرفته
			// قرار می‌گیرند Stack تعریف می‌شوند، در داخل function تمامی متغیرهایی که در داخل
			// می‌شوند، مطلقا مقدار اولیه ندارند Allocate قرار گرفته و یا اصطلاحا Stack تمامی متغیرهایی که در داخل
			// Reference Type و متغیرهای Value Type یا Primitive Type متغیرها به طور کلی به دو دسته تقسیم می‌شوند. متغیرهای
			// متغیرهایی هستند که خودشان و مقدارشان در یک جا قرار دارد Value Type یا Primitive Type متغیرهای
			//قرار داشته و اصطلاحا به آن اشاره می‌کنند Heap قرار دارند ولی مقدارشان در داخل) Heap و یا Sttack متغیرهایی هستند که خودشان در یک جا (یا در Reference Type متغیرهای

			// برای دوره مقدماتی
			// در زبان سی‌شارپ، هرگاه متغیری را در داخل یک فانکشن تعریف نماییم، اصطلاحا به آن متغیر محلی اطلاق می‌شود
			// در زبان سی‌شارپ، هرگاه یک متغیر محلی تعریف نماییم، مطلقا مقدار اولیه ندارد
			// قرار می‌گیرند Stack تعریف می‌شوند، در داخل function تمامی متغیرهایی که در داخل

			// **********
			// Variable Declaration
			//int X;
			//int Y;
			// **********

			// **********
			//int X, Y;
			// **********

			// **********
			//int X, Y;

			//Y = X + 10;
			// **********

			// **********
			//int X;
			//X = 10; // Initial Value
			// **********

			// **********
			//int X = 10;
			// **********

			// **********
			//int X = 10;
			//int Y = X + 5;
			// **********

			// X + Y =>
			// + Operator عملگر
			//	X, Y Operand عملوند

			// **********
			//int X = 10;

			// به متغیر ایکس پنج واحد اضافه کن
			//X = X + 5;

			//X += 5;
			// **********

			// **********
			//int X = 10;

			//X = X + 1;
			//X += 1;
			//X++;
			//++X;
			// **********

			// **********
			//int X = 10;

			//X = X - 1;
			//X -= 1;
			//X--;
			//--X;
			// **********

			// **********
			//int X = 10;

			//int Y = X++; // Y = 10, X = 11
			//int Z = ++X; // Z = 11, X = 11
			// **********

			// **********
			// Primitive (Value) Types

			// byte => Type Prefix => byt
			// int => Type Prefix => int
			// long => Type Prefix => lng

			// short => Type Prefix => sht
			// uint => Type Prefix => uint
			// ulong => Type Prefix => ulng

			// single => Type Prefix => sng
			// double => Type Prefix => dbl
			// decimal => Type Prefix => dec

			// char => Type Prefix => chr
			// bool => Type Prefix => bln
			// **********

			// تمامی متغیرهایی که تعریف می‌کنیم باید با معنی باشند
			// و نباید از محفف در نام آنها استفاده کنیم
			// و نیز نباید به هیچ عنوان از نام‌گذاری به روش پینگلیش استفاده کنیم
			//long X;
			//long FirstNumber; // Pascal Case
			//long lngFirstNumber; // Type Prefix

			// **********
			// هر متغیری از هر جنسی را می‌توان در داخل متغیری از همان جنس قرار داد
			// اعم از این که جنس آنرا بشناسیم یا نشناسیم

			//int X = 10;
			//int Y = 20;

			//X = Y;
			//Y = X;

			//Baghali X;
			//Baghali Y;

			//X = Y;
			//Y = X;

			// ولی هرگاه بخواهیم متغیری از یک جنس را در داخل متغیری از جنس دیگری
			// قرار دهیم، سه حالت امکانپذیر است

			// 1. می توان با خیال راحت
			// 2. می توان به شرط آنکه مسوولیت آن را بپذیریم
			// 3. مطلقا نمی‌شود

			// 1
			//int X = 10;
			//long Y = 20;

			// Implicit = ضمنی = تلویحی
			//Y = X; // Implicit Casting!

			// 2

			// X = Y; // Compiler Error!
			//X = (int)Y; // Explicit Casting! به صراحت

			// 3

			//int X = 123;
			//string S = "123";

			// S = X; // Complile Error!
			// X = S; // Complile Error!
			//S = X.ToString();
			//int X = System.Convert.ToInt32(S);
			// **********

			// **********
			// == (NOT =)		!= (NOT <>)		<		>		<= (NOT =<)		>= (NOT =>)
			// **********

			// **********
			//int X = 1;

			//if (X == 1)
			//{
			//	System.Console.WriteLine("Dad!");
			//}

			//if (X == 1)
			//{
			//	System.Console.WriteLine("Dad!");
			//}
			//else
			//{
			//	System.Console.WriteLine("Bidad!");
			//}

			// Infinitive Loop
			//while (1 == 1)
			//{
			//	System.Console.WriteLine("Dad!");
			//}
			// **********

			// **********
			// در زبان سی‌شارپ، در صورتی که در داخل یک بلاک بیش از یک دستور بنویسیم، موظف هستیم که حتما
			// آکولاد باز و بسته را بنویسیم. ولی در صورتی که بخواهیم در داخل یک بلاک، صرفا یک دستور بنویسیم
			// می‌توانیم آکولاد باز و بسته را ننویسیم. ولی دقت داشته باشید که در رسم‌الخط حرفه‌ای، حتی اگر
			// یک دستور هم می‌نویسیم، باید آکولاد باز و بسته را بنویسیم

			// Note: Not Recommended!
			//if (X == 1)
			//	System.Console.WriteLine("Dad!");

			// Note: Not Recommended!
			//if (X == 1) System.Console.WriteLine("Dad!");

			//if (X == 1)
			//{
			//	System.Console.WriteLine("Dad!");
			//}
			// **********

			// **********
			//if(f() && g())
			//{
			//}

			//if(f() || g())
			//{
			//}

			//if(f() & g())
			//{
			//}

			//if(f() | g())
			//{
			//}
			// **********

			// **********
			//int intIndex = 1;

			//while (intIndex <= 10)
			//{
			//	// Do Something(s)

			//	intIndex++;
			//}
			// **********

			// **********
			//int intIndex = 1;

			//while (intIndex <= 10)
			//{
			//	System.Console.WriteLine("Hello, World!");

			//	intIndex++;
			//}
			// **********

			// **********
			// **********
			// **********
			//string strFirstName = "Dariush";
			//string strLastName = "Tasdighi";

			//string strFullName = strFirstName + " " + strLastName;

			//// strFullName => "Dariush Tasdighi"
			// **********

			// **********
			//string str1 = "Some Text";

			//string str2 = str1 + (10).ToString();

			//// str2 => "Some Text10"

			//string str3 = str1 + 10;

			//// str3 => "Some Text10"
			// **********

			// **********
			//string str1 = "Some Text";

			//string str2 = 10 + str1;

			//// str2 => "10Some Text"
			// **********
			// **********
			// **********

			// **********
			//System.Console.Write("How many numbers do you have: ");

			////string strNumberCount = System.Console.ReadLine();

			//string strNumberCount =
			//	System.Console.ReadLine();

			//int intNumberCount =
			//	System.Convert.ToInt32(strNumberCount);

			//int intSum = 0;

			//int intIndex = 1;

			//while (intIndex <= intNumberCount)
			//{
			//	// [1] -> 
			//	string strMessage = "[" + intIndex + "] -> ";

			//	System.Console.Write(strMessage);

			//	string strNumber =
			//		System.Console.ReadLine();

			//	int intNumber =
			//		System.Convert.ToInt32(strNumber);

			//	intSum += intNumber;

			//	//intSum +=
			//	//	System.Convert.ToInt32(System.Console.ReadLine());

			//	intIndex++;
			//}

			//System.Console.WriteLine("The sum of these numbers is " + intSum);
			// **********

			// **********
			//string strInput =
			//	System.Console.ReadLine();

			//if (strInput == "1")
			//{
			//	System.Console.WriteLine("10");
			//}
			//else
			//{
			//	if (strInput == "2")
			//	{
			//		System.Console.WriteLine("20");
			//	}
			//	else
			//	{
			//		if (strInput == "3")
			//		{
			//			System.Console.WriteLine("30");
			//		}
			//		else
			//		{
			//			if (strInput == "4")
			//			{
			//				System.Console.WriteLine("40");
			//			}
			//			else
			//			{
			//				if (strInput == "5")
			//				{
			//					System.Console.WriteLine("50");
			//				}
			//				else
			//				{
			//					System.Console.WriteLine("Not a valid input!");
			//				}
			//			}
			//		}
			//	}
			//}
			// **********

			// **********
			//string strInput =
			//	System.Console.ReadLine();

			//switch (strInput)
			//{
			//	case "1":
			//	{
			//		System.Console.WriteLine("10");
			//		break;
			//	}

			//	case "2":
			//	{
			//		System.Console.WriteLine("20");
			//		break;
			//	}

			//	case "3":
			//	{
			//		System.Console.WriteLine("30");
			//		break;
			//	}

			//	case "4":
			//	{
			//		System.Console.WriteLine("40");
			//		break;
			//	}

			//	case "5":
			//	case "6":
			//	case "7":
			//	case "8":
			//	case "9":
			//	{
			//		System.Console.WriteLine("50");
			//		break;
			//	}

			//	// اختیاری است default دستور
			//	// معنی:‌ در غیر این صورت
			//	default:
			//	{
			//		System.Console.WriteLine("Not a valid input!");
			//		break;
			//	}
			//}
			// **********

			// **********
			//string strInput =
			//	System.Console.ReadLine();

			//switch (strInput)
			//{
			//	// خاکبرداری
			//	case "1":
			//	{
			//		System.Console.WriteLine("Step (1)");

			//		goto case "2";
			//	}

			//	// اسکلت
			//	case "2":
			//	{
			//		System.Console.WriteLine("Step (2)");

			//		goto case "3";
			//	}

			//	// سفت‌کاری
			//	case "3":
			//	{
			//		System.Console.WriteLine("Step (3)");

			//		goto case "4";
			//	}

			//	// نازک‌کاری
			//	case "4":
			//	{
			//		System.Console.WriteLine("Step (4)");
			//		break;
			//	}
			//}
			// **********

			// **********
			//int intNumber = 10;

			//while (intNumber < 5)
			//{
			//	System.Console.WriteLine("Hello, World!");
			//}

			//do
			//{
			//	System.Console.WriteLine("Hello, World!");
			//} while (intNumber < 5); // ; -> is required!
			// **********

			// **********
			//for (A; B; C)
			//{
			//	D;
			//}

			// A, B, D, C, B, D, C, B, D, C,...
			// **********

			// **********
			//int intIndex = 1;

			//while (intIndex <= 10)
			//{
			//	// Do Something(s)!

			//	intIndex++;
			//}

			//for (int intIndex = 1; intIndex <= 10; intIndex++)
			//{
			//	// Do Something(s)!
			//}
			// **********

			// **********
			// متغیرهای محلی

			//if(1 == 1)
			//{
			//	// ...

			//	int intIndex = 1;

			//	// ...
			//}

			//{
			//	// ...

			//	int intIndex = 1;

			//	// ...
			//}
			// **********

			// **********
			// Snippet
			// **********

			// **********
			// هرگاه کامپایلر به دستور
			// break
			// برخورد نماید
			// از آخرین حلقه‌ای که در داخل آن قرار دارد خارج می‌شود

			////...
			//// A
			//while (1 == 1)
			//{
			//	//...
			//	// B
			//	while (1 == 1)
			//	{
			//		//...
			//		// C
			//		if (1 == 1)
			//		{
			//			//...
			//			break;
			//		}
			//		// D
			//		//...
			//	}
			//	// E
			//	//...
			//}
			//// F
			////...

			//while (1 == 1)
			//{
			//	//...
			//	while (2 == 2)
			//	{
			//		//...
			//		while (3 == 3)
			//		{
			//			//...
			//			while (4 == 4)
			//			{
			//				//...
			//				while (5 == 5)
			//				{
			//					//...
			//					if (6 == 6)
			//					{
			//						goto SomeLabel;
			//					}
			//				}
			//			}
			//		}
			//	}
			//}

			//SomeLabel:

			// هرگاه کامپایلر به دستور
			// continue
			// برخورد نماید
			// به ابتدای آخرین حلقه‌ای که در داخل آن قرار دارد وارد شده و شرط را تست می‌کند

			//int intIndex = 1;

			//while (intIndex <= 10)
			//{
			//	if (intIndex == 3)
			//	{
			//		intIndex = 6;
			//		continue;
			//	}

			//	if (intIndex == 8)
			//	{
			//		break;
			//	}

			//	System.Console.WriteLine(">" + intIndex);

			//	intIndex++;
			//}
			// **********

			// **********
			//int A = 10;
			//int B = 20;
			//int C = 30;
			//string strResult;

			//// Target: "A = 10, B = 20, C = 30"

			//strResult = "A = " + A + ", B = " + B + ", C = " + C;

			//strResult =
			//	string.Format("A = {0}, B = {1}, C = {2}", A, B, C);

			//strResult =
			//	string.Format("A = {1}, B = {0}, C = {1}", A, B, C);

			//// Target: "A = 20, B = 10, C = 20"

			//System.Console.WriteLine(strResult);
			// **********

			// **********
			//string strFullName;
			//string strFirstName = "Dariush";
			//string strLastName = "Tasdighi";

			//strFullName =
			//	strFirstName + " " + strLastName;

			//strFullName =
			//	string.Format("{0} {1}",
			//	strFirstName, strLastName);

			//System.Console.WriteLine(strFullName);

			//System.Console.WriteLine("{0} {1}", strFirstName, strLastName);
			// **********

			// **********
			//string str = "A";
			//char chr = 'A'; // 65
			// **********

			// **********
			//bool blnResult = true;

			//// دستور ذیل حرفه‌ای نیست
			//if (blnResult == true)
			//{
			//}

			//// دستور ذیل حرفه‌ای است
			//if (blnResult)
			//{
			//}

			//// دستور ذیل حرفه‌ای نیست
			//if (!blnResult)
			//{
			//}

			//// دستور ذیل حرفه‌ای است
			//if (blnResult == false)
			//{
			//}
			// **********

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
