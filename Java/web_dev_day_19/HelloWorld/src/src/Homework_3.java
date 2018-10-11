package src;

import java.util.Scanner;

public class Homework_3 {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		System.out.print("Ievadi vârdu un uzvârdu: ");
		String input = scanner.nextLine();

		input = input.trim();
		int index = input.indexOf(" ");

		System.out.println("index: " + index);

		String firstname = input.substring(0, index);
		firstname = firstname.substring(0, 1).toUpperCase() + firstname.substring(1).toLowerCase();
		System.out.println("'" + firstname + "'");

		String lastname = input.substring(index).trim().toUpperCase();
		System.out.println("'" + lastname + "'");

		scanner.close();

	}

}
