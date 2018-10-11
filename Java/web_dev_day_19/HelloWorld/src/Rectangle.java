
public class Rectangle {

	//fields
	Integer length;
	Integer width;

	//constructors
	public Rectangle() {
		this(0);
	}

	public Rectangle(Integer len) {
		length = len;
		width = len;
	}

	public Rectangle(Integer length, Integer width) {
		this.length = length;
		this.width = width;
	}

	//	methods
	public int getLegth() {
	return length;
	}
	
	public int getWidth() {
		return width;
	}
	
	public void setLength(int length) {
		
	}
	
	public boolean isSquare() {
		boolean isSquare = length == width;
		return isSquare;
	}

	public int area() {
		int area = length * width;
		return area;
	}

	public int perimeter() {
		int perimeter = (length + width) * 2;
		return perimeter;
	}
	
	@Override
	public String toString() {
		return "";
	}
}
