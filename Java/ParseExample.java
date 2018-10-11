
public class ParseExample {
	
	public static void main(String[] args) {
		String[] s = new String[1];
		System.out.println("s[0]: " + s[0]);
//		s[0] = "123.0123";
		
		String str = s[0];
		
		float value = Float.parseFloat(s[0]);
		System.out.println("value: " + value + " --> sqr: "+ (value * value));
	}
}
