
public class Main {

	public static void main(String[] args) {
			Rectangle rectangle = new Rectangle(6, 8);
			System.out.println("rectangle: " + rectangle);
//			rectangle.length = -10;
			int length = rectangle.getLength();
			rectangle.setLength = 1000;
			
			Rectangle rectangleMod = new Rectangle(rectangle);
			
			System.out.println("rectangle: " + rectangle);
			
			
	}

}
