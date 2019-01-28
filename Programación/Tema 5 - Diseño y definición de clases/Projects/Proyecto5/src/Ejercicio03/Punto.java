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
public class Punto {

    private double altitud;
    private double latitud;
    
    public Punto() {
        this.altitud = 0;
        this.latitud = 0;
    }

    public Punto(double altitud, double latitud) {
        this.altitud = altitud;
        this.latitud = latitud;
    }

    public double getAltitud() {
        return altitud;
    }

    public void setAltitud(double altitud) {
        this.altitud = altitud;
    }

    public double getLatitud() {
        return latitud;
    }

    public void setLatitud(double latitud) {
        this.latitud = latitud;
    }

    @Override
    public String toString() {
        return    "Altitud: " + altitud + "\t"
                + "Latitud: " + latitud ;
    }
    
    
    
}
