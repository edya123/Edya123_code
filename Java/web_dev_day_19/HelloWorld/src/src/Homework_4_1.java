package src;

import java.util.Scanner;

public class Homework_4_1 {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);

		System.out.print("Ievadi datumu: ");
		int date = scanner.nextInt();

		System.out.print("Ievadi m�nesi: ");
		int month = scanner.nextInt();

		if (date < 1 || date > 31) {
			System.out.println("Datums " + date + " nav der�gs");
			System.exit(0);
		}
		if (month < 1 || month > 12) {
			System.out.println("M�nesis " + month + " nav der�gs");
			System.exit(0);
		}
		switch (month) {
		case 1:
		case 3:
		case 5:
		case 7:
		case 8:
		case 10:
		case 12: if (date > 31) System.out.println("Datums " + date + " nav der�gs!");
			break;
		case 4:
		case 6:
		case 9:
		case 11: if 
		(date > 30) { 
			System.out.println("Datums " + date + " nav der�gs!");
		}
			break;
		case 2: if (date > 29 && year % 4 == 0) || (date > 28 && year % 4 != 0)) {
			System.out.println("Datums " + date + " nav der�gs!");
		}
		break;
		
		default:
			break;
		}
		
		int year = 2004;
		if (year % 4 ==0) {
			System.out.println("Leap year");
		}	else {
			
		}
		
		String monthString = "";
		
		switch (month ) {
		case 1: monthString = "Janv�ris"; break;
		case 2: monthString = "Febru�ris"; break;
		case 3: monthString = "Marts"; break;
		case 4: monthString = "Apr�lis"; break;
		case 5: monthString = "Maijs"; break;
		case 6: monthString = "J�nijs"; break;
		case 7: monthString = "J�lijs"; break;
		case 8: monthString = "Augusts"; break;
		case 9: monthString = "Septembris"; break;
		case 10: monthString = "Oktobris"; break;
		case 11: monthString = "Novembris"; break;
		case 12: monthString = "Decembris"; break;
		
		}
		System.out.println("date: " + date + ", month: " + month);

	}

}
