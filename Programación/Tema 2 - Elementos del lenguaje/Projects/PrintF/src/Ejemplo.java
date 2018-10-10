/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author AlumMati
 */
public class Ejemplo {
    
     public static void main(String[] args) {
        System.out.printf("%.2f", 12.3698);
        System.out.println("");
        double n = 1.25036;
        System.out.printf("%.3f", n);
        System.out.println("");
        n = -1.25036;
        System.out.printf("%.3f", n);
        System.out.println("");
        n = 1.25036;
        int x = 10;
        System.out.printf("n = %.2f x = %d", n, x);
        System.out.println("");
        System.out.printf("n = %1$.2f x = %2$d %n", n, x); // %n == \n
        System.out.printf("%+10.2f %n", n, x);
        System.out.printf("%+010.2f %n", n, x);
        System.out.printf("%10s %n", "Total:");
        System.out.printf("%10c %n", 'h');
    }
    
}
