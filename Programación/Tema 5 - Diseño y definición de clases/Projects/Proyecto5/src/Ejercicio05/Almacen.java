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
public class Almacen {
    
    private String nombre;
    private int distancia;
    private int capacidad;
    private int ocupadas;

    public Almacen() {
    }

    public Almacen(String nombre, int distancia, int capacidad) {
        this.nombre = nombre;
        this.distancia = distancia;
        this.capacidad = capacidad;
        this.ocupadas = 0;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getDistancia() {
        return distancia;
    }

    public void setDistancia(int distancia) {
        this.distancia = distancia;
    }

    public int getCapacidad() {
        return capacidad;
    }

    public void setCapacidad(int capacidad) {
        this.capacidad = capacidad;
    }

    public int getOcupadas() {
        return ocupadas;
    }

    public void setOcupadas(int ocupadas) {
        this.ocupadas = ocupadas;
    }

    @Override
    public String toString() {
        return    "Nombre: " + nombre + "\t "
                + "Distancia: " + distancia + "\t"
                + "Capacidad: " + capacidad + "\t"
                + "Ocupadas: " + ocupadas;
    }
    
    
    
}
