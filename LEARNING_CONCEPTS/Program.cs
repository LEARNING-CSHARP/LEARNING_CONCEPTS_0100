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

			// متغیرها به طور کلی به دو دسته تقسیم می‌شوند
			// متغیرهایی که در داخل تابع تعریف می‌شوند که اصطلاحا به آنها متغیر محلی گفته می‌شود
			// متغیرهایی که بیرون تابع و در درون خود کلاس تعریف می‌شوند که به آنها اصطلاحا فیلد گفته می‌شود

			// برای دوره پیشرفته
			// قرار می‌گیرند Stack تعریف می‌شوند، در داخل function تمامی متغیرهایی که در داخل
			// می‌شوند، مطلقا مقدار اولیه ندارند Allocate قرار گرفته و یا اصطلاحا Stack تمامی متغیرهایی که در داخل
			// Reference Type و متغیرهای Value Type یا Primitive Type متغیرها به طور کلی به دو دسته تقسیم می‌شوند. متغیرهای
			// متغیرهایی هستند که خودشان و مقدارشان در یک جا قرار دارد Value Type یا Primitive Type متغیرهای
			//قرار داشته و اصطلاحا به آن اشاره می‌کنند Heap قرار دارند ولی مقدارشان در داخل) Heap و یا Sttack متغیرهایی هستند که خودشان در یک جا (یا در Reference Type متغیرهای

			// برای دوره مقدماتی
			// در زبان سی‌شارپ، هرگاه یک متغیر محلی (متغیر داخل تابع) تعریف نماییم، مطلقا مقدار اولیه ندارد
			// قرار می‌گیرند Stack تعریف می‌شوند، در داخل function تمامی متغیرهایی که در داخل

			// **********
			// Variable Declaration = تعریف متغیر = Variable Definition
			//int X;
			//int Y;
			// **********

			// **********
			//int X, Y;
			// **********

			// **********
			//int X, Y;

			//Y = X + 10; // (=) -> (Assignment), Compile Error!
			// **********

			// **********
			//int X;
			//X = 10; // Initial Value
			// **********

			// **********
			//int X = 10;
			// **********

			// **********
			//int X = 10, Y = X + 5;
			// **********

			// **********
			//int X = 10;
			//int Y = X + 5;
			// **********

			// **********
			//int X;
			//X = 10;
			//int Y;
			//Y = X + 5;
			// **********

			// **********
			// Operator: + - * / %

			// X + Y =>
			// +		Operator عملگر
			//	X, Y	Operand عملوند
			// **********

			// **********
			//int X = 10;

			// عامیانه: به متغیر ایکس پنج واحد اضافه کن
			// دقیق: مقدار متغیر ایکس را با پنج جمع کن و حاصل آن را در متغیر ایکس قرار بده
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
			// Primitive (Value) Types:

			// byte
			// int
			// long

			// short
			// uint
			// ulong

			// single
			// double
			// decimal

			// char
			// bool
			// **********

			// **********
			// Pascal Case => FirstNumber
			// Camel Case  => firstNumber
			// Upper Case  => FIRST_NUMBER
			// Lower Case  => first_number
			// **********

			// **********
			// استاندارد = تاکتیک

			// تمامی متغیرهایی که تعریف می‌کنیم باید با معنی باشند
			// و نباید از محفف در نام آنها استفاده کنیم
			// و دیکته آنها باید درست و با دقت نوشته شود
			// و نیز نباید به هیچ عنوان از نام‌گذاری به روش پینگلیش استفاده کنیم
			// **********

			// **********
			// استاندارد قدیم

			//string strFullName;	// Type Prefix: str + Pascal Case
			//long lngFirstNumber;	// Type Prefix: lng + Pascal Case
			// **********

			// **********
			// استاندارد جدید

			//long firstNumber;			// Camel Case
			//long firstNumberLong;		// Camel Case + Type Name
			//string fullName;			// Camel Case
			//string fullNameString;	// Camel Case + Type Name
			// **********

			// **********
			// هر متغیری از هر جنسی را می‌توان در داخل متغیری از همان جنس قرار داد
			// اعم از این که جنس آنرا بشناسیم یا نشناسیم

			//int X = 10;
			//int Y = 20;

			//X = Y;
			//Y = X;

			//GooGooli X;
			//GooGooli Y;

			//X = Y;
			//Y = X;

			// ولی هرگاه بخواهیم متغیری از یک جنس را در داخل متغیری از جنس دیگری
			// قرار دهیم، سه حالت امکانپذیر است

			// 1. می توان با خیال راحت
			// 2. می توان به شرط آنکه مسوولیت آن را بپذیریم
			// 3. مطلقا نمی‌شود

			// (1)

			//int X = 10;
			//long Y = 20;

			// Implicit = ضمنی = تلویحی
			//Y = X; // Implicit Casting!

			// (2)

			// X = Y; // Compiler Error!
			//X = (int)Y; // Explicit Casting! به صراحت

			// (3)

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
			// **********
			// **********
			//if(f() && g())
			//{
			//}

			//if(f() || g())
			//{
			//}
			// **********

			// **********
			//bool fResult = f();
			//bool gResult = g(); 

			//if(fResult && gResult)
			//{
			//}

			//if(fResult || gResult)
			//{
			//}
			// **********

			// **********
			//if(f() & g())
			//{
			//}

			//if(f() | g())
			//{
			//}
			// **********
			// **********
			// **********

			// **********
			// **********
			// **********
			// Inline Condition

			//int firstNumber = 10;
			//int secondNumber = 20;

			//int max = firstNumber > secondNumber ? firstNumber : secondNumber;

			//int max;

			//if(firstNumber > secondNumber)
			//{
			//	max = firstNumber;
			//}
			//else
			//{
			//	max = secondNumber;
			//}

			//int min = firstNumber > secondNumber ? secondNumber : firstNumber;

			//int min;

			//if (firstNumber > secondNumber)
			//{
			//	min = secondNumber;
			//}
			//else
			//{
			//	min = firstNumber;
			//}
			// **********
			// **********
			// **********

			// **********
			// **********
			// **********
			//int index = 1;

			//while (index <= 10)
			//{
			//	// Do Something(s)

			//	index++;
			//}
			// **********

			// **********
			// با استفاده از دستورات فوق، ۱۰ بار دستورات
			// Do Something(s)
			// اجرا می‌شود
			// **********

			// **********
			//int index = 1;

			//while (index <= 10)
			//{
			//	System.Console.WriteLine("Hello, World!");

			//	index++;
			//}
			// **********

			// **********
			// با استفاده از دستورات فوق، ۱۰ بار متن
			// Hello, World!
			// در صفحه نمایش داده می‌شود
			// **********
			// **********
			// **********

			// **********
			// **********
			// **********
			//string firstName = "Dariush";
			//string lastName = "Tasdighi";

			//string fullName = firstName + " " + lastName;

			// fullName => "Dariush Tasdighi"
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

			//string str2 = (10).ToString() + str1; // قبلا مجبور بودیم

			//string str2 = 10 + str1; // در نسخه‌های جدید مشکلی ندارد

			//// str2 => "10Some Text"
			// **********
			// **********
			// **********

			// **********
			//System.Console.Write("What is your first name: ");
			//string firstName = System.Console.ReadLine();

			//System.Console.Write("What is your last name: ");
			//string lastName = System.Console.ReadLine();

			//string fullName = firstName + lastName; // Wrong Usage!

			//string fullName = firstName + "" + lastName; // Wrong Usage!

			//string fullName = firstName + " " + lastName;

			//string fullName = string.Format("{0} {1}", firstName, lastName);

			//string fullName =
			//	string.Format("Full Name: {0} {1}",
			//	firstName, lastName);

			//string fullName =
			//	$"{firstName} {lastName}";

			//string fullName =
			//	$"{ firstName } { lastName }";

			//// Wrong Usage!
			////System.Console.WriteLine("fullName");

			//System.Console.WriteLine(fullName);
			// **********

			// **********
			//for (A; B; C)
			//{
			//	D;
			//}

			// A, B, D, C, B, D, C, B, D, C,...
			// **********

			// **********
			// **********
			// **********
			//int indexInt = 1;

			//while (indexInt <= 10)
			//{
			//	// Do Something(s)!

			//	indexInt++;
			//}
			// **********

			// **********
			//for (int indexInt = 1; indexInt <= 10; indexInt++)
			//{
			//	// Do Something(s)!
			//}
			// **********
			// **********
			// **********

			// **********
			//System.Console.Write("How many times do you want to write Hello, World!: ");

			//string countString =
			//	System.Console.ReadLine(); // "13"

			//int countInt =
			//	System.Convert.ToInt32(countString); // 13

			//int indexInt = 1;

			//while (indexInt <= countInt)
			//{
			//	string messageString = "Hello, World!";

			//	// [1]: Hello, World!
			//	// [2]: Hello, World!
			//	// ...
			//	// [9]: Hello, World!

			//	//string messageString = $"[{ indexInt }]: Hello, World!";

			//	// Wrong Usage!
			//	//string messageString = "[{ indexInt }]: Hello, World!";

			//	System.Console.WriteLine(messageString);

			//	indexInt++;
			//}
			// **********

			// **********
			//System.Console.Write("How many times do you want to write Hello, World!: ");

			//string countString =
			//	System.Console.ReadLine();

			//int countInt =
			//	System.Convert.ToInt32(countString);

			//for (int indexInt = 1; indexInt <= countInt; indexInt++)
			//{
			//	string messageString = $"[{ indexInt }]: Hello, World!";

			//	System.Console.WriteLine(messageString);
			//}
			// **********

			// **********
			// **********
			// **********
			//System.Console.Write("How many numbers do you have: ");

			//// **********
			//string numberCountString =
			//	System.Console.ReadLine();

			//int numberCountInt =
			//	System.Convert.ToInt32(numberCountString);
			//// **********

			//// **********
			////int numberCountInt =
			////	System.Convert.ToInt32(System.Console.ReadLine());
			//// **********

			//int sumInt = 0;

			//int indexInt = 1;

			//while (indexInt <= numberCountInt)
			//{
			//	// [1] ->
			//	string messageString = $"[{ indexInt }] -> ";

			//	System.Console.Write(messageString);

			//	// **********
			//	string numberString =
			//		System.Console.ReadLine();

			//	int numberInt =
			//		System.Convert.ToInt32(numberString);

			//	sumInt += numberInt;
			//	// **********

			//	// **********
			//	//sumInt +=
			//	//	System.Convert.ToInt32(System.Console.ReadLine());
			//	// **********

			//	indexInt++;
			//}

			//string resultString =
			//	$"The sum of these numbers is { sumInt }.";

			//System.Console.WriteLine(resultString);
			// **********
			// **********
			// **********

			// **********
			// **********
			// **********
			//System.Console.Write("How many numbers do you have: ");

			//string numberCountString =
			//	System.Console.ReadLine();

			//int numberCountInt =
			//	System.Convert.ToInt32(numberCountString);

			//int sumInt = 0;

			//for (int indexInt = 1; indexInt <= numberCountInt; indexInt++)
			//{
			//	string messageString = $"[{ indexInt }] -> ";

			//	System.Console.Write(messageString);

			//	string numberString =
			//		System.Console.ReadLine();

			//	int numberInt =
			//		System.Convert.ToInt32(numberString);

			//	sumInt += numberInt;
			//}

			//string resultString =
			//	$"The sum of these numbers is { sumInt }.";

			//System.Console.WriteLine(resultString);
			// **********
			// **********
			// **********

			// Debug: Breakpoint (F9),  Trace (F10, F11)

			// Documentation

			// **********
			//// متنی بر روی صفحه نمایش ظاهر می‌گردد با این مضمون که
			//// تعداد اعداد خود را مشخص نمایید
			//System.Console.Write("How many numbers do you have: ");

			//// دستور ذیل در انتظار وارد کردن عددی از کاربر خواهد بود
			//// که بعد از وارد کردن آن عدد، به صورت رشته در متغیر ذیل آنرا ذخیره خواهد کرد
			//string numberCountString =
			//	System.Console.ReadLine();

			//// دستور ذیل رشته فوق را به عدد تبدیل کرده و سپس آن را در متغیر ذیل ذخیره خواهد کرد
			//int numberCountInt =
			//	System.Convert.ToInt32(numberCountString);

			//// متغیر ذیل قرار است حاصل جمع اعداد وارد شده را در درون خود ذخیره نماید
			//// و در ابتدا مقدار اولیه آن را برابر مقدار صفر قرار می‌دهیم
			//int sumInt = 0;

			//// متغیر ذیل به عنوان یک شمارنده تعریف شده و مقدار اولیه یک را به آن اختصاص می‌دهیم
			//int indexInt = 1;
			// **********
			// **********
			// **********

			// **********
			// کار می‌کند function فقط در داخل goto دستور

			//// ...
			//if(1 == 1)
			//{
			//	goto SomeLable;
			//}
			//// ...
			//SomeLable:
			//// ...
			// **********

			// **********
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
			// **********

			// **********
			//string inputString =
			//	System.Console.ReadLine();

			//if (inputString == "1")
			//{
			//	System.Console.WriteLine("10");
			//}
			//// اگر یک نبود
			//else
			//{
			//	if (inputString == "2")
			//	{
			//		System.Console.WriteLine("20");
			//	}
			//	// اگر یک یا دو نبود
			//	else
			//	{
			//		if (inputString == "3")
			//		{
			//			System.Console.WriteLine("30");
			//		}
			//		// اگر یک یا دو یا سه نبود
			//		else
			//		{
			//			if (inputString == "4")
			//			{
			//				System.Console.WriteLine("40");
			//			}
			//			// اگر یک یا دو یا سه یا چهار نبود
			//			else
			//			{
			//				if (inputString == "5")
			//				{
			//					System.Console.WriteLine("50");
			//				}
			//				// اگر یک یا دو یا سه یا چهار یا پنج نبود
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
			//string inputString =
			//	System.Console.ReadLine();

			//switch (inputString)
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
			//string inputString =
			//	System.Console.ReadLine();

			//switch (inputString)
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
			//int numberInt = 10;

			//while (numberInt < 5)
			//{
			//	System.Console.WriteLine("Hello, World!");
			//}

			//do
			//{
			//	System.Console.WriteLine("Hello, World!");
			//} while (numberInt < 5);
			//// ; -> is required!
			// **********

			// **********
			// **********
			// **********
			// متغیر(های) محلی
			// Local Variable(s)
			// **********

			// **********
			//if(1 == 1)
			//{
			//	// ...

			//	int indexInt = 1;

			//	// ...
			//}

			// **********
			//if(1 == 1)
			//{
			//	int indexInt;

			//	// ...

			//	int indexInt; // Compile Error!
			//}
			// **********

			// **********
			//if(1 == 1)
			//{
			//	int indexInt;

			//	// ...
			//}

			//	// ...

			//if(1 == 1)
			//{
			//	int indexInt;

			//	// ...
			//}
			// **********

			// **********
			//if(1 == 1)
			//{
			//	int indexInt;

			//	if(1 == 1)
			//	{

			//		int index; // Compile Error!

			//	}

			//}
			// **********

			// **********
			//{
			//	int indexInt;
			//}
			// **********
			// **********
			// **********

			// **********
			// Snippet
			// **********

			// **********
			// هرگاه برنامه در زمان اجرا، به دستور
			// break
			// برخورد نماید
			// از آخرین (درونی‌ترین) حلقه‌ای که در داخل آن قرار دارد خارج می‌شود

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
			// **********

			// **********
			// هرگاه برنامه در زمان اجرا، به دستور
			// continue
			// برخورد نماید
			// به ابتدای آخرین (درونی‌ترین) حلقه‌ای که در داخل آن قرار دارد وارد شده و شرط آنرا تست می‌کند

			//int indexInt = 1;

			//while (indexInt <= 10)
			//{
			//	if (indexInt == 3)
			//	{
			//		indexInt = 6;

			//		continue;
			//	}

			//	if (indexInt == 8)
			//	{
			//		break;
			//	}

			//	System.Console.WriteLine($"> { indexInt }");

			//	indexInt++;
			//}
			// **********

			// **********
			//int a = 10;
			//int b = 20;
			//int c = 30;
			//string result;

			//// Target: "A = 10, B = 20, C = 30"

			//result = "A = " + a + ", B = " + b + ", C = " + c;

			//result =
			//	string.Format("A = {0}, B = {1}, C = {2}", a, b, c);

			//result =
			//	string.Format("A = {1}, B = {0}, C = {1}", a, b, c);

			//// Target: "A = 20, B = 10, C = 20"

			//result =
			//	string.Format("A = {1}, B = {0}, C = {1}", a); // Note: Compile OK! but Runtime Error!

			//result =
			//	$"A = { a }, B = { b }, C = { c }";

			//System.Console.WriteLine(result);
			// **********

			// **********
			//string myString = "A";
			//char myChar = 'A'; // 65
			// **********

			// **********
			//bool result = true;

			//// دستور ذیل حرفه‌ای نیست
			//if (result == true)
			//{
			//}

			//// دستور ذیل حرفه‌ای است
			//if (result)
			//{
			//}

			//// دستور ذیل حرفه‌ای نیست
			//if (!result)
			//{
			//}

			//// دستور ذیل حرفه‌ای است
			//if (result == false)
			//{
			//}
			// **********

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
