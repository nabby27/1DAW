/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Break {
    
    /**
     * Método principal
     * 
     * @param args 
     */
    public static void main(String args []) {
        int i;
        
        for (i = 1; i <= 4; i++) {
            if (i == 3)
                break;
            System.out.println ("Itereación: " + i);
        }
        
        System.out.println("");
        
        for (i = 1; i <= 4; i++) {
            if (i == 3)
                continue;
            System.out.println ("Itereación: " + i);
        }
    }
    
}
