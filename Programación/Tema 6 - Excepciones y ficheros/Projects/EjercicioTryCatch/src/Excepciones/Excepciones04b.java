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
public class Excepciones04b {
    
    public static void main(String[] args) {
        dividirEntreArray(2, new int[] {-2, -1, 0, 1, 2});
    }
    
    public static void dividirEntreArray(int num, int[] nums) {
        for (int numDivisor : nums) {
            try {
                System.out.println(num / numDivisor);
            } catch (ArithmeticException e) {
                System.out.println("Error");
            }
        }
    }
    
}
