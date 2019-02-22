/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class TryCatchException {
    
    public static void main(String[] args) {
        for (int i = 0; i < 10; i++) {
            System.out.println(devuelveEnter(i));
        }
    }
    
    private static int devuelveEnter(int num) {
        try {
            if (num % 2 != 0) {
                throw new Exception("Lanzadera exception");
            }
            return 1;
        } catch (Exception e) {
            return 2;
        }
    }
    
}
