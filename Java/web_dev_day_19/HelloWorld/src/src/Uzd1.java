package src;

import java.util.Scanner;

public class Uzd1 {

	public static void main(String[] args) {
		// int x = 0;
		// System.out.println()

		// defin�jam skait�us
//		int x = 8;
//		int y = 3;
//		int z = 9;
//		
		// System.out.println("x + y = " + (x + y));

		// Ievade - saskait��ana
		// System.out.println("Ievadi skaitli x: ");
		// Scanner scanner = new Scanner(System.in);

		// int x = scanner.nextInt();
		// System.out.println("Tu ievad�ji skaitli x: '" + x + "'");

		// System.out.println("Ievadi skaitli y: ");
		// int y = scanner.nextInt();
		// System.out.println("Tu ievad�ji skaitli y: '" + y + "'");

		// System.out.println("x + y = " + (x + y));

		// Ievade - vid�jais

		System.out.println("Ievadi skaitli a: ");
		Scanner scanner = new Scanner(System.in);
		int a = scanner.nextInt();
		System.out.println("Tu ievad�ji skaitli a: '" + a + "'");

		System.out.println("Ievadi skaitli b: ");
		int b = scanner.nextInt();
		System.out.println("Tu ievad�ji skaitli b: '" + b + "'");

		System.out.println("Ievadi skaitli c: ");
		int c = scanner.nextInt();
		System.out.println("Tu ievad�ji skaitli c: '" + c + "'");

		int sum = (a + b + c);
		if (a == b) {
			sum = c;
		} else if (a == c) {
			sum = b;
		} else if (b == c) {
			sum = a;
		} else if (a == b && b == c) {
			sum = 0;
		}
		System.out.println("sum (a;b;c) = " + sum);
	}
}
