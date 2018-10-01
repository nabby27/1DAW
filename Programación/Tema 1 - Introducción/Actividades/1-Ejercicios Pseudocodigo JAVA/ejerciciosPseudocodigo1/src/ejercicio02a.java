
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

public class ejercicio02a {
    
    static final int conversion = 1852;
    
    public static void main(String[] args) {
        System.out.println("DE MILLAS A METROS");
        System.out.print("Dime el valor en millas:");
        Scanner teclado = new Scanner(System.in);
        float millas = teclado.nextShort();
        System.out.println(millas + " milla/s son " + (millas * conversion) + " metro/s");
    }
}
