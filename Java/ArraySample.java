import java.util.Random;

public class ArraySample {

	public static void main(String[] args) {

		Random rnd = new Random();

		int[] ints = new int[400]; // array for storing 400 random integers

		for (int i = 0; i < ints.length; i++) {
			ints[i] = rnd.nextInt(101); // fill array with integers 0-100
		}

		int[] counters = new int[101]; // array for counting statistics

		for (int i = 0; i < ints.length; i++) {
			int cIndex = ints[i]; // index in counter
			counters[cIndex]++; // counter increment
			System.out.println(" " + i + " : " + ints[i]);
		}

		for (int ii : ints) {
			System.out.println(ii);
		}

		System.out.println(" -------- ");

		int max = 0; // store max value for number generated
		int maxIndex = -1; // at what index was the number i.e the number itself
		for (int i = 0; i < counters.length; i++) {
			if (counters[i] > max) { // if greater value found then store it and index
				max = counters[i];
				maxIndex = i;
			}
			System.out.println("" + i + " : " + counters[i]);
		}

		System.out.println("max: " + max + " number: " + maxIndex);

	}

}
