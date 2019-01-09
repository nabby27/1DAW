
import java.util.ArrayList;
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
public class Ejercicio16 {
    
    static int numeroColumnas = 6;
    static int numeroFilas = 6;
    
    public static void main(String[] args) {
        
        ArrayList<ArrayList<Integer>> matriz = new ArrayList<>();
        
        rellenarMatriz(matriz);
        
        pintarMatriz(matriz);
        
        sumaFilas(matriz);
        
        filaNumeroMayor(matriz);
        
        intercambiarColumna(matriz, 1, 4);
        
        pintarMatriz(matriz);
    }
    
    private static void rellenarMatriz(ArrayList<ArrayList<Integer>> matriz) {
        Random rnd = new Random();
        ArrayList<Integer> columnas;
        
        for (int i = 0; i < numeroFilas; i++) {
            columnas = new ArrayList<>();
            for (int j = 0; j < numeroColumnas; j++) {
                columnas.add(rnd.nextInt(101));
            }
            matriz.add(columnas);
        }
        
    }
    
    private static void sumaFilas(ArrayList<ArrayList<Integer>> matriz) {
        int sumFila;
        
        for (ArrayList<Integer> fila : matriz) {
            sumFila = 0;
            for (Integer numero : fila) {
                sumFila += numero;
            }
            System.out.println("La suma de la fila " + (matriz.indexOf(fila)+1) + " es: " + sumFila);
        }
    }
 
    private static void pintarMatriz(ArrayList<ArrayList<Integer>> matriz) {
        for (ArrayList<Integer> filas : matriz) {
            for (Integer numero : filas) {
                System.out.print(numero + "\t");
            }
            System.out.println("");
        }
    }
    
    private static void filaNumeroMayor(ArrayList<ArrayList<Integer>> matriz) {
        ArrayList<Integer> filasNumeroMayor = new ArrayList<Integer>();
        int numeroMayor = 0;
        
        for (ArrayList<Integer> fila : matriz) {
            for (Integer numero : fila) {
                if (numero > numeroMayor) {
                    numeroMayor = numero;
                }
            }
        }
        
        for (ArrayList<Integer> fila : matriz) {
            if (fila.contains(numeroMayor)) {
                filasNumeroMayor.add(matriz.indexOf(fila)+1);
            }
        }
        
        System.out.println("Las filas con el número mas grande son: " + filasNumeroMayor);
    }
    
    private static void intercambiarColumna(ArrayList<ArrayList<Integer>> matriz, int columna1, int columna2) {
        int num1 = 0;
        int num2 = 0;
        
        for (ArrayList<Integer> fila : matriz) {
            num1 = fila.get(columna1);
            num2 = fila.get(columna2);
            
            fila.set(columna1, num2);
            fila.set(columna2, num1);
        }
        
        System.out.println("sutituido los valores de las columnas " + (columna1+1) + " y " + (columna2+1));
    }
    
}
