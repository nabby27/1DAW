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
    
    static final int numAlumnos = 3;
    static final int numModulos = 4;
    
    public static void main(String[] args) {
        
        int nota = 0;
        int sumaNota = 0;
        int[] suspensos = new int[numModulos];
        int[] aprobados = new int[numModulos];
        int[][] alumnoModulo = new int[numAlumnos][numModulos];
        Scanner teclado = new Scanner(System.in);
        
        for (int a = 1; a <= numAlumnos; a++) {
            for (int m = 1; m <= numModulos; m++) {
                do {
                    System.out.print("Para el alumno " + a + " dime la nota del modulo " + m +": ");
                    nota = teclado.nextInt();
                    if (nota < 0 || nota > 10)
                        System.out.println("La nota tiene que estar entre 0 y 10");
                } while (nota < 0 || nota > 10);
                if (nota < 5)
                    suspensos[m-1]++;
                else 
                    aprobados[m-1]++;
                sumaNota += nota;
                alumnoModulo[a-1][m-1] = nota;
            }
        }
        
        for (int m = 1; m <= numModulos; m++) {
            int sumaModulos = 0;
            for (int a = 1; a <= numAlumnos; a++) {
                sumaModulos += alumnoModulo[a-1][m-1];
            }
            System.out.println("La media del modulo " + m + " es : " + (sumaModulos / numAlumnos));
            System.out.println("Han aprobado este modulo " + aprobados[m-1] + " alumnos");
            System.out.println("Han suspendido este modulo " + suspensos[m-1] + " alumnos");
        }
        
    }
}
