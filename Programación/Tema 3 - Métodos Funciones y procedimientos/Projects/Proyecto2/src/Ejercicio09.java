
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
public class Ejercicio09 {
        
    public static void main(String[] args) {
      
        double num1 = 0;
        double num2 = 0;
        double mediaArmonica = 0;
        Scanner sc  = new Scanner(System.in);
        
        System.out.println("Dime el número 1 para calcular la media armonica");
        num1 = sc.nextInt();
        System.out.println("Dime el número 2 para calcular la media armonica");
        num2 = sc.nextInt();
        
        mediaArmonica = mediaArmonica(num1, num2);
        System.out.printf("La media armonica es: %.2f \n", mediaArmonica);
    }
    
    private static double mediaArmonica(double num1, double num2) {
        return inverso(media(inverso(num1), inverso(num2)));
    }
    
    private static double media(double num1, double num2) {
        return (num1+num2)/2;
    }
    
    private static double inverso(double num) {
        return 1/num;
    }
}
