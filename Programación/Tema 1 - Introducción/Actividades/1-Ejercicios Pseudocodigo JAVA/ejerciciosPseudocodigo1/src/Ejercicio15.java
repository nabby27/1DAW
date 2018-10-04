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
public class Ejercicio15 {
    
    public static void main(String[] args) {
        System.out.println("SUMA POSITIVOS");
        
        float resultado = 0;
        float num = 0;
        Scanner teclado = new Scanner(System.in);
        
        do {
            System.out.print("Dime un número: ");
            num = teclado.nextFloat();
            if (num > 0)
                resultado += num;
        } while (num > -1);
        
        if (resultado > 0)
            System.out.println("La suma de los numeros positivos es: " + resultado);
        else
            System.out.println("No se ha sumado ningún número");
    }
    
}
