import java.util.ArrayList;
import java.util.Arrays;

public class ArrayListSample {

	public static void main(String[] args) {
		
		int[] test = {-10, 1, 1, 1, 5, 66, 7, 100};
		test[0] = -100;
		
		ArrayList<Integer> source = new ArrayList<>(Arrays.asList(777, 999, 888, -10000));
		
		ArrayList<String> strList = new ArrayList<>(Arrays.asList("aaa","nnn"));

		
		ArrayList<Integer> al = new ArrayList<>(source);
		System.out.println("size: " + al.size());

		Integer refI = new Integer(111300);
		//al.addAll(source);
		al.add(-10);
		al.add(1);
		al.add(2);

		al.add(8);
		al.add(refI);
		al.add(66);
		al.add(7);
		al.add(100);
		
		System.out.println("al after add all: " + al + ", size: " + al.size());
	
		
		al.remove(3);
		System.out.println("final size: " + al.size());

		System.out.println("al: " + al);
		al.remove(refI);
		System.out.println("al after ref remove: " + al);
		al.clear();
		System.out.println("al after clear: " + al + ", empty: " + al.isEmpty());
	}

}
