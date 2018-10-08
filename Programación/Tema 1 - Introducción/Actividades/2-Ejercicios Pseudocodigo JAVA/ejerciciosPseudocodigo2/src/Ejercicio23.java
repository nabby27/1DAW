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
public class Ejercicio23 {
    
    static final int numAlumnos = 20;
    
    public static void main(String[] args) {
        System.out.println("NOTAS ALUMNOS");
        
        float notaMayor = 0;
        int cantidadSuspensos = 0;
        float suma = 0;
        float nota = 0;
        Scanner teclado = new Scanner(System.in);
        
        for (int x = 0; x < numAlumnos; x++) {
            do {
                System.out.println("¿Que nota ha sacado el alumno " + (x + 1) + "?");
                nota = teclado.nextFloat();
                if ((nota < 0) || (nota > 10))
                    System.out.println("La nota no es correcta, tiene que estar entre 0 y 10");
            } while ((nota < 0) || (nota > 10));
            suma = suma + nota;
            if (nota < 5)
                cantidadSuspensos++;
            if ((nota > notaMayor) || (x == 0))
                notaMayor = nota;
        }
        
        System.out.println("La media de la clase es: " + (suma / numAlumnos));
        System.out.println("La máxima nota de la clase es: " + notaMayor);
        System.out.println("Hay " + cantidadSuspensos + " alumno/s suspenso/s");
    }
    
}
