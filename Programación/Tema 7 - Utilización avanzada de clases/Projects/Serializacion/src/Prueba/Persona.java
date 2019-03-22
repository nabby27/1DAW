/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Prueba;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Persona {
    
    static int numPersonas = 0;
    public String nombre;

    public Persona(String nombre) {
        this.nombre = nombre;
        numPersonas++;
    }
    
    public void muestra() {
        System.out.println("Soy " + nombre);
        System.out.println("pero hay " + (numPersonas - 1) + " personas más");
    }
    
    public static void main(String[] args) {
        Persona p1 = new Persona("Iván");
        p1.muestra();
        Persona p2 = new Persona("Oscar");
        p2.muestra();
        Persona p3 = new Persona("Cristina");
        p3.muestra();
    }
    
}
