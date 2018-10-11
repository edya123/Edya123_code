import java.util.Scanner;

public class Task01 {

	public static void main(String[] args) {
		System.out.println("Aiziet!!!");

		Scanner scanner = new Scanner(System.in);

		System.out.print("Ievadi skaitli a: ");
		int a = 5;
		
		System.out.print("Ievadi skaitli b: ");
		int b = scanner.nextInt();

		System.out.println("summa: " + (a + b));
		
		scanner.close();
	}

}
