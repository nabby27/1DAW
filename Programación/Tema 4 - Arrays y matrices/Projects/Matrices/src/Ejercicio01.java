
/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio01 {
    
    static int[][] tb = new int[10][10];
    
    public static void main(String[] args) {
        
        for (int linea = 0; linea < 10; linea++) {
            for (int celda = 0; celda < 10; celda++) {
                if ((celda+1) % 2 == 0){
                    tb[linea][celda] = 1;
                } else {
                    tb[linea][celda] = 0;
                }
            }
        }
        
        paint();
        
    }
    
    private static void paint() {
        for (int[] linea : tb) {
            for (int celda : linea) {
                System.out.print(celda + " ");
            }
            System.out.println("");
        }
    }
    
}
