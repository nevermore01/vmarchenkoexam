using static System.Console;

public class Address {
	// Создать класс с именем Address.
	// В теле класса требуется создать поля: index, country, city, street, house, apartment.
	// Для каждого поля создать свойство с двумя методами доступа.
	public uint Index {
		get; set;
	}
	public string Country {
		get; set;
	}
	public string City {
		get; set;
	}
	public string Street {
		get; set;
	}
	public uint House {
		get; set;
	}
	public uint Flat {
		get; set;
	}

	public void Show() {
		WriteLine("index: " + Index);
		WriteLine("country: " + Country);
		WriteLine("city: " + City);
		WriteLine("street: " + Street);
		WriteLine("house: " + House);
		WriteLine("apartment: " + Flat);
	}
}
