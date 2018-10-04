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
        System.out.println("DECIMAL O ENTERO");
        
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime un número: ");
        float num = teclado.nextFloat();
        if ((Math.floor(num) == num) || (Math.floor(num) == -num))
            System.out.println("El número " + num + " es entero");
        else
            System.out.println("El número " + num + " es decimal");
    }

}
