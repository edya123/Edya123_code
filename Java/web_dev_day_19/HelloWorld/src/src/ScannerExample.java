package src;

import java.util.Scanner;

public class ScannerExample {

	public static void main(String[] args) {

		System.out.println("Ievadi k�du v�rdu: ");
		Scanner scanner = new Scanner(System.in);

		String name = scanner.nextLine();
		System.out.println("Tu ievad�ji: '" + name + "'");

		System.out.println("Ievadi veselu skaitli: ");
		int number = scanner.nextInt();
		System.out.println("Tu ievad�ji veselu skaitli: '" + number + "'");

		System.out.println("Ievadi decim�lskaitli: ");
		double doubleNumber = scanner.nextDouble();
		System.out.println("Tu ievad�ji decim�lskaitli: '" + doubleNumber + "'");

		scanner.close();
	}

}
