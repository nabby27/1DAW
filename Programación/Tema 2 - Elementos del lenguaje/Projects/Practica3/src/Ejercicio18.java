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
public class Ejercicio18 {
    
    public static void main(String[] args) {
        
        float nota = 0;
        String calificacion = "";
        Scanner teclado = new Scanner(System.in);
        
        do {
            System.out.print("Dime la nota: ");
            nota = teclado.nextFloat();    
            if (nota < 0 || nota > 10)
                System.out.println("La nota tiene que estar entre 0 y 10");
        } while (nota < 0 || nota > 10);
        
        if (nota < 3)
            calificacion = "M.D.";
        else if (nota < 5 && nota >= 3)
            calificacion = "INS.";
        else if (nota < 6 && nota >= 5)
            calificacion = "SUF.";
        else if (nota < 7 && nota >= 6)
            calificacion = "BIEN";
        else if (nota < 9 && nota >= 7)
            calificacion = "NOT.";
        else if (nota <= 10 && nota >= 9)
            calificacion = "SOB.";
        
        System.out.println("La calificación del alumno es: " + calificacion);
    }
    
}
