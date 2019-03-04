/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio01;

import java.util.ArrayList;
import java.util.Random;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Matriz {
    
    static int filas = 6;
    static int columnas = 6;
    static int matriz[][] = new int[filas][columnas];
    static ArrayList<Integer> mayoresDeCadaFila = new ArrayList<Integer>();
            
    public static void main(String[] args) {
        rellenarMatriz();
        System.out.println("a) La matriz es la siguiente:");
        visualizarMatriz();
        System.out.println("b) La diagonal secundaria es:");
        Dsecundaria();
        System.out.println("");
        System.out.println("c) El núemro menor es: ");
        posicion_menor();
        System.out.println("d) Nuestra matriz tras intercambiar las filas 6 y 5 es:");
        cambio(matriz, 5, 4);
        visualizarMatriz();
        System.out.println("e) Nuestro array con los mayores elementos de cada fila:");
        mayorDeLaFila();
        System.out.println("");
        System.out.println("");
        System.out.println("f) El mismo vector ordenado de mayor a menor:");
        ordenar();
        System.out.println("");
        System.out.println("");
        dosNumerosConsecutivos();
    }
    
    private static void rellenarMatriz() {
        Random rnd = new Random();
        for (int fila = 0; fila < filas; fila++) {
            for (int columna = 0; columna < columnas; columna++) {
                matriz[fila][columna] = rnd.nextInt(51)+10;
            }
        }
    }
    
    private static void visualizarMatriz() {
        for (int fila = 0; fila < filas; fila++) {
            for (int columna = 0; columna < columnas; columna++) {
                System.out.print(matriz[fila][columna] + "\t");
            }
            System.out.println("");
        }
        System.out.println("");
    }
    
    private static void Dsecundaria() {        
        int columna = columnas-1;
        for (int fila = 0; fila < filas; fila++) {
            System.out.print(matriz[fila][columna] + "\t");
            columna--;
        }
        System.out.println("");
    }
    
    private static void posicion_menor() {
        int menor = 61;
        int filaMenor = 0;
        int columnaMenor = 0;
        for (int fila = 0; fila < filas; fila++) {
            for (int columna = 0; columna < columnas; columna++) {
                if (matriz[fila][columna] < menor) {
                    menor = matriz[fila][columna];
                    filaMenor = fila;
                    columnaMenor = columna;
                }
            }
        }
        System.out.println(menor + " y se encuentra en la fila " + (filaMenor+1) + ", columna " + (columnaMenor+1));
        System.out.println(""); 
    }
    
    private static void cambio(int[][] matriz, int filaCambio1, int filaCambio2) {
        int filaAux[] = matriz[filaCambio1];
        matriz[filaCambio1] = matriz[filaCambio2];
        matriz[filaCambio2] = filaAux;
    }
    
    private static void mayorDeLaFila() {
        int mayorFila = 0;
        for (int fila = 0; fila < filas; fila++) {
            mayorFila = 0;
            for (int columna = 0; columna < columnas; columna++) {
                if (matriz[fila][columna] > mayorFila) {
                    mayorFila = matriz[fila][columna];
                }
            }
            mayoresDeCadaFila.add(mayorFila);
        }
        
        for (int numero : mayoresDeCadaFila) {
            System.out.print(numero + "\t");
        }
    }
    
    private static void ordenar() {
        ArrayList<Integer> listaOrdenada = new ArrayList<Integer>();
        int indexNumeroMayor = 0;
        boolean completado = false;
        
        do {
            indexNumeroMayor = 0;
            for (int i = 0; i < mayoresDeCadaFila.size(); i++) {
                if (mayoresDeCadaFila.get(i) > mayoresDeCadaFila.get(indexNumeroMayor)) {
                    indexNumeroMayor = i;
                }
            }
            listaOrdenada.add(mayoresDeCadaFila.get(indexNumeroMayor));
            mayoresDeCadaFila.remove(indexNumeroMayor);
            if (mayoresDeCadaFila.size() < 1) {
                completado = true;
            }
        } while(!completado);
        for (Integer numero : listaOrdenada) {
            System.out.print(numero + "\t");
        }
    }
    
    private static void dosNumerosConsecutivos() {
        boolean consecutivo = false;
        int num1 = 0;
        int num2 = 0;
        for (int fila = 0; fila < filas; fila++) {
            for (int columna = 0; columna < columnas-1; columna++) {
                if (matriz[fila][columna] == matriz[fila][columna+1]-1) {
                    consecutivo = true;
                    num1 = matriz[fila][columna];
                    num2 = matriz[fila][columna+1];
                }
            }
        }
        if (consecutivo){
            System.out.println("Hay 2 números consecutivos " + num1 + " y " + num2);
        }
        else {
            System.out.println("No hay 2 números consecutivos");
        }
    }
    
}
