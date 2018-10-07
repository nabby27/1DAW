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
public class Ejercicio18 {
    
    public static void main(String[] args) {
        System.out.println("10 Y ...");
        
        int cantidadMenores15 = 0;
        int cantidadMayores50 = 0;
        int catidadEntre24_45 = 0;
        int num = 0;
        int suma = 0;
        Scanner teclado = new Scanner(System.in);
        
        for (int x = 0; x < 10; x++) {
            System.out.print("Dime un número (" + (x+1) + "/10): ");
            num = teclado.nextInt();
            if (num < 15) {
                cantidadMenores15++;
            } else if (num > 50) {
                cantidadMayores50++;
            } else if ((num > 25) && (num < 45)) {
                catidadEntre24_45++;
            }
        }
        
        System.out.println("Hay " + cantidadMenores15 + " número/s menor/es de 15");
        System.out.println("Hay " + cantidadMayores50 + " número/s mayor/es de 50");
        System.out.println("Hay " + catidadEntre24_45 + " número/s entre el 25 y 45");
    }
    
}
