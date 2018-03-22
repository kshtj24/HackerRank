import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class StrongPassword {
    static int []charMap=new int[128];
    static int []typeCount={6,1,1,1,1};

    static void init(){
    String []Categories = {"0123456789","abcdefghijklmnopqrstuvwxyz","ABCDEFGHIJKLMNOPQRSTUVWXYZ", "!@#$%^&*()-+"};
    for(int i=0;i<Categories.length;i++)
     for(int j=0;j<Categories[i].length();j++)
         charMap[Categories[i].charAt(j)]=i+1;
    
      }
    
    static int minimumNumber(int n, String password) {
        for(int i=0;i<password.length();i++)
            typeCount[charMap[password.charAt(i)]]--;
       int required=0;
        for(int i=1;i<typeCount.length;i++)
            required+=typeCount[i]>0?typeCount[i]:0;
        return required > typeCount[0]-n?required:typeCount[0]-n;
        
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        String password = in.next();
        init();
        int answer = minimumNumber(n, password);
        System.out.println(answer);
        in.close();
    }
}