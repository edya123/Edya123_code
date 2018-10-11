import java.util.ArrayList;
import java.util.Scanner;

public class Uzdevums17 {

	public static void main(String[] args) {
		
		ArrayList<String> al = new ArrayList<>();
		al.add("aDs");
		al.add("add");
		al.add("dd");
		al.add("eee");

		System.out.print("al: " + al + " -> ");

		for (int i = 0; i < al.size(); i++) {
			// i
			String item = al.get(i);
//			if (item.length() > 2) {
//				item = item.toUpperCase();
//			}
			al.set(i, item);
			System.out.print(item + ",");
		}
		
		// System.out.println("al: " + al);

	}

}
