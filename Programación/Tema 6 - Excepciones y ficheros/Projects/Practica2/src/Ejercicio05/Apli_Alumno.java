/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio05;

import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Apli_Alumno {
    
    static int numMaximoAlumnos = 10;
    static Alumno alumnos[] = new Alumno[numMaximoAlumnos];
    
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int np = 0;
        String nombre = "";
        double nota1 = 0;
        double nota2 = 0;
        int numAlumno = 0;
        do {
            System.out.println("Dime el numero personal");
            np = sc.nextInt();
            sc.skip("\n");
            if (np > 0) {
                System.out.println("Dime el nombre del alumno");
                nombre = sc.nextLine();
                System.out.println("Dime la nota 1");
                nota1 = sc.nextDouble();
                System.out.println("Dime la nota 2");
                nota2 = sc.nextDouble();
                Alumno alumno = new Alumno(np, nombre);
                alumno.ponNota(nota1, nota2);
                alumnos[numAlumno] = alumno;
                numAlumno++;                 
            }
        } while (np > 0 && numAlumno < numMaximoAlumnos);
        
        System.out.println("");
        double sum = 0;
        int cont = 0;
        for (int i = 0; i < numAlumno; i++) {
            System.out.println(alumnos[i].muestraAlumno());
            sum += alumnos[i].dameMedia();
            cont++;
        }
        
        if (numAlumno > 0) {
            System.out.println("");
            System.out.println("Media de toda la clase");
            System.out.println(sum / cont);
        }
        
    }
    
}
