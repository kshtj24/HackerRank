import java.util.*;

public class FlippingBits {

    static long flippingBits(long N) {
		return ((long)Math.pow(2, 32)- 1) - N;
	}

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int T = in.nextInt();
        for(int a0 = 0; a0 < T; a0++){
            long N = in.nextLong();
            long result = flippingBits(N);
            System.out.println(result);
        }
        in.close();
    }
}
