
import java.util.Random;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio05 {
    
    static final int filas = 5;
    static final int columnas = 5;
    static int[][] matriz = new int[filas][columnas];
    
    public static void main(String[] args) {
        rellenarMatrizSimetrica(matriz);
        pintar(matriz);
        esSimetrica(matriz);
    }
    
    private static void rellenarMatriz(int[][] matriz) {
        Random rnd = new Random();
        
        for (int fila = 0; fila < filas; fila++) {
            for (int columna = 0; columna < columnas; columna++) {
                matriz[fila][columna] = rnd.nextInt(11);
            }
        }
    }
    
    private static void rellenarMatrizSimetrica(int[][] matriz) {
        matriz[0][0] = 1;
        matriz[0][1] = 7;
        matriz[0][2] = 6;
        matriz[0][3] = 2;
        matriz[0][4] = 3;
        matriz[1][0] = 7;
        matriz[1][1] = 1;
        matriz[1][2] = 5;
        matriz[1][3] = 4;
        matriz[1][4] = 5;
        matriz[2][0] = 6;
        matriz[2][1] = 5;
        matriz[2][2] = 1;
        matriz[2][3] = 4;
        matriz[2][4] = 1;
        matriz[3][0] = 2;
        matriz[3][1] = 4;
        matriz[3][2] = 4;
        matriz[3][3] = 1;
        matriz[3][4] = 2;
        matriz[4][0] = 3;
        matriz[4][1] = 5;
        matriz[4][2] = 1;
        matriz[4][3] = 2;
        matriz[4][4] = 1;
    }
    
    private static void pintar(int[][] matriz) {
       for (int fila = 0; fila < filas; fila++) {
            for (int columna = 0; columna < columnas; columna++) {
                System.out.print(matriz[fila][columna] + "\t");
            }
            System.out.println("");
        } 
    }
    
    private static void esSimetrica(int[][] matriz) {
        boolean esSimetrica = true;
        for (int fila = 0; fila < filas && esSimetrica; fila++) {
            for (int columna = 0; columna < columnas && esSimetrica; columna++) {
                if (matriz[fila][columna] != matriz[columna][fila]) {
                    esSimetrica = false;
                }
            }
        }
        if (esSimetrica)
            System.out.println("La matriz es simetrica");
        else
            System.out.println("La matriz NO es simetrica");
    }
    
}
