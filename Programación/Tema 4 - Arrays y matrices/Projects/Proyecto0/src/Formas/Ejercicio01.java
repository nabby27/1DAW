/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Formas;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio01 {
    
    static final int filas = 11;
    static final int columnas = (filas <= 4) ? 4 : (filas/2)+1;
    
    public static void main(String[] args) {
        
        int count = 1;
        
        for (int fila = 1; fila <= filas; fila++) {            
            if (fila % 2 == 0) {
                for (int columna = 1; columna <= columnas-4; columna++) {
                    System.out.print(" ");
                }
                for (int columna = 1; columna <= 4; columna++) {
                    System.out.print("*");
                }
            }
            else {
                for (int i = 0; i < (columnas-count); i++) {
                    System.out.print(" "); 
                }
                for (int i = 0; i < count; i++) {
                    System.out.print("*");
                }
                count++;
            }
            System.out.println("");
        }
    }
    
}
