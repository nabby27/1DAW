
import java.util.Scanner;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author AlumMati
 */
public class Ejercicio03 {
    
    public static void main(String[] args) {
        
        int n = 0, cont = 0;
        float suma = 0;
        Scanner teclado = new Scanner(System.in);
        
        for (int alum = 1; alum <= 15; alum++) {
            suma = 0;
            cont = 0;
            
            do {
                System.out.print("Dime un número: ");
                n = teclado.nextInt();
                suma = suma + n;
                cont = cont + 1;
            } while (cont < 5);
            System.out.println("La media del alumno " + alum + " es " + (suma/cont));
        }
    }
}
