/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ejercicio03;

/**
 *
 * @author Iván Córdoba Donet
 */
public class Punto3D extends Punto {
    
    private double z;

    public Punto3D(double x, double y, double z) {
        super(x, y);
        this.z = z;
    }
    
    public String dameCoordenadas() {
        return "(" + x + ", " + ordenada() + ", " + z + ")";
    }
    
    public double distanciaAlcentro() {
        return Math.sqrt(Math.pow(x, 2) + Math.pow(ordenada(), 2) + Math.pow(z, 2));
    }
    
}
