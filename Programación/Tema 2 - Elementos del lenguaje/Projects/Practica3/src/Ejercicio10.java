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
public class Ejercicio10 {
    
    public static void main(String[] args) {
        
        float nota = 0;
        char calificacion = 'F';
        Scanner teclado = new Scanner(System.in);
        
        do {
            System.out.print("Dime la nota del alumno: ");
            nota = teclado.nextFloat();
            if (nota < 0) 
                System.out.println("El número tiene que ser positivo");
        } while(nota < 0);
        
        if (nota >= 9)
            calificacion = 'A';
        else if (nota >= 8)
            calificacion = 'B';
        else if (nota >= 7)
            calificacion = 'C';
        else if (nota >= 6)
            calificacion = 'D';
        else
            calificacion = 'F';
        
        System.out.println("La calificacion del alumno es: " + calificacion);
    }
    
}
