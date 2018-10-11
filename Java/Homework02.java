import java.util.Scanner;

public class Homework02 {

	public static void main(String[] args) {

		Scanner scanner = new Scanner(System.in);

		System.out.print("Ievadi datumu: ");
		int date = scanner.nextInt();

		System.out.print("Ievadi mēnesi: ");
		int month = scanner.nextInt();

		System.out.print("Ievadi gadu: ");
		int year = scanner.nextInt();

		if (year % 4 == 0) {
			System.out.println("Leap year");
		} else {
			System.out.println("Not Leap year");
		}
		
		if (date < 1 || date > 31) {
			System.out.println("Datums " + date + " nav derīgs");
			System.exit(0);
		}

		if (month < 1 || month > 12) {
			System.out.println("Mēnesis " + month + " nav derīgs");
		}

		switch (month) {
		// 31
		case 1:
		case 3:
		case 5:
		case 7:
		case 8:
		case 10:
		case 12:
			if (date > 31) {
				System.out.println("Datums " + date + " nav derīgs!");
			}
			break;

		case 4:
		case 6:
		case 9:
		case 11:
			if (date > 30) {
				System.out.println("Datums " + date + " nav derīgs!");
			}
				
			break;
		// ??
		case 2:
			boolean leapYear = year % 4 == 0;
			if ( (leapYear && date > 29) || (!leapYear && date > 28)) {
				System.out.println("Datums " + date + " nav derīgs!");
				System.exit(0);
			}
			// System.out.println("month is " + 12);
			break;

		default:
			break;
		}



		String monthString = "";

		switch (month) {
		case 1:
			monthString = "Janvāris";
			break;
		case 2:
			monthString = "Februāris";
			break;
		case 3:
			monthString = "Marts";
			break;
		case 4:
			break;
		case 5:
			break;
		case 6:
			break;
		case 7:
			break;
		case 8:
			break;
		case 9:
			break;
		case 10:
			break;
		case 11:
			break;
		case 12:
			break;

		default:
			break;
		}
		System.out.println(date + ". " + monthString);

		// System.out.println("date: " + date + ", month: " + month);
	}

}
