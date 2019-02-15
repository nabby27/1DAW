
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
public class Ejercicio08 {
    
    static int filasAM = 2;
    static int columnasAM = 3;
    static int almacenesMateriales[][] = new int[filasAM][columnasAM];
    static int filaP = 1;
    static int columnaP = 3;
    static float precios[][] = new float[filaP][columnaP];
    
    public static void main(String[] args) {
        rellenarMatrizEjemplo();
        pintar(almacenesMateriales);
        pintar(precios);
        valorTotalGeneral();
        valorTotalDeUnaPiezaEnTodosLosAlmacenes();
        valorTotalDeTodasLasPiezasPorAlmacen();
        valorDeCadaPiezaPorAlmacen();
    }
    
    private static void rellenarMatrizEjemplo() {
        almacenesMateriales[0][0] = 31;
        almacenesMateriales[0][1] = 42;
        almacenesMateriales[0][2] = 64;
        almacenesMateriales[1][0] = 50;
        almacenesMateriales[1][1] = 101;
        almacenesMateriales[1][2] = 194;
        
        precios[0][0] = 19.61F;
        precios[0][1] = 23;
        precios[0][2] = 86.04F;
    }
    
    private static void rellenarMatrizRandom() {
        Random rnd = new Random();
        
        for (int fila = 0; fila < filasAM; fila++) {
            for (int columna = 0; columna < columnasAM; columna++) {
                almacenesMateriales[fila][columna] = rnd.nextInt(11);
            }
        }
        
        for (int fila = 0; fila < filaP; fila++) {
            for (int columna = 0; columna < columnaP; columna++) {
                precios[fila][columna] = rnd.nextInt(11);
            }
        }
    }
    
    private static void pintar(int[][] matriz) {
       for (int fila = 0; fila < matriz.length; fila++) {
            for (int columna = 0; columna < matriz[fila].length; columna++) {
                System.out.print(matriz[fila][columna] + "\t");
            }
            System.out.println("");
        }
        System.out.println("");
    }
    
    private static void pintar(float[][] matriz) {
       for (int fila = 0; fila < matriz.length; fila++) {
            for (int columna = 0; columna < matriz[fila].length; columna++) {
                System.out.print(matriz[fila][columna] + "\t");
            }
            System.out.println("");
        }
        System.out.println("");
    }
    
    private static void valorTotalGeneral() {
        System.out.println("Solución A)");
        float sumaTotal = 0;
        float sumaAlmacen = 0;
        for (int columna = 0; columna < columnasAM; columna++) {
            sumaAlmacen = 0;
            for (int fila = 0; fila < filasAM; fila++) {
                sumaAlmacen += almacenesMateriales[fila][columna];
            }
            sumaTotal += sumaAlmacen*precios[0][columna];
        }
        System.out.println("El valor total general es: " + sumaTotal);
        System.out.println("");
    }
    
    private static void valorTotalDeUnaPiezaEnTodosLosAlmacenes() {
        System.out.println("Solución B)");
        float sumaTotal = 0;
        float sumaAlmacen = 0;
        for (int columna = 0; columna < columnasAM; columna++) {
            sumaAlmacen = 0;
            for (int fila = 0; fila < filasAM; fila++) {
                sumaAlmacen += almacenesMateriales[fila][columna];
            }
            System.out.println("El valor total de la pieza " + (columna+1) + " es: " + (sumaAlmacen*precios[0][columna]));
        }
        System.out.println("");
    }
    
    private static void valorTotalDeTodasLasPiezasPorAlmacen() {
        System.out.println("Solución C)");
        float suma = 0;
        for (int fila = 0; fila < filasAM; fila++) {
            suma = 0;
            for (int columna = 0; columna < columnasAM; columna++) {
                suma += almacenesMateriales[fila][columna]*precios[0][columna];
            }
            System.out.println("El valor total de todas las piezas en el almacen " + (fila+1) + " es: " + suma);
        }
        System.out.println("");
    }
    
    private static void valorDeCadaPiezaPorAlmacen() {
        float nuevaMatriz[][] = new float[filasAM][columnasAM];
        System.out.println("Solución D)");
        float suma = 0;
        for (int fila = 0; fila < filasAM; fila++) {
            suma = 0;
            for (int columna = 0; columna < columnasAM; columna++) {
                float precio = almacenesMateriales[fila][columna]*precios[0][columna];
                nuevaMatriz[fila][columna] = precio;
                System.out.println("El valor de la pieza " + (columna+1) + " en el almacen " + (fila+1) + " es: " + precio);
            }
        }
        System.out.println("");
        pintar(nuevaMatriz);
    }
    
}
