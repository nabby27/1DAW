
import java.util.ArrayList;
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
public class Ejercicio10 {
    
    private static final int totalElementos = 10;
    
    public static void main(String[] args) {
                
        String nombre = "";
        int i = 0;
        Scanner sc = new Scanner(System.in);
        ArrayList<String> alumnos = new ArrayList<String>();
        
        
        while (i < totalElementos && !nombre.equalsIgnoreCase("f")) {
            System.out.println("Dime el nombre de un alumno ('f' para salir)");
            nombre = sc.nextLine();
            if (!nombre.equalsIgnoreCase("f"))
                alumnos.add(i, nombre);
            i++;
        }
                    
        System.out.println("Los alumnos introducidos son: \n" + alumnos);
    }
    
}
