

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio08b {
        
    public static void main(String[] args) {
        
        triangulos();
    }
    
    private static void triangulos() {
        int b = 0;
        for (char c = 'a'; c <= 'z'; c++) {
            b++;
            for(int i = 1; i <= b; i++) {
                //Espacios en blanco
                for(int j = 1; j <= b-i; j++){
                    System.out.print(" ");
                }
                //Asteriscos
                for(int j = 1; j <= (i*2)-1; j++){
                    System.out.print(c);
                }
                System.out.println();
            }
            System.out.println("");
        }
    }
    
}
