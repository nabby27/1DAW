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
        
        int num = 0;
        float resultado = 0;
        int x = 1;
        float ant = 1;
        Scanner teclado = new Scanner(System.in);
        
        System.out.print("Dime un número para calcular la sucesión: ");
        num = teclado.nextInt();
        
        while (x <= num) {
            resultado = ((3 * ant) + 2);
            ant = resultado;
            System.out.println(x + " - " + resultado);
            x++;
        }
    }
    
}
