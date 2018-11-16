
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
public class Ejercicio02 {
    
    public static void main(String[] args) {
        
        double radio = 0;
        double area = 0;
        double longitud = 0;
        Scanner keyboard = new Scanner(System.in);
       
        System.out.println("Dime el valor del radio");
        radio = keyboard.nextFloat();
        
        area = area(radio);
        longitud = longitud(radio);
        
        System.out.printf("El area es: %.2f \n", area);
        System.out.printf("La longitud es: %.2f \n", longitud);
    }
    
    private static double area(double radio) {
        return Math.PI * Math.pow(radio, 2);
    }
    
    private static double longitud(double radio) {
        return 2 * Math.PI * radio;
    }
    
}
