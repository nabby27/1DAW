/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio03;

import java.util.Scanner;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Alumno {
    
    public static void main(String[] args) {
        String nombre = "";
        int edad = 0;
        Scanner sc = new Scanner(System.in);
        
        System.out.println("Dime el nombre del alumno");
        nombre = sc.next();
        System.out.println("Dime la edad del alumno");
        edad = sc.nextInt();
        
        Alumno alumno = new Alumno(nombre, edad);
        System.out.println(alumno.toString());
    }
    
    private String nombre;
    private int edad;
    
    public Alumno(String nombre, int edad) {
        this.nombre = nombre;
        this.edad = edad;
    }

    @Override
    public String toString() {
        return "Alumno{" + "nombre=" + this.nombre + ", edad=" + this.edad + '}';
    }
    
}
