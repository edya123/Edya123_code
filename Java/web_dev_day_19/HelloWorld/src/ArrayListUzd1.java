import java.util.ArrayList;

public class ArrayListUzd1 {

	public static void main(String[] args) {
		ArrayList<String> al = new ArrayList<>();
		al.add("aDs");
		al.add("add");
		al.add("dd");
		al.add("ee");
//		izveidots saraksts ar patvaïîgâm vçrtîbâm
		System.out.print("al: " + al + " -> ");
		for (int i = 0; i < al.size(); i++) {
			String item = al.get(i);
			if (item.length() > 2) {
				item = item.toUpperCase();
				al.set(i,  item);
			}
			al.set(i, item);
			System.out.println("" + i + " : " + item);
		}
		System.out.println("al: " + al);
	}

}