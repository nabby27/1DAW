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
public class Ejercicio20a {
    
    public static void main(String[] args) {
        System.out.println("TABLA DE MULTIPLICAR");
        
        int num = 0;
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime un número: ");
        num = teclado.nextInt();
        System.out.println("TABLA DE MULTIPLICAR DE " + num);
        for (int x = 0; x < 11; x++) {
            System.out.println(num + " x " + x + "= " + (num * x));
        }
    }
    
}
