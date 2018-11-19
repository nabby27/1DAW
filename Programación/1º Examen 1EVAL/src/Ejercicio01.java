
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
public class Ejercicio01 {
    
    public static void main(String[] args) {
        
        int n = 0, mas180 = 0;
        float altura = 0, alturaMinima = 0, alturas = 0;
        Scanner teclado = new Scanner(System.in);
        
        do {
            System.out.println("Dime la altura de " + (n+1) + "(0 para cerrar)");
            altura = teclado.nextFloat();
            if (altura == 0) {
                System.out.println("La altura de la persona más baja es " + alturaMinima);
                System.out.println("La altura media es " + (alturas/n));
                System.out.println("Hay " + mas180 + " persona/s que miden más de 1'80 m");
            } else {
                if (n == 0)
                    alturaMinima = altura;
                if (altura < alturaMinima)
                    alturaMinima = altura;
                if (altura > 1.80)
                    mas180++;
            }
            n++;
            alturas += altura;
        } while (altura != 0);
        
    }
    
}
