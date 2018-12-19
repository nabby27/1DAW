
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
public class Ejercicio14 {
    
    
    static Random rnd = new Random();
    static final int filas = 5;
    static final int columnas = 5;
    
    public static void main(String[] args) {
        
        int[][] cuadrado = new int[filas][columnas];
        
        rellenarMatriz(cuadrado);
        pintarTodo(cuadrado);
        diagonalSecundaria(cuadrado);
        elementoMayor(cuadrado);
        intercambioFila(cuadrado, 2, 3);
    }
    
    private static void rellenarMatriz(int[][] matriz) {
        
        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz[i].length; j++) {
                matriz[i][j] = (rnd.nextInt(100)+1);
            }
        }
    }
    
    private static void pintarTodo(int[][] matriz) {
        System.out.println("La matriz es:");
        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz[i].length; j++) {
                System.out.print(matriz[i][j] + "\t");
            }
            System.out.println("");
        }
        System.out.println("");
    }
    
    private static void diagonalSecundaria(int[][] matriz) {
        System.out.println("La diagonal secundaria es:");
        for (int i = 0; i < matriz.length; i++) {
            System.out.print(matriz[i][matriz.length-i-1] + "\t");
        }
        System.out.println("");
    }
    
    private static void elementoMayor(int[][] matriz) {
        int filaDondeEstaMayor = 0;
        int columnaDondeEstaMayor = 0;
        System.out.println("");
        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz[i].length; j++) {
                if (i == 0 && j == 0 || matriz[i][j] > matriz[filaDondeEstaMayor][columnaDondeEstaMayor]) {
                    filaDondeEstaMayor = i;
                    columnaDondeEstaMayor = j;
                }
            }
        }
        System.out.println("El número mayor esta en la fila " + (filaDondeEstaMayor+1) + " columna " + (columnaDondeEstaMayor+1));
        System.out.println("El número es: " + matriz[filaDondeEstaMayor][columnaDondeEstaMayor]);
        System.out.println("");
    }
    
    private static void intercambioFila(int[][] matriz, int indexFila, int indexFila2) {
        System.out.println("Interambio de la fila " + (indexFila+1) + " por la fila " + (indexFila2+1));
        int[][] matriz2 = new int[filas][columnas];
        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz[i].length; j++) {
                if (i == indexFila || i == indexFila2) {
                    matriz2[indexFila][j] = matriz[indexFila2][j];
                    matriz2[indexFila2][j] = matriz[indexFila][j];
                } else {
                    matriz2[i][j] = matriz[i][j];
                }
            }
        }
        
        pintarTodo(matriz2);
    }
    
}
