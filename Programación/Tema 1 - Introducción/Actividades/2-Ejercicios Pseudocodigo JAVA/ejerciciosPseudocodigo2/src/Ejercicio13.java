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
public class Ejercicio13 {
    
    public static void main(String[] args) {
        
        int num = 0;
        Scanner teclado = new Scanner(System.in);
        
        do {
            System.out.print("Dime un número de 4 cifras: ");
            num = teclado.nextInt();
            if ((num <= 999) && (num > 9999))
                System.out.println("El número tiene que ser de 4 cifras");
        } while((num <= 999) && (num > 9999));
        num = ((num / 100) * 100);
        System.out.println("El número redondeado es: " + num);
    }
    
}
