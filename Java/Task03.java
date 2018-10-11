import java.util.Scanner;

public class Task03 {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Ievadi skaitli a: ");
		int a = scanner.nextInt();
		
		System.out.print("Ievadi skaitli b: ");
		int b = scanner.nextInt();
		
		int sum = a + b;
		
		if (sum > 9 && sum <20) {
			sum = 20;
		} 
		System.out.println("sum: " + sum);
		
		scanner.close();

	}

}
