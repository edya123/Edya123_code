import java.util.Random;

public class ClassExample {

	public static int counter;
	public int z;

//	public static void main(String[] args) {
//		z++;
//		System.out.println(z);
//		other();
//		other();
//		other();
//		System.out.println(z);
//	}
//	public static void other() {
//		z--;
//		System.out.println(z);
//	}
	public ClassExample() {
		this(0);
	}

	public ClassExample(int maxRandom) {
		this(maxRandom, 0);
	}

	public ClassExample(int maxRandom, int offset) {
		z = new Random().nextInt(maxRandom) + 1;
//		counter++;
	}

	public void printZ() {
		z++;
		System.out.println(z);

	}

}
