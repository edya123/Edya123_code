import java.util.Scanner;

public class StringDemo {

	public static void main(String[] args) {
		
		Scanner scanner = new Scanner(System.in);
		System.out.println("Ievadi tekstu: ");
		String str = scanner.nextLine();
		
		str = str.trim();
		
		
		System.out.println("'" + str + "'");

		scanner.close();
	}

}
