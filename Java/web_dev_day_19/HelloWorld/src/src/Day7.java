package src;

public class Day7 {

	
	public static int cubeNumber(int number) {
		return number * number * number;		
	}
	
	public static int smallestNumber(int x, int y, int z) {
		int xyMin = Math.min(x, y);
		int result = Math.min(xyMin, z);
		return result;
    }
	
	public static double avarageArr(int[] in) {
			return 0.0;
	}
}
