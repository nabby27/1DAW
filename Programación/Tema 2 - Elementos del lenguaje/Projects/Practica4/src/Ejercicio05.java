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
public class Ejercicio05 {
    
    public static void main(String[] args) {
        
        int num = 0;
        Scanner teclado = new Scanner(System.in);
        

        System.out.print("Dime un número: ");
        num = teclado.nextInt();
        
        if (num <= 0){
            System.out.print("* ");
        } else {
            for (int i = 0; i < num; i++) {
               System.out.print("* "); 
            }
        }
        
    }
}
