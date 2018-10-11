import java.util.ArrayList;

public class ArrayListExamples {

	public static void main(String[] args) {
		
		int[] test = {-10, 1, 2, 3, 4, 5, 66, 77, 100};
		test[0] = -100;
		
		ArrayList<Integer> source = new ArrayList<>();
		source.add(777);
		source.add(999);
		
		ArrayList<Integer> al = new ArrayList<>();
		al.add(-10);
		al.add(1);
		al.add(2);
		al.add(3);
		al.add(5);
		System.out.println("mid size: " + al.size());
		
		al.add(66);
		al.add(7);
		al.add(100);
		
		System.out.println("before remove size: " + al.size());
		al.remove(3);
		System.out.println("final size: " + al.size());
		
//		System.out.println("al: " + al);
//		al.remove(refI);
//		System.out.println();

	}

}
