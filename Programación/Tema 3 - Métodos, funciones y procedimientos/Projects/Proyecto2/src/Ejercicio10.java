
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
public class Ejercicio10 {
        
    public static void main(String[] args) {
      for (int i = 1; i <= 20; i++) {
          System.out.print("Factorial de " + i + ": ");
          System.out.println(factorial(i));
      }        
    }
    
    private static long factorial(int num) {
        long result = 1;
        for (int i = 1; i <= num; i++) {
            result *= i;
        }
        return result;
    } 
}
