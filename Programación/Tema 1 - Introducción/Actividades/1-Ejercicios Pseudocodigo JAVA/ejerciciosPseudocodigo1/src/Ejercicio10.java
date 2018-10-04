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
public class Ejercicio10 {
    
    public static void main(String[] args) {
        System.out.println("PARES POSITIVOS");
                                              
        int num = 0;
        Scanner teclado = new Scanner(System.in);
        
        System.out.println("¿Cuantos números quieres probar?");
        int cantidad = teclado.nextInt();
        for (int x = 0; x < cantidad; x++) {
            System.out.print("Dime el número (" + (x+1) + "/" + cantidad + "): ");
            num = teclado.nextInt();
            if ((num > 0) && (num %2 == 0))
                System.out.println("El número " + num + " és par y positivo");
        }
    }
    
}
