/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio04;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Vehiculo {
    
    public int numRuedas = 4;
    public int numPuertas = 4;
    public boolean llevaRadio = true;

    public Vehiculo() {
    }
    
    public Vehiculo(int numRuedas, int numPuertas) {
        this.numRuedas = numRuedas;
        this.numPuertas = numPuertas;
        System.out.println("Vehiculo con " + numRuedas + " ruedas y " + numPuertas + " puertas");
    }
    
}
