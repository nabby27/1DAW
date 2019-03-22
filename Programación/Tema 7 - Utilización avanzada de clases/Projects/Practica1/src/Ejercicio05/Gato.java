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
public class Gato extends Animal {
    
    private int edad;

    public Gato(int edad, String especie, String ruido, String comida) {
        super(especie, ruido, comida);
        this.edad = edad;
    }
    
    public String obtenerRuido() {
        return this.ruido; 
    }
    
    public void ver() {
        System.out.println("Ruido: " + this.ruido);
        System.out.println("Edad: " + this.edad);
        System.out.println("Comida: " + this.comida);
    }
    
}
