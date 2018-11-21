
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
        
        int num = 0;
        Scanner sc = new Scanner(System.in);
        
        System.out.println("Dime un número para calcular cuantas cifras tiene:");
        num = sc.nextInt();
        cifras(num);
    }
    
    /**
     * Método que muestra las cifras de un número
     * @param num número del cual mostrar sus cifras
     */
    private static void cifras(int num) {
        String numString = num+""; 
        System.out.println("El número " + num + " tiene " + numString.length() + " cifra/s");
    }
    
}
