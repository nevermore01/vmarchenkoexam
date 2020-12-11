using System;

public class Converter {
	readonly double USD;
	readonly double EUR;
	readonly double RUB;

	public Converter(double usd, double eur, double rub) {
		USD = usd;
		EUR = eur;
		RUB = rub;
	}

	public double UahToUsd(double uah) => uah / USD;
	public double UahToEur(double uah) => uah / EUR;
	public double UahToRub(double uah) => uah / RUB;

	public double UsdToUah(double usd) => USD * usd;
	public double EurToUah(double eur) => EUR * eur;
	public double RubToUah(double rub) => RUB * rub;
}
