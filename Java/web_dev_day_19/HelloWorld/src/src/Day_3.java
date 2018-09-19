package src;

import java.util.Scanner;

public class Day_3 {

	public static void main(String[] args) {
		// infinite loop broken by using break in case of c reaching zero or below
		System.out.println("for loop with increment of 1 but skips code if i is even number");
		int c = 10;
		for (;;) { // prints 10-1

			System.out.println("c: " + c);

			c = c - 1;
			if (c <= 0) {
				break; // exits the loop and jumps to the code after loop
			}
		}

//		Scanner scanner = new Scanner(System.in);
//		System.out.println("Ievadi skaitli: ");
//		int to = scanner.nextInt();
//
//		if (int i = 0; i < to; i++) {
//			System.out.println("" + i + ",");		
//		}
//		else (int i = -; i > to; i--); {
//		System.out.println("" + i + ",");
//		}
//		scanner.close();
	}
}