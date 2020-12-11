using System;

public class Employee {
	readonly string Name;
	readonly string LastName;

	public Employee(string name, string lastname) {
		Name = name;
		LastName = lastname;
		CurrentPos = Position.JuniorProg;
	}

	public enum Position {
		JuniorProg,
		MidProg,
		SeniorProg,
		LeadProg,
		Manager,
		Director,
		CEO
	}

	public Position CurrentPos {
		get; set;
	}

	uint Salary(out uint Tax) {
		uint salary = CurrentPos switch    // Заробітня плата за посадою, у ₴.
		{
			Position.JuniorProg => 15000,
			Position.MidProg => 20000,
			Position.SeniorProg => 30000,
			Position.LeadProg => 40000,
			Position.Manager => 50000,
			Position.Director => 70000,
			Position.CEO => 100000,
			_ => 0,
		};
		Tax = salary / 10;  // Нехай податки будуть 10%.
		return salary;
	}

	public void ShowInfo() {
		Console.WriteLine("Name: {0}", Name);
		Console.WriteLine("Last name: {0}", LastName);
		Console.WriteLine("Position: {0}", CurrentPos);
		Console.WriteLine("Salary: {0}", Salary(out uint Tax));
		Console.WriteLine("Tax: {0}", Tax);
	}
}
