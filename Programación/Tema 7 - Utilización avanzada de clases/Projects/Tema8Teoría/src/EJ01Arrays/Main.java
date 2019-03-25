/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package EJ01Arrays;

import java.util.Arrays;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Main {
    
    public static void main(String[] args) {
        int arrayInt[] = {2, 4, 8, 6, 10};
        double[] arrayDouble = {2.5, 6.5, 4.5, 8.5, 10.5};
        int arrayLleno[] = new int[10];
        int copiaArray[] = new int[arrayInt.length];
        
        Arrays.fill(arrayLleno, 3);
        paintArray(arrayLleno);
        Arrays.sort(arrayInt);
        paintArray(arrayInt);
        System.arraycopy(arrayInt, 0, copiaArray, 0, arrayInt.length);
        paintArray(copiaArray);
        
    }
    
    private static void paintArray(int[] vector) {
        for (int number : vector) {
            System.out.print(number + " ");
        }
        System.out.println("");
    }
    
    private static void paintArray(double[] vector) {
        for (double number : vector) {
            System.out.print(number + " ");
        }
        System.out.println("");
    }
    
}
