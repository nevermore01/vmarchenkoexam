using System;
using static System.Console;

static class Program {
	static string GetString(string prompt) {
		Write(prompt);
		return ReadLine();
	}
	static double GetDoubleFloat(string prompt) {
		double input;
		do {
			Write(prompt);
		} while (!double.TryParse(ReadLine(), out input));
		return input;
	}

	static uint GetUInt32(string prompt) {
		uint input;
		do {
			Write(prompt);
		} while (!uint.TryParse(ReadLine(), out input));
		return input;
	}
	enum Task { // Внутрішні назви задач.
		Address = 1,
		Rectangle = 2,
		Book = 3,
		Figure = 4,
		User = 5,
		Converter = 6,
		Employee = 7,
		Invoice = 8
	}
	static void Main(string[] args) {
		OutputEncoding = System.Text.Encoding.UTF8;
		InputEncoding = System.Text.Encoding.Unicode;
		Console.Title = "Лабораторна робота 2";

		int TaskNum = 0;
		if (args != null && args.Length != 0) {
			int.TryParse(args[0], out TaskNum);
		}
		switch ((Task)TaskNum) {
		case Task.Address:
			Task1();
			break;
		case Task.Rectangle:
			Task2();
			break;
		case Task.Book:
			Task3();
			break;
		case Task.Figure:
			Task4();
			break;
		case Task.User:
			Task5();
			break;
		case Task.Converter:
			Task6();
			break;
		case Task.Employee:
			Task7();
			break;
		case Task.Invoice:
			Task8();
			break;
		default:
			Task1();
			Task2();
			Task3();
			Task4();
			Task5();
			Task6();
			Task7();
			Task8();
			break;
		}

		WriteLine("Роботу програми завершено. Натисніть Enter...");
		if (KeyAvailable) {
			ReadKey(); // Очистити вхідний буфер.
		}
		while (ReadKey().Key != ConsoleKey.Enter) { // Чекати натискання літери Enter.
		}
	}

	static void Task1() {
		WriteLine("1.");

		// Создать экземпляр класса Address.
		// В поля экземпляра записать информацию о почтовом адресе.
		Address address = new Address {
			Index = GetUInt32("Введіть невід'ємне число index: "),
			Country = GetString("Введіть country: "),
			City = GetString("Введіть city: "),
			Street = GetString("Введіть street: ")
		};
		uint house;
		do {
			house = GetUInt32("Введіть додатне число house: ");
		} while (house == 0);
		address.House = house;
		uint flat;
		do {
			flat = GetUInt32("Введіть додатне число apartment: ");
		} while (flat == 0);
		address.Flat = flat;

		// Выведите на экран значения полей, описывающих адрес.
		WriteLine("Тепер екземпляр класу Address має такі дані:");
		address.Show();

		WriteLine();
	}

	static void Task2() {
		WriteLine("2.");

		// Написать программу, которая принимает от пользователя длины двух
		// сторон прямоугольника и выводит на экран периметр и площадь.
		double a, b;
		do {
			a = GetDoubleFloat("Введіть довжину сторони a прямокутника: ");
		} while (a <= 0);
		do {
			b = GetDoubleFloat("Введіть довжину сторони b прямокутника: ");
		} while (b <= 0);
		Rectangle rectangle = new Rectangle(a, b);
		WriteLine("Периметр цього прямокутника: " + rectangle.Perimeter);
		WriteLine("Площа цього прямокутника: " + rectangle.Area);

		WriteLine();
	}

	static void Task3() {
		WriteLine("3.");

		string title = GetString("Введіть назву книги: ");
		string author = GetString("Вкажіть автора книги: ");
		string content = GetString("Введіть зміст книги: ");
		Book book = new Book(title, author, content);
		book.title.Show();
		book.author.Show();
		book.content.Show();

		WriteLine();
	}

	static void Task4() {
		WriteLine("4.");

		WriteLine("Дано точки A(0,9), B(4,-2), C(-3, -5).");
		Point A = new Point(0, 9, "A");
		Point B = new Point(4, -2, "B");
		Point C = new Point(-3, -5, "C");
		Figure ABC = new Figure(A, B, C);
		WriteLine("Дано трикутник ABC.");
		ABC.ShowNamePerimeter();

		WriteLine();
	}

	static void Task5() {
		WriteLine("5.");

		User user = new User() {
			Login = "u1",
			Name = "Dave",
			LastName = "Simpkins",
			Age = 20,
		};
		user.ShowInfo();

		WriteLine();
	}

	static void Task6() {
		Console.WriteLine("6.");

		const double UAH_USD = 27.91;
		const double UAH_EUR = 33.07;
		const double UAH_RUB = .37;

		Converter converter = new Converter(UAH_USD, UAH_EUR, UAH_RUB);

		double money = 5000;    // Припустимо, у нас є 5000₴.
		Console.WriteLine("{0}₴ у різних валютах буде:", money);
		Console.WriteLine("{0:F2}$, {1:F2}€, {2:F2}₽", converter.UahToUsd(money), converter.UahToEur(money), converter.UahToRub(money));

		money = 1000;
		Console.WriteLine("{0}$ = {1}₴", money, converter.UsdToUah(money));
		Console.WriteLine("{0}€ = {1}₴", money, converter.EurToUah(money));
		Console.WriteLine("{0}₽ = {1}₴", money, converter.RubToUah(money));

		Console.WriteLine();
	}

	static void Task7() {
		Console.WriteLine("7.");

		Console.Write("Введіть Ваше ім'я: ");
		string name = Console.ReadLine();
		Console.Write("Введіть Ваше прізвище: ");
		string lastname = Console.ReadLine();
		Employee employee = new Employee(name, lastname);

		// Надати працівнику випадкову посаду.
		Random random = new Random();
		employee.CurrentPos = (Employee.Position)random.Next(4);

		// Вивести на екран інформацію про працівника.
		employee.ShowInfo();
		Console.WriteLine();
	}

	static void Task8() {
		Console.WriteLine("8.");

		Invoice invoice = new Invoice(0, "Давид Сімпкінс", "Київхліб") {
			Article = "Хліб український",
			Quantity = 5
		};
		invoice.ShowValue(11);

		Console.WriteLine();
	}
}
