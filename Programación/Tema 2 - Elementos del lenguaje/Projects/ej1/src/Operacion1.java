/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córodoba Donet
 */
public class Operacion1 {
    
    /**
     * Método principal
     * 
     * @param args 
     */
    public static void main (String args[]) {
        byte x = 33;
        float y = 33.33f;
        System.out.println(x);
        System.out.println(y);
        
        System.out.println("x mod 10 = " + x % 10);
        System.out.println("y div 10 = " + y / 10);
        System.out.println("y mod 10 = " + y % 10);
        System.out.println("La parte entera de \"y\" es: " + (int) y);

        System.out.println("\nValor de x:\n" + x);
        System.out.println("");
        System.out.println("Valor de \rx:" + x);
        System.out.println("");
        System.out.println("Valor de \tx:" + x);
        System.out.println("");
        System.out.println("\111 \126 \101 \116");
    }
    
}
