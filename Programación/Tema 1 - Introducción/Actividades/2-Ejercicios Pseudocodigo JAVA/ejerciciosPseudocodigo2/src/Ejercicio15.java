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
public class Ejercicio15 {
        
    public static void main(String[] args) {
        System.out.println("MEDIA DE CLASE");
        
        float sumaNotas = 0;
        int sumaNumNotas = 0;
        int numAlumnos = 0;
        float numNotas = 0;
        float nota = 0;
        boolean negativo = false;
        Scanner teclado = new Scanner(System.in);
        
        System.out.println("¿Cuantos alumnos hay?");
        numAlumnos = teclado.nextInt();
            
        for (int x = 0; x < numAlumnos; x++) {
            System.out.print("Dime el número de notas que tiene el alumno " + (x+1) + ": ");
            numNotas = teclado.nextInt();
            sumaNumNotas += numNotas;
            for (int y = 0; y < numNotas; y++) {
                System.out.print("Dime la nota " + (y+1) + " del alumno " + (x+1) + ": ");
                nota = teclado.nextFloat();
                sumaNotas += nota;
            }
        }
        
        System.out.println("La nota media de la clase es: " + (sumaNotas / sumaNumNotas));
    }
    
}
