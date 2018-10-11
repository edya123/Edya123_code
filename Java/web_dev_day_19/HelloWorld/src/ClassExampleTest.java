
public class ClassExampleTest {

	public static void main(String[] args) {

		System.out.println("counter: " + ClassExample.counter);

		ClassExample example = new ClassExample(7);
		example.printZ();

		ClassExample exampleOther = new ClassExample(9, 4);
		exampleOther.printZ();

		System.out.println(exampleOther);

	}

}
