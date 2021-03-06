import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

class SansaAndXOR{

    static int sansaXor(int[] arr, int n) {
       int result = 0;
	   if((n & 1) == 1){
		   for(int i = 0; i < n; i+=2){
			   result ^= arr[i];
		   }
	   }   
	   
	   return result;
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int t = in.nextInt();
        for(int a0 = 0; a0 < t; a0++){
            int n = in.nextInt();
            int[] arr = new int[n];
            for(int arr_i = 0; arr_i < n; arr_i++){
                arr[arr_i] = in.nextInt();
            }
            int result = sansaXor(arr, n);
            System.out.println(result);
        }
        in.close();
    }
}
