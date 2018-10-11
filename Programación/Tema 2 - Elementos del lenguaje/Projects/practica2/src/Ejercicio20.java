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
public class Ejercicio20 {
        
    public static void main(String[] args) {
        
        int cant = 0;
        int plazo = 0;
        float tipoInt = 0;
        float val = 0;
        float retHac = 0;
        Scanner teclado = new Scanner(System.in);
        
        System.out.println("Introduce la cantidad: ");
        cant = teclado.nextInt();
        
        System.out.println("Introduce el tipo de interés: ");
        tipoInt = teclado.nextFloat();
        
        System.out.println("Introduce la duracion del plazo: ");
        plazo = teclado.nextInt();

        val = cant * tipoInt / 100;
        System.out.println("Cantidad de los intereses: " + val + "€");
        val = val * plazo;
        System.out.println("Cantidad al final del plazo: " + val + "€");
        retHac = val * 18/100;
        System.out.println("Retencion de Hacienda: " + retHac + "€");
        val = val - retHac;
        System.out.println("Interes final: " + val + "€");
   }
   
}
