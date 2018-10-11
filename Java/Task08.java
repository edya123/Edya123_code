import java.util.Random;
import java.util.Scanner;

public class Task08 {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		System.out.print("Ievadi skaitli: ");
		int input = scanner.nextInt();
		
//		Random rnd = new Random();
//		int input = rnd.nextInt(11);
//		input = input - 5;
		
		System.out.println("Skaitlis = " + input);

		// cikls
		System.out.print("" + input + " -> ");

		int from = input < 0 ? input : 0;
		int to = input < 0 ? 0 : input;

		for (int i = from; i <= to; i = i + 1) {
			String separ = (i == to) ? "" :  ",";
			System.out.print("" + i + separ);
		}

//		scanner.close();
	}

}
