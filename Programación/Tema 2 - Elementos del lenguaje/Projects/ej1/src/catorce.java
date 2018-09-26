/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author AlumMati
 */
public class catorce {
    
    public static void main(String[] args) {
        int a, b, c;
        System.err.println("\t\tA \tB \tC");
        System.err.println("------------------------------------");
        a = 3;
        System.err.println("a=3; \t\t" + a);
        b = 4;
        System.err.println("b=4; \t\t" + a + "\t" + b);
        c = a + 2 * --b;
        System.err.println("c=a+2*--b; \t" + a + "\t" + b + "\t" + c);
        c += b;
        System.err.println("c+=b; \t\t" + a + "\t" + b + "\t" + c);
        b = c - a++;
        System.err.println("b=c-a++; \t" + a + "\t" + b + "\t" + c);
        a = b * c;
        System.err.println("a=b*c; \t\t" + a + "\t" + b + "\t" + c);
        
    }
}
