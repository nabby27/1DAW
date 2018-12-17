
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
public class Ejercicio04 {
    
    public static void main(String[] args) {
        
        int numFilas = 0;
        int numColumnas = 0;
        System.out.print("Dime el tamaño del triangulo: ");
        Scanner sc = new Scanner(System.in);
        numFilas = sc.nextInt();
        
        numColumnas = (numFilas*2)-1;
        
        System.out.println("");
            for (int j = numFilas; j > 0 ; j--) {
                
                for (int k = 0; k < j-1; k++){
                    System.out.print(" ");
                }
            
                for (int k = 0; k < (numColumnas-(j-1)*2); k++){
                    System.out.print("*");
                }

                for (int k = 0; k < j-1; k++){
                    System.out.print(" ");
                }
                System.out.println("");
            }
            
        
    }
    
}
