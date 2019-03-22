/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio05;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Granja {
    
    public static void main(String[] args) {
        
        Perro perro = new Perro(4, "Galgo", "Guau", "Hueso");
        Gato gato = new Gato(4, "Siames", "Miau", "Sardina");
        
        System.out.println("Perro");
        System.out.println("--------------------");
        System.out.println("Ruido: " + perro.obtenerRuido());
        System.out.println("Comida: " + perro.obtenerComida());
        System.out.println("");
        System.out.println("Gato");
        System.out.println("--------------------");
        gato.ver();
        
    }
    
}
