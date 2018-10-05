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
public class Ejercicio32 {
    
    public static void main(String[] args) {
        System.out.println("FIBONACCI");
        
        long resultado = 0;
        long x = 0;
        long y = 1;
        int num = 0;
        Scanner teclado = new Scanner(System.in);
        
        do {
            System.out.print("Dime un número:");
            num = teclado.nextInt();
            if (num < 0) 
                System.out.println("El número tiene que ser positivo");
        } while(num < 0);
        
        if (num == 0)
            System.out.print(x);
        else {
            System.out.print(x + ", ");
            System.out.print(y);
        }
        for (int contador = 1; contador < num; contador++) {
            resultado = x + y;
            System.out.print(", " + resultado);
            x = y;
            y = resultado;
        }
        System.out.println(" ");
    }
    
}
