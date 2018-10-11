import java.util.Scanner;

public class MethodsSimpleExample{

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int a  = scanner.nextInt();
		
		printHello("rez: " + add(a, 8));
		doNothing();
		
		scanner.close();
	}
	
	public static void doNothing() {
		printHello("Chillin");
	}
	
	public static void printHello(String message) {
		System.out.println(message.toUpperCase());
	}
	
	public static int add(int a, int b) {
		int result = a + b;
		return result;
	}
	
	public static String addAsString(int a, int b) {
		int result = a + b;
		return "" + result;
	}
}
