package src;

import java.util.Scanner;

public class ScannerExample {

	public static void main(String[] args) {

		System.out.println("Ievadi kâdu vârdu: ");
		Scanner scanner = new Scanner(System.in);

		String name = scanner.nextLine();
		System.out.println("Tu ievadîji: '" + name + "'");

		System.out.println("Ievadi veselu skaitli: ");
		int number = scanner.nextInt();
		System.out.println("Tu ievadîji veselu skaitli: '" + number + "'");

		System.out.println("Ievadi decimâlskaitli: ");
		double doubleNumber = scanner.nextDouble();
		System.out.println("Tu ievadîji decimâlskaitli: '" + doubleNumber + "'");

		scanner.close();
	}

}
