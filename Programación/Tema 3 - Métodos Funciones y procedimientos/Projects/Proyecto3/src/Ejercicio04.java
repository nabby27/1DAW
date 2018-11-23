
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
public class Ejercicio04 {
    
    public static void main(String[] args) {
        
        int numfinal = 0;
        int num = 0;
        int cont = 1;
        Scanner sc = new Scanner(System.in);
        
        do {
            System.out.println("Dime un número (número negativo para cerrar)");
            num = sc.nextInt();
            if (num < 0) {
                System.out.println("El número final es: " + numfinal);
            } else {
                num *= cont;
                numfinal += num;
                cont *= 10;
            }
        } while(num > 0);
    }
    
}
