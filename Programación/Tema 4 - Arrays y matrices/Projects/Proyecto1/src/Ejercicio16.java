
import java.util.Random;
import java.util.Scanner;


/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Iván Córdoba Donet
 */
public class Ejercicio16 {
    
    
    static Random rnd = new Random();
    static Scanner sc = new Scanner(System.in);
    static final int filas = 2;
    static final int columnas = 2;
    
    public static void main(String[] args) {
        
        int[][] cuadrado = new int[filas][columnas];
        
        rellenar(cuadrado);
        pintarTodo(cuadrado);
        comprobarSiEsMagico(cuadrado);
        
    }
    
    private static void rellenar(int[][] matriz) {        
        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz[i].length; j++) {
                System.out.println("Dime el número en la celda " + (i+1) + "x" + (j+1));
                matriz[i][j] = sc.nextInt();
            }
        }
    }
    
    private static void pintarTodo(int[][] matriz) {
        System.out.println("Cuadrado:");
        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz[i].length; j++) {
                System.out.print(matriz[i][j] + "\t");
            }
            System.out.println("");
        }
        System.out.println("");
    }
    
    private static void comprobarSiEsMagico(int[][] matriz) {
        System.out.println("Comprobando si es mágico");
        boolean magico = true;
        int[] sumaFila = new int[filas];
        int[] sumaColumna = new int[columnas];
        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz[i].length; j++) {
                sumaFila[j] += matriz[i][j];
                sumaColumna[i] += matriz[i][j];
            }
        }
        
        for (int i = 0; i < sumaFila.length-1; i++) {
            for (int j = 0; j < sumaColumna.length-1; j++) {
                if (sumaFila[i] != sumaFila[i+1] ||
                    sumaColumna[j] != sumaColumna[j] ||
                    sumaFila[i] != sumaColumna[j]) {
                        magico = false;
                }
            }
        }
        
        if (magico)
            System.out.println("Es mágico todos los lados suman " + sumaFila[0]);
        else
            System.out.println("No es mágico");
    }
    
}
