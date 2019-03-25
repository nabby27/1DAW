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
public abstract class Persona {
    
    private String nombre;
    private String identificacion;

    public Persona() {
    }

    public Persona(String nombre, String identificacion) {
        this.nombre = nombre;
        this.identificacion = identificacion;
    }
    
    public String obtenerCarnet() {
        return    "Nombre: " + this.nombre + "\n"
                + "Identifiación: " + this.identificacion;
    }   
    
}
