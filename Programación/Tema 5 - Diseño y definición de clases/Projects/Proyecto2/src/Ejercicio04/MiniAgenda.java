/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio04;

import java.util.ArrayList;
import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class MiniAgenda {
    
    static ArrayList<Persona> lista = new ArrayList<Persona>();
    
    public static void main(String[] args) {
        do {
            anadirPersona();
        } while(true);
    }
    
    private static void anadirPersona() {
        Scanner sc = new Scanner(System.in);
        String nombre = "";
        int edad = 0;
        int telefono = 0;
        
        System.out.println("Dime el nombre de la persona");
        nombre = sc.next();
        System.out.println("Dime la edad de la persona");
        edad  = sc.nextInt();
        System.out.println("Dime el telefono de la persona");
        telefono  = sc.nextInt();
        
        Persona pers = new Persona(nombre, edad, telefono);
        lista.add(pers);
        
        for (Persona persona : lista) {
            System.out.println(persona.toString());
        }
        
    }
    
}
