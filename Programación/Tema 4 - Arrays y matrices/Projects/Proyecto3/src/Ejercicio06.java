
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
public class Ejercicio06 {
    
    static final int filas = 5;
    static final int columnas = 3;
    static int[][] matriz = new int[filas][columnas];
    
    public static void main(String[] args) {
        rellenoManual();
        mostrarGrupo();
        mediaPorAlumnoAprobado();
        maximaNotaPorModulo();
        mediaNotaPorModulo();
    }
    
    private static void rellenoManual() {
        Scanner sc = new Scanner(System.in);
        int nota = 0;
        for (int fila = 0; fila < filas; fila++) {
            for (int columna = 0; columna < columnas; columna++) {
                do {
                    System.out.println("Dime la nota del modulo " + (columna+1) + " para el alumno " + (fila+1));
                    nota = sc.nextInt();
                    if (nota < 0 || nota > 10)
                        System.out.println("La nota tiene que estar entre 0 y 10");
                } while (nota < 0 || nota > 10);
                matriz[fila][columna] = nota;
            }
        }
    }
    
    private static void rellenoAleatorio() {
        Random rnd = new Random();
        for (int fila = 0; fila < filas; fila++) {
            for (int columna = 0; columna < columnas; columna++) {
                matriz[fila][columna] = rnd.nextInt(11);
            }
        }
    }

    private static void mostrarGrupo() {
       for (int fila = 0; fila < filas; fila++) {
            for (int columna = 0; columna < columnas; columna++) {
                System.out.print(matriz[fila][columna] + "\t");
            }
            System.out.println("");
        } 
    }
    
    private static void mediaPorAlumnoAprobado() {
        boolean aprobados;
        float sumador;
        int contador;
        for (int fila = 0; fila < filas; fila++) {
            aprobados = true;
            sumador = 0;
            contador = 0;
            for (int columna = 0; columna < columnas; columna++) {
                contador++;
                if (matriz[fila][columna] > 4) {
                    sumador += matriz[fila][columna];
                } else {
                    aprobados = false;
                }
            }
            if (aprobados)
                System.out.println("La media del alumno " + (fila+1) + " es: " + (sumador/contador));
            else
                System.out.println("El alumno " + (fila+1) + " tiene algun modulo suspendido");
        } 
        System.out.println("");
    }
    
    private static void maximaNotaPorModulo() {
        int notaMaxima;
        int alumno = 0;
        for (int columna = 0; columna < columnas; columna++) {
            notaMaxima = 0;
            for (int fila = 0; fila < filas; fila++) {
                if (matriz[fila][columna] > notaMaxima) {
                    notaMaxima = matriz[fila][columna];
                    alumno = fila;
                }
            }
            System.out.println("La nota mas alta del modulo " + (columna+1) + " la tiene el alumno " + (alumno+1));
        }
        System.out.println("");
    }
    
    private static void mediaNotaPorModulo() {
        int contador;
        float sumador;
        for (int columna = 0; columna < columnas; columna++) {
            sumador = 0;
            contador = 0;
            for (int fila = 0; fila < filas; fila++) {
                contador++;
                sumador += matriz[fila][columna];
            }
            System.out.println("La media del modulo " + (columna+1) + " es:" + (sumador/contador));
        }
        System.out.println("");
    }
    
}
