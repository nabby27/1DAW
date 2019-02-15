
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
public class Ejercicio04 {
    
    static final int filas = 3;
    static final int columnas = 6;
    static int[][] matriz = new int[filas][columnas];
    
    public static void main(String[] args) {
        rellenarMatriz(matriz);
        pintar(matriz);
        menorNumeroDeMatriz(matriz);
        mayorNumeroDeMatriz(matriz);
        menorNumeroDeFila(matriz);
        menorNumeroDeColumna(matriz);
        mediaMatriz(matriz);
        sumaMatriz(matriz);
    }
    
    private static void rellenarMatriz(int[][] matriz) {
        Random rnd = new Random();
        
        for (int fila = 0; fila < filas; fila++) {
            for (int columna = 0; columna < columnas; columna++) {
                matriz[fila][columna] = rnd.nextInt(11);
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
    
    private static void menorNumeroDeMatriz(int[][] matriz) {
        int menor = 11;
        for (int fila = 0; fila < filas; fila++) {
            for (int columna = 0; columna < columnas; columna++) {
                if (matriz[fila][columna] < menor) {
                    menor = matriz[fila][columna];
                }
            }
        }
        System.out.println("El menor número de toda la matriz es: " + menor);
    }
    
    private static void mayorNumeroDeMatriz(int[][] matriz) {
        int mayor = 0;
        for (int fila = 0; fila < filas; fila++) {
            for (int columna = 0; columna < columnas; columna++) {
                if (matriz[fila][columna] > mayor) {
                    mayor = matriz[fila][columna];
                }
            }
        }
        System.out.println("El mayor número de toda la matriz es: " + mayor);
    }
    
    private static void menorNumeroDeFila(int[][] matriz) {
        int menor;
        int columnaMenor;
        for (int fila = 0; fila < filas; fila++) {
            menor = 11;
            columnaMenor = 0;
            for (int columna = 0; columna < columnas; columna++) {
                if (matriz[fila][columna] < menor) {
                    menor = matriz[fila][columna];
                    columnaMenor = columna;
                }
            }
            System.out.println("El menor número de la fila " + (fila+1) + " es: " + menor + ", se encuentra en la columna " + (columnaMenor+1));
        }
    }
    
    private static void menorNumeroDeColumna(int[][] matriz) {
        int menor;
        int filaMenor;
        for (int columna = 0; columna < columnas; columna++) {
            menor = 11;
            filaMenor = 0;
            for (int fila = 0; fila < filas; fila++) {
                if (matriz[fila][columna] < menor) {
                    menor = matriz[fila][columna];
                    filaMenor = fila;
                }
            }
            System.out.println("El menor número de la columnas " + (columna+1) + " es: " + menor + ", se encuentra en la fila " + (filaMenor+1));
        }
    }
    
    private static void mediaMatriz(int[][] matriz) {
        float sumador = 0;
        int contador = 0;
        for (int fila = 0; fila < filas; fila++) {
            for (int columna = 0; columna < columnas; columna++) {
                contador++;
                sumador += matriz[fila][columna];
            }
        }
        System.out.println("La media de la matriz es: " + (sumador/contador));
    }
    
    private static void sumaMatriz(int[][] matriz) {
        float sumador = 0;
        for (int fila = 0; fila < filas; fila++) {
            for (int columna = 0; columna < columnas; columna++) {
                sumador += matriz[fila][columna];
            }
        }
        System.out.println("La suma de la matriz es: " + sumador);
    }
    
}
