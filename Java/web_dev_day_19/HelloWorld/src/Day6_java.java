import java.util.Random;
import java.util.Scanner;

public class Day6_java {

	public static void main(String[] args) {
		int randomNumber = new Random().nextInt(10) + 1;
//		Sâkâs ar 1, nevis 0. Pabîda skaitïus par 1 vienîbu (+1)
		
		System.out.println("Number: " + randomNumber);
		System.out.println("I have chosen number between 1 and 10," + " try to guess it. What`s your number?");
		Scanner scanner = new Scanner(System.in);

		int number = 100;

		do {
			number = scanner.nextInt();
			if (randomNumber != number) {
				System.out.println("Nop, try again.");
			}
		} while (randomNumber != number);

		System.out.println("Correct, the number was: " + randomNumber);
	}
}
