/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio02 {
    static final int filas = 7;
    static final int columnas = 7;
    static int[][] miMatriz = new int[filas][columnas];
    
    public static void main(String[] args) {
        
        for (int fila = 0; fila < miMatriz.length; fila++) {
            for (int columna = 0; columna < columnas; columna++) {
                if (columna == fila || (columnas-1 - columna) == fila) {
                    miMatriz[fila][columna] = 1;
                }
            }
        }
        
        paint();
        
    }
    
    private static void paint() {
        for (int[] fila : miMatriz) {
            for (int celda : fila) {
                System.out.print(celda + " ");
            }
            System.out.println("");
        }
    }
}
