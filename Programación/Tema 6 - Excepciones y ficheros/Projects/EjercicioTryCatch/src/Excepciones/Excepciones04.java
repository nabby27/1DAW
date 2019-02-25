/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Excepciones;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Excepciones04 {
    
    public static void main(String[] args) {
        try {
            dividirEntreArray(2, new int[] {-2, -1, 0, 1, 2});
        } catch (ArithmeticException e) {
            System.out.println(e.getMessage());
        }
    }
    
    public static void dividirEntreArray(int num, int[] nums) {
        for (int numDivisor : nums) {
            if (numDivisor != 0)
                System.out.println(num / numDivisor);
            else 
                System.out.println("No se puede dividir entre 0");
        }
    }
    
}
