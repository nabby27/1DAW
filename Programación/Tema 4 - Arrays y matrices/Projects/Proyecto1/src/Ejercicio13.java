
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
public class Ejercicio13 {
    
    
    static Random rnd = new Random();
    
    public static void main(String[] args) {
        
        int[][] cuadrado = new int[5][5];
        
        rellenarMatriz(cuadrado);
        pintarTodo(cuadrado);
        diagonalPrincipal(cuadrado);
        suma(cuadrado);
        cambioACero(cuadrado, 2);
        pintarTodo(cuadrado);
    }
    
    private static void rellenarMatriz(int[][] matriz) {
        
        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz[i].length; j++) {
                matriz[i][j] = (rnd.nextInt(10)+1);
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
    
    private static void diagonalPrincipal(int[][] matriz) {
        System.out.println("La diagonal principal es:");
        for (int i = 0; i < matriz.length; i++) {
            System.out.print(matriz[i][i] + "\t");
        }
        System.out.println("");
    }
    
    private static void suma(int[][] matriz) {
        int suma = 0;
        System.out.println("La suma de las filas es:");
        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz[i].length; j++) {
                suma += matriz[i][j];
            }
            System.out.println("Fila " + (i+1) + " = " + suma);
            suma = 0;
        }
        System.out.println("");
    }
    
    private static void cambioACero(int[][] matriz, int indexCol) {
        System.out.println("cambio a 0 en la columna: " + (indexCol+1));
        for (int i = 0; i < matriz.length; i++) {
            matriz[i][indexCol] = 0;
        }
    }
    
}
