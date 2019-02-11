
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
public class Ejercicio03 {
    static final int filas = 5;
    static final int columnas = 4;
    static int[][] matriz1 = new int[filas][columnas];
    static int[][] matriz2 = new int[filas][columnas];
    static int[][] matrizResultado = new int[filas][columnas];
    
    public static void main(String[] args) {
        
        rellenarMatriz(matriz1);
        rellenarMatriz(matriz2);
        sumarMatrizes(matriz1, matriz2, matrizResultado);

        System.out.println("Matriz 1");
        pintar(matriz1);
        System.out.println("");
        System.out.println("Matriz 2");
        pintar(matriz2);
        System.out.println("");
        System.out.println("Matriz 1 x Matriz 2");
        pintar(matrizResultado);
    }
    
    private static void rellenarMatriz(int[][] matriz) {
        Random rnd = new Random();
        
        for (int fila = 0; fila < filas; fila++) {
            for (int columna = 0; columna < columnas; columna++) {
                matriz[fila][columna] = rnd.nextInt(11);
            }
        }
    }
 
    private static void sumarMatrizes(int[][] matriz1, int[][] matriz2, int [][] matrizRes) {
       for (int fila = 0; fila < filas; fila++) {
            for (int columna = 0; columna < columnas; columna++) {
                matrizRes[fila][columna] = matriz1[fila][columna] + matriz2[fila][columna];
            }
        } 
    }

    private static void pintar(int[][] matriz) {
       for (int fila = 0; fila < filas; fila++) {
            for (int columna = 0; columna < columnas; columna++) {
                System.out.print(matriz[fila][columna] + "\t");
            }
            System.out.println("");
        } 
    }
    
}
