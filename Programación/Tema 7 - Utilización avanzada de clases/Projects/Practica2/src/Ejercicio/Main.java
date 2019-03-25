/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Main {
    
    public static void main(String[] args) {
        Estudiante oscar = new Estudiante("Oscar", "1234A", 1);
        PD ivan = new PD("Iván", "4567V", "nomina 1", "Informatica");
        PAS cristina = new PAS("Cristina", "3475B", "nomina 2", "Secretaria");
        
        System.out.println(oscar.obtenerCarnet());
        System.out.println(ivan.obtenerCarnet());
        System.out.println(cristina.obtenerCarnet());
    }
    
}
