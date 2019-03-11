/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio04;

import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Apli_Persona {
    
    public static void main(String[] args) throws Exception {
        int edad = 0;
        do {
            Scanner sc = new Scanner(System.in);
            System.out.println("Dime la edad");
            edad = sc.nextInt();
            Persona persona = new Persona();
            persona.setEdad(edad);
            System.out.println(persona.toString());
        } while(edad < 0 || edad > 100);
    }
    
}
