import java.util.Scanner;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio07 {

    static final int n = 4;
    
    public static void main(String[] args) {
        System.out.println( n + " MULTIPLOS");
        
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime un número: ");
        int num = teclado.nextInt();
        
        for (int x = 0; x <= num; x++) {
            System.out.println(n + " x " + x + "= " + (n * x));
        }
    }

}
