import java.util.Scanner;

public class ScannerExample {

	public static void main(String[] args) {
		System.out.println("Ievadi kādu vārdu: ");
		Scanner scanner = new Scanner(System.in);
		
		String name = scanner.nextLine();
		System.out.println("Tu ievadīji: '" + name + "'");
		
		System.out.println("Ievadi veselu skaitli: ");
		int number = scanner.nextInt();
		System.out.println("Tu ievadīji skaitli: '" + number + "'");

		System.out.println("Ievadi decimālskaitli skaitli: ");
		double doubleNumber = scanner.nextDouble();
		System.out.println("Tu ievadīji decimālskaitli: '" + doubleNumber + "'");
		
		scanner.close();
	}

}
